using System.Data;
using System.Text;
using OnlineShoppingSystem.Data;
using OnlineShoppingSystem.Helpers;

namespace OnlineShoppingSystem.Controllers;

public class OrderController
{
    public static readonly string[] Statuses = { "Pending", "Processing", "Shipped", "Delivered", "Cancelled" };

    /// <summary>FR-15 to FR-18: creates the order, order lines, payment, reduces stock, empties the cart - all in one transaction.</summary>
    public int PlaceOrder(int userId, int addressId, string shippingName, decimal shippingFee, string method, string couponCode)
    {
        long oid;
        using (var tx = new DbTx())
        {
            var items = tx.Query(@"SELECT ci.product_id,p.name,p.price,ci.quantity,p.stock_qty FROM cart_items ci
                                   JOIN products p ON p.id=ci.product_id WHERE ci.user_id=@u FOR UPDATE", "@u", userId);
            if (items.Rows.Count == 0) throw new AppException("Your cart is empty.");

            decimal subtotal = 0;
            foreach (DataRow r in items.Rows)
            {
                int q = Convert.ToInt32(r["quantity"]), stock = Convert.ToInt32(r["stock_qty"]);
                if (q > stock) throw new AppException($"'{r["name"]}' only has {stock} unit(s) left. Please update your cart.");
                subtotal += Convert.ToDecimal(r["price"]) * q;
            }

            decimal pct = 0; string code = null;
            if (!string.IsNullOrWhiteSpace(couponCode))
            {
                var c = new CouponController().GetValid(couponCode);
                pct = c.DiscountPercent; code = c.Code;
            }
            var t = Pricing.Compute(subtotal, pct, shippingFee);

            oid = tx.Insert(@"INSERT INTO orders(user_id,status,subtotal,discount,tax,shipping_fee,total_amount,address_id,shipping_method,coupon_code)
                              VALUES(@u,'Pending',@s,@d,@t,@f,@tot,@a,@m,@c)",
                "@u", userId, "@s", t.Subtotal, "@d", t.Discount, "@t", t.Tax, "@f", t.Shipping, "@tot", t.Total,
                "@a", addressId, "@m", shippingName, "@c", code);

            foreach (DataRow r in items.Rows)
            {
                tx.Execute("INSERT INTO order_items(order_id,product_id,product_name,quantity,unit_price) VALUES(@o,@p,@n,@q,@u)",
                    "@o", oid, "@p", r["product_id"], "@n", r["name"], "@q", r["quantity"], "@u", r["price"]);
                tx.Execute("UPDATE products SET stock_qty=stock_qty-@q WHERE id=@p", "@q", r["quantity"], "@p", r["product_id"]);
            }

            bool card = method == "Card";
            tx.Execute("INSERT INTO payments(order_id,method,amount,status,paid_on) VALUES(@o,@m,@a,@s,@pd)",
                "@o", oid, "@m", method, "@a", t.Total, "@s", card ? "Paid" : "Pending", "@pd", card ? (object)DateTime.Now : null);
            tx.Execute("DELETE FROM cart_items WHERE user_id=@u", "@u", userId);
            tx.Commit();
        }

        var u = Session.CurrentUser;
        if (u != null)
            Notifier.Send(userId, u.Email, $"Order #{oid} confirmed", $"Thank you {u.Name}! Your order #{oid} has been received and is now Pending.");
        return (int)oid;
    }

    private const string OrderSelect = @"SELECT o.id AS order_id,o.order_date,u.name AS customer,u.email,o.status,o.total_amount,
              COALESCE(pay.method,'') AS payment_method,COALESCE(pay.status,'') AS payment_status,COALESCE(o.return_status,'') AS return_status
              FROM orders o JOIN users u ON u.id=o.user_id LEFT JOIN payments pay ON pay.order_id=o.id ";

    /// <summary>FR-19: customer order history.</summary>
    public DataTable GetByUser(int userId) => Db.Query(OrderSelect + "WHERE o.user_id=@u ORDER BY o.id DESC", "@u", userId);

    /// <summary>FR-21: admin view of all orders.</summary>
    public DataTable GetAll(string status, string search) => Db.Query(
        OrderSelect + @"WHERE (@st='All' OR o.status=@st) AND (u.name LIKE @s OR u.email LIKE @s OR CAST(o.id AS CHAR) LIKE @s)
                        ORDER BY o.id DESC", "@st", status ?? "All", "@s", "%" + (search ?? "") + "%");

    public DataTable GetItems(int orderId) => Db.Query(
        @"SELECT oi.id AS item_id,oi.product_id,oi.product_name,oi.quantity,oi.unit_price,(oi.quantity*oi.unit_price) AS line_total
          FROM order_items oi WHERE oi.order_id=@o ORDER BY oi.id", "@o", orderId);

    private static void CancelInternal(DbTx tx, int orderId)
    {
        tx.Execute("UPDATE products p JOIN order_items oi ON oi.product_id=p.id SET p.stock_qty=p.stock_qty+oi.quantity WHERE oi.order_id=@o", "@o", orderId);
        tx.Execute("UPDATE orders SET status='Cancelled' WHERE id=@o", "@o", orderId);
        tx.Execute("UPDATE payments SET status=IF(status='Paid','Refunded','Cancelled') WHERE order_id=@o", "@o", orderId);
    }

    private static DataRow Load(DbTx tx, int orderId)
    {
        var dt = tx.Query("SELECT o.id,o.user_id,o.status,o.return_status,u.email,u.name FROM orders o JOIN users u ON u.id=o.user_id WHERE o.id=@o FOR UPDATE", "@o", orderId);
        if (dt.Rows.Count == 0) throw new AppException("Order not found.");
        return dt.Rows[0];
    }

    /// <summary>FR-20: customer cancels before shipping.</summary>
    public void Cancel(int orderId, int userId)
    {
        DataRow o;
        using (var tx = new DbTx())
        {
            o = Load(tx, orderId);
            if (Convert.ToInt32(o["user_id"]) != userId) throw new AppException("This is not your order.");
            string st = (string)o["status"];
            if (st != "Pending" && st != "Processing") throw new AppException($"An order that is {st} can no longer be cancelled.");
            CancelInternal(tx, orderId);
            tx.Commit();
        }
        Notifier.Send(userId, (string)o["email"], $"Order #{orderId} cancelled", "Your order has been cancelled. Any payment will be refunded.");
    }

    /// <summary>FR-21: admin changes the order status; the customer is notified.</summary>
    public void UpdateStatus(int orderId, string newStatus)
    {
        if (Array.IndexOf(Statuses, newStatus) < 0) throw new AppException("Invalid status.");
        DataRow o;
        using (var tx = new DbTx())
        {
            o = Load(tx, orderId);
            string cur = (string)o["status"];
            if (cur == newStatus) throw new AppException("The order already has this status.");
            if (cur == "Cancelled") throw new AppException("A cancelled order cannot be changed.");
            if (newStatus == "Cancelled")
            {
                if (cur == "Delivered") throw new AppException("A delivered order cannot be cancelled. Use the return/refund process.");
                CancelInternal(tx, orderId);
            }
            else
            {
                tx.Execute("UPDATE orders SET status=@s WHERE id=@o", "@s", newStatus, "@o", orderId);
                if (newStatus == "Delivered")
                    tx.Execute("UPDATE payments SET status='Paid', paid_on=COALESCE(paid_on,NOW()) WHERE order_id=@o AND status='Pending'", "@o", orderId);
            }
            tx.Commit();
        }
        Notifier.Send(Convert.ToInt32(o["user_id"]), (string)o["email"], $"Order #{orderId} is now {newStatus}", $"The status of your order #{orderId} changed to {newStatus}.");
    }

    /// <summary>FR-23: customer asks for a return/refund.</summary>
    public void RequestReturn(int orderId, int userId)
    {
        int n = Db.Execute("UPDATE orders SET return_status='Requested' WHERE id=@o AND user_id=@u AND status='Delivered' AND return_status IS NULL", "@o", orderId, "@u", userId);
        if (n == 0) throw new AppException("A return can only be requested once for a delivered order.");
    }

    public void ResolveReturn(int orderId, bool approve)
    {
        DataRow o;
        using (var tx = new DbTx())
        {
            o = Load(tx, orderId);
            if (UI.Str(o["return_status"]) != "Requested") throw new AppException("There is no pending return request for this order.");
            if (approve)
            {
                tx.Execute("UPDATE products p JOIN order_items oi ON oi.product_id=p.id SET p.stock_qty=p.stock_qty+oi.quantity WHERE oi.order_id=@o", "@o", orderId);
                tx.Execute("UPDATE payments SET status='Refunded' WHERE order_id=@o", "@o", orderId);
            }
            tx.Execute("UPDATE orders SET return_status=@r WHERE id=@o", "@r", approve ? "Approved" : "Rejected", "@o", orderId);
            tx.Commit();
        }
        Notifier.Send(Convert.ToInt32(o["user_id"]), (string)o["email"], $"Return request for order #{orderId}",
            approve ? "Your return was approved and the amount will be refunded." : "Your return request was rejected.");
    }

    /// <summary>FR-22: printable invoice text.</summary>
    public string BuildInvoice(int orderId)
    {
        var o = Db.Query(@"SELECT o.order_date,o.status,o.subtotal,o.discount,o.tax,o.shipping_fee,o.total_amount,o.shipping_method,o.coupon_code,
                           u.name AS customer,u.email,a.street,a.city,pay.method AS pay_method,pay.status AS pay_status
                           FROM orders o JOIN users u ON u.id=o.user_id LEFT JOIN addresses a ON a.id=o.address_id
                           LEFT JOIN payments pay ON pay.order_id=o.id WHERE o.id=@o", "@o", orderId);
        if (o.Rows.Count == 0) throw new AppException("Order not found.");
        var r = o.Rows[0];
        const int W = 62;
        string dbl = new string('=', W), line = new string('-', W);
        string Center(string s) => s.PadLeft((W + s.Length) / 2);
        string Money(object v) => Convert.ToDecimal(v).ToString("N2");

        var sb = new StringBuilder();
        sb.AppendLine(dbl); sb.AppendLine(Center("ONLINE SHOPPING SYSTEM")); sb.AppendLine(Center("INVOICE")); sb.AppendLine(dbl);
        sb.AppendLine($"Invoice #  : {orderId:D6}");
        sb.AppendLine($"Date       : {Convert.ToDateTime(r["order_date"]):yyyy-MM-dd HH:mm}");
        sb.AppendLine($"Status     : {r["status"]}");
        sb.AppendLine($"Customer   : {r["customer"]} ({r["email"]})");
        sb.AppendLine($"Ship to    : {UI.Str(r["street"])}, {UI.Str(r["city"])}");
        sb.AppendLine($"Shipping   : {UI.Str(r["shipping_method"])}");
        sb.AppendLine($"Payment    : {UI.Str(r["pay_method"])} ({UI.Str(r["pay_status"])})");
        sb.AppendLine(line);
        sb.AppendLine(string.Format("{0,-34}{1,5}{2,11}{3,12}", "Item", "Qty", "Price", "Total"));
        sb.AppendLine(line);
        foreach (DataRow it in GetItems(orderId).Rows)
        {
            string name = (string)it["product_name"]; if (name.Length > 33) name = name.Substring(0, 33);
            sb.AppendLine(string.Format("{0,-34}{1,5}{2,11}{3,12}", name, it["quantity"], Money(it["unit_price"]), Money(it["line_total"])));
        }
        sb.AppendLine(line);
        void Row(string label, string val) => sb.AppendLine(label.PadLeft(W - 14) + val.PadLeft(14));
        Row("Subtotal:", Money(r["subtotal"]));
        Row("Discount" + (UI.Str(r["coupon_code"]) != "" ? " (" + r["coupon_code"] + "):" : ":"), "-" + Money(r["discount"]));
        Row("Tax:", Money(r["tax"]));
        Row("Shipping:", Money(r["shipping_fee"]));
        Row("TOTAL:", Money(r["total_amount"]));
        sb.AppendLine(dbl); sb.AppendLine(Center("Thank you for shopping with us!"));
        return sb.ToString();
    }
}
