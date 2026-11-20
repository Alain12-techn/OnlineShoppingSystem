using System.Data;
using OnlineShoppingSystem.Controllers;
using OnlineShoppingSystem.Helpers;

namespace OnlineShoppingSystem.Views;

public partial class OrdersControl : UserControl
{
    private readonly OrderController _orders = new();
    private readonly ReviewController _reviews = new();

    public OrdersControl() { InitializeComponent(); }

    private void OrdersControl_Load(object sender, EventArgs e)
    {
        if (DesignMode) return;
        LoadOrders();
    }

    private void LoadOrders()
    {
        try
        {
            gridOrders.DataSource = _orders.GetByUser(Session.UserId);
            UI.ShowColumns(gridOrders, ("order_id", "Order #"), ("order_date", "Date"), ("status", "Status"), ("total_amount", "Total"),
                ("payment_method", "Payment"), ("payment_status", "Payment status"), ("return_status", "Return"));
            UI.Format(gridOrders, "N2", "total_amount");
            UI.Format(gridOrders, "yyyy-MM-dd HH:mm", "order_date");
            LoadItems();
        }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void LoadItems()
    {
        var o = UI.SelectedRow(gridOrders);
        if (o == null) { gridItems.DataSource = null; UpdateButtons(); return; }
        gridItems.DataSource = _orders.GetItems(Convert.ToInt32(o["order_id"]));
        UI.ShowColumns(gridItems, ("product_name", "Product"), ("quantity", "Qty"), ("unit_price", "Unit price"), ("line_total", "Total"));
        UI.Format(gridItems, "N2", "unit_price", "line_total");
        UpdateButtons();
    }

    private void UpdateButtons()
    {
        var o = UI.SelectedRow(gridOrders);
        string st = o == null ? "" : UI.Str(o["status"]);
        bool hasReturn = o != null && UI.Str(o["return_status"]) != "";
        btnCancelOrder.Enabled = st == "Pending" || st == "Processing";
        btnReturn.Enabled = st == "Delivered" && !hasReturn;
        btnInvoice.Enabled = o != null;
        btnSubmitReview.Enabled = st == "Delivered" && UI.SelectedRow(gridItems) != null;
    }

    private void gridOrders_SelectionChanged(object sender, EventArgs e)
    {
        try { LoadItems(); } catch (Exception ex) { UI.Error(ex); }
    }

    private void gridItems_SelectionChanged(object sender, EventArgs e)
    {
        var it = UI.SelectedRow(gridItems);
        lblSelItem.Text = it == null ? "Select an item in the list." : "Item: " + UI.Str(it["product_name"]);
        UpdateButtons();
    }

    private void btnRefresh_Click(object sender, EventArgs e) => LoadOrders();

    private void btnCancelOrder_Click(object sender, EventArgs e)
    {
        var o = UI.SelectedRow(gridOrders);
        if (o == null || !UI.Confirm("Cancel this order?")) return;
        try { _orders.Cancel(Convert.ToInt32(o["order_id"]), Session.UserId); UI.Info("Order cancelled."); LoadOrders(); }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnInvoice_Click(object sender, EventArgs e)
    {
        var o = UI.SelectedRow(gridOrders);
        if (o == null) return;
        using var f = new InvoiceForm(Convert.ToInt32(o["order_id"]));
        f.ShowDialog(FindForm());
    }

    private void btnReturn_Click(object sender, EventArgs e)
    {
        var o = UI.SelectedRow(gridOrders);
        if (o == null || !UI.Confirm("Request a return / refund for this order?")) return;
        try { _orders.RequestReturn(Convert.ToInt32(o["order_id"]), Session.UserId); UI.Info("Return request sent to the administrator."); LoadOrders(); }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnSubmitReview_Click(object sender, EventArgs e)
    {
        var it = UI.SelectedRow(gridItems);
        if (it == null || it["product_id"] == DBNull.Value) { UI.Warn("Select an item that still exists in the catalogue."); return; }
        try
        {
            _reviews.Submit(Session.UserId, Convert.ToInt32(it["product_id"]), (int)nudRating.Value, txtComment.Text.Trim());
            UI.Info("Thank you! Your review will be visible once the administrator approves it.");
            txtComment.Clear();
        }
        catch (Exception ex) { UI.Error(ex); }
    }
}
