using System.Data;
using OnlineShoppingSystem.Controllers;
using OnlineShoppingSystem.Helpers;

namespace OnlineShoppingSystem.Views;

public partial class OrdersAdminControl : UserControl
{
    private readonly OrderController _orders = new();
    private bool _ready;

    public OrdersAdminControl() { InitializeComponent(); }

    private void OrdersAdminControl_Load(object sender, EventArgs e)
    {
        if (DesignMode) return;
        cboFilter.Items.Add("All");
        cboFilter.Items.AddRange(OrderController.Statuses);
        cboFilter.SelectedIndex = 0;
        cboStatus.Items.AddRange(OrderController.Statuses);
        cboStatus.SelectedIndex = 0;
        _ready = true;
        LoadOrders(0);
    }

    private void LoadOrders(int keepOrderId)
    {
        if (!_ready) return;
        try
        {
            gridOrders.DataSource = _orders.GetAll(cboFilter.SelectedItem?.ToString() ?? "All", txtSearch.Text.Trim());
            UI.ShowColumns(gridOrders, ("order_id", "Order #"), ("order_date", "Date"), ("customer", "Customer"), ("status", "Status"),
                ("total_amount", "Total"), ("payment_method", "Payment"), ("payment_status", "Paid?"), ("return_status", "Return"));
            UI.Format(gridOrders, "N2", "total_amount");
            UI.Format(gridOrders, "yyyy-MM-dd HH:mm", "order_date");
            if (keepOrderId > 0)
                foreach (DataGridViewRow row in gridOrders.Rows)
                    if (Convert.ToInt32(((DataRowView)row.DataBoundItem)["order_id"]) == keepOrderId) { gridOrders.CurrentCell = row.Cells[gridOrders.Columns["status"].Index]; break; }
            ShowSelected();
        }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void ShowSelected()
    {
        var o = UI.SelectedRow(gridOrders);
        if (o == null)
        {
            lblSelected.Text = "Select an order."; lblReturnState.Text = "None"; gridItems.DataSource = null; return;
        }
        int id = Convert.ToInt32(o["order_id"]);
        lblSelected.Text = $"Order #{id}\r\n{o["customer"]} ({o["email"]})\r\nTotal: {UI.Money(o["total_amount"])}";
        cboStatus.SelectedItem = UI.Str(o["status"]);
        string rs = UI.Str(o["return_status"]);
        lblReturnState.Text = rs == "" ? "None" : rs;
        btnApproveReturn.Enabled = btnRejectReturn.Enabled = rs == "Requested";
        gridItems.DataSource = _orders.GetItems(id);
        UI.ShowColumns(gridItems, ("product_name", "Product"), ("quantity", "Qty"), ("unit_price", "Unit price"), ("line_total", "Total"));
        UI.Format(gridItems, "N2", "unit_price", "line_total");
    }

    private void cboFilter_SelectedIndexChanged(object sender, EventArgs e) => LoadOrders(0);
    private void txtSearch_TextChanged(object sender, EventArgs e) => LoadOrders(0);
    private void btnRefresh_Click(object sender, EventArgs e) => LoadOrders(SelectedId());

    private int SelectedId() { var o = UI.SelectedRow(gridOrders); return o == null ? 0 : Convert.ToInt32(o["order_id"]); }

    private void gridOrders_SelectionChanged(object sender, EventArgs e)
    {
        try { ShowSelected(); } catch (Exception ex) { UI.Error(ex); }
    }

    private void btnUpdateStatus_Click(object sender, EventArgs e)
    {
        int id = SelectedId();
        if (id == 0) { UI.Warn("Select an order first."); return; }
        try
        {
            _orders.UpdateStatus(id, (string)cboStatus.SelectedItem);
            UI.Info("Status updated and the customer was notified.");
            LoadOrders(id);
        }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnInvoice_Click(object sender, EventArgs e)
    {
        int id = SelectedId();
        if (id == 0) { UI.Warn("Select an order first."); return; }
        using var f = new InvoiceForm(id);
        f.ShowDialog(FindForm());
    }

    private void btnApproveReturn_Click(object sender, EventArgs e) => Resolve(true);
    private void btnRejectReturn_Click(object sender, EventArgs e) => Resolve(false);

    private void Resolve(bool approve)
    {
        int id = SelectedId();
        if (id == 0) return;
        try { _orders.ResolveReturn(id, approve); LoadOrders(id); }
        catch (Exception ex) { UI.Error(ex); }
    }
}
