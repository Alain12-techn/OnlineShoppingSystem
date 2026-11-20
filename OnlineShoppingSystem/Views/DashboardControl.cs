using OnlineShoppingSystem.Controllers;
using OnlineShoppingSystem.Helpers;

namespace OnlineShoppingSystem.Views;

public partial class DashboardControl : UserControl
{
    public DashboardControl() { InitializeComponent(); }

    private void DashboardControl_Load(object sender, EventArgs e)
    {
        if (DesignMode) return;
        LoadData();
    }

    private void LoadData()
    {
        try
        {
            var s = new DashboardController().Stats();
            lblSalesValue.Text = UI.Money(s["total_sales"]);
            lblOrdersValue.Text = UI.Str(s["total_orders"]);
            lblCustomersValue.Text = UI.Str(s["customers"]);
            lblPendingValue.Text = UI.Str(s["pending"]);
            lblLowValue.Text = UI.Str(s["low_stock"]);
            gridLow.DataSource = new ProductController().LowStock();
            UI.ShowColumns(gridLow, ("name", "Product"), ("sku", "SKU"), ("stock_qty", "Stock"), ("low_stock_level", "Alert level"));
        }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnRefresh_Click(object sender, EventArgs e) => LoadData();
}
