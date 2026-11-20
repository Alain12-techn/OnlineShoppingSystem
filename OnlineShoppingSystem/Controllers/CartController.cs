using System.Data;
using OnlineShoppingSystem.Data;
using OnlineShoppingSystem.Helpers;

namespace OnlineShoppingSystem.Controllers;

public class CartController
{
    public DataTable GetItems(int userId) => Db.Query(
        @"SELECT ci.id,p.id AS product_id,p.name,p.price,ci.quantity,p.stock_qty,(p.price*ci.quantity) AS line_total
          FROM cart_items ci JOIN products p ON p.id=ci.product_id WHERE ci.user_id=@u ORDER BY ci.id", "@u", userId);

    /// <summary>FR-11 / FR-13: add to cart without exceeding stock.</summary>
    public void Add(int userId, int productId, int qty)
    {
        if (qty <= 0) throw new AppException("Quantity must be at least 1.");
        var p = Db.Query("SELECT stock_qty FROM products WHERE id=@p", "@p", productId);
        if (p.Rows.Count == 0) throw new AppException("Product not found.");
        int stock = Convert.ToInt32(p.Rows[0]["stock_qty"]);
        int inCart = Convert.ToInt32(Db.Scalar("SELECT COALESCE(SUM(quantity),0) FROM cart_items WHERE user_id=@u AND product_id=@p", "@u", userId, "@p", productId));
        if (inCart + qty > stock) throw new AppException($"Only {stock} unit(s) in stock ({inCart} already in your cart).");
        Db.Execute("INSERT INTO cart_items(user_id,product_id,quantity) VALUES(@u,@p,@q) ON DUPLICATE KEY UPDATE quantity=quantity+@q",
            "@u", userId, "@p", productId, "@q", qty);
    }

    public void UpdateQuantity(int cartItemId, int userId, int qty)
    {
        if (qty <= 0) { Remove(cartItemId, userId); return; }
        var r = Db.Query("SELECT p.stock_qty FROM cart_items ci JOIN products p ON p.id=ci.product_id WHERE ci.id=@i AND ci.user_id=@u", "@i", cartItemId, "@u", userId);
        if (r.Rows.Count == 0) throw new AppException("Cart item not found.");
        int stock = Convert.ToInt32(r.Rows[0]["stock_qty"]);
        if (qty > stock) throw new AppException($"Only {stock} unit(s) in stock.");
        Db.Execute("UPDATE cart_items SET quantity=@q WHERE id=@i AND user_id=@u", "@q", qty, "@i", cartItemId, "@u", userId);
    }

    public void Remove(int cartItemId, int userId) => Db.Execute("DELETE FROM cart_items WHERE id=@i AND user_id=@u", "@i", cartItemId, "@u", userId);

    public void Clear(int userId) => Db.Execute("DELETE FROM cart_items WHERE user_id=@u", "@u", userId);
}
