using System.Data;
using OnlineShoppingSystem.Controllers;
using OnlineShoppingSystem.Helpers;
using OnlineShoppingSystem.Models;

namespace OnlineShoppingSystem.Views;

public partial class CartControl : UserControl
{
    private readonly CartController _cart = new();
    private Coupon _coupon;
    private DataTable _items;

    public CartControl() { InitializeComponent(); }

    private void CartControl_Load(object sender, EventArgs e)
    {
        if (DesignMode) return;
        LoadCart();
    }

    private void LoadCart()
    {
        try
        {
            _items = _cart.GetItems(Session.UserId);
            gridCart.DataSource = _items;
            UI.ShowColumns(gridCart, ("name", "Product"), ("price", "Unit price"), ("quantity", "Qty"), ("stock_qty", "In stock"), ("line_total", "Line total"));
            UI.Format(gridCart, "N2", "price", "line_total");
            UpdateTotals();
        }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void UpdateTotals()
    {
        var t = Pricing.Compute(Pricing.Subtotal(_items), _coupon?.DiscountPercent ?? 0);
        lblSubtotal.Text = "Subtotal: " + t.Subtotal.ToString("N2");
        lblDiscount.Text = "Discount: -" + t.Discount.ToString("N2");
        lblTax.Text = $"Tax ({AppSettings.TaxRate:P0}): " + t.Tax.ToString("N2");
        lblTotal.Text = "Total: " + t.Total.ToString("N2");
        btnCheckout.Enabled = _items.Rows.Count > 0;
    }

    private void gridCart_SelectionChanged(object sender, EventArgs e)
    {
        var r = UI.SelectedRow(gridCart);
        if (r != null) nudQty.Value = Math.Max(nudQty.Minimum, Math.Min(nudQty.Maximum, Convert.ToDecimal(r["quantity"])));
    }

    private void btnUpdateQty_Click(object sender, EventArgs e)
    {
        var r = UI.SelectedRow(gridCart);
        if (r == null) { UI.Warn("Select an item first."); return; }
        try { _cart.UpdateQuantity(Convert.ToInt32(r["id"]), Session.UserId, (int)nudQty.Value); LoadCart(); }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
        var r = UI.SelectedRow(gridCart);
        if (r == null) { UI.Warn("Select an item first."); return; }
        try { _cart.Remove(Convert.ToInt32(r["id"]), Session.UserId); LoadCart(); }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
        if (_items == null || _items.Rows.Count == 0 || !UI.Confirm("Remove all items from your cart?")) return;
        try { _cart.Clear(Session.UserId); LoadCart(); }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnApply_Click(object sender, EventArgs e)
    {
        try
        {
            _coupon = new CouponController().GetValid(txtCoupon.Text);
            lblCouponMsg.ForeColor = Color.ForestGreen;
            lblCouponMsg.Text = $"Coupon {_coupon.Code} applied: {_coupon.DiscountPercent:0.##}% off";
            UpdateTotals();
        }
        catch (Exception ex)
        {
            _coupon = null; lblCouponMsg.Text = ""; UpdateTotals(); UI.Error(ex);
        }
    }

    private void btnCheckout_Click(object sender, EventArgs e)
    {
        using var f = new CheckoutForm(_coupon);
        if (f.ShowDialog(FindForm()) == DialogResult.OK)
        {
            _coupon = null; txtCoupon.Clear(); lblCouponMsg.Text = "";
            LoadCart();
        }
    }
}
