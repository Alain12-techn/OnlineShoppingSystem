using OnlineShoppingSystem.Controllers;
using OnlineShoppingSystem.Helpers;
using OnlineShoppingSystem.Models;

namespace OnlineShoppingSystem.Views;

public partial class CheckoutForm : Form
{
    private readonly Coupon _coupon;
    private readonly AddressController _addresses = new();
    private readonly CartController _cart = new();
    private readonly OrderController _orders = new();
    private decimal _subtotal;

    public CheckoutForm(Coupon coupon)
    {
        InitializeComponent();
        _coupon = coupon;
    }

    private void CheckoutForm_Load(object sender, EventArgs e)
    {
        try
        {
            LoadAddresses(0);
            foreach (var s in Pricing.Shipping) cboShipping.Items.Add($"{s.Name} - {s.Fee:N2}");
            cboPayment.Items.AddRange(new object[] { "Card", "Cash on Delivery" });
            _subtotal = Pricing.Subtotal(_cart.GetItems(Session.UserId));
            cboShipping.SelectedIndex = 0;
            cboPayment.SelectedIndex = 0;
            RefreshTotals();
        }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void LoadAddresses(int selectId)
    {
        cboAddress.Items.Clear();
        foreach (var a in _addresses.GetByUser(Session.UserId)) cboAddress.Items.Add(new ComboItem(a.Id, a.ToString()));
        if (cboAddress.Items.Count > 0) cboAddress.SelectedIndex = 0;
        if (selectId > 0) UI.SelectId(cboAddress, selectId);
    }

    private void RefreshTotals()
    {
        if (cboShipping.SelectedIndex < 0) return;
        var t = Pricing.Compute(_subtotal, _coupon?.DiscountPercent ?? 0, Pricing.Shipping[cboShipping.SelectedIndex].Fee);
        lblSumSubtotal.Text = "Subtotal: " + t.Subtotal.ToString("N2");
        lblSumDiscount.Text = "Discount" + (_coupon != null ? " (" + _coupon.Code + ")" : "") + ": -" + t.Discount.ToString("N2");
        lblSumTax.Text = $"Tax ({AppSettings.TaxRate:P0}): " + t.Tax.ToString("N2");
        lblSumShipping.Text = "Shipping: " + t.Shipping.ToString("N2");
        lblSumTotal.Text = "Total: " + t.Total.ToString("N2");
    }

    private void cboShipping_SelectedIndexChanged(object sender, EventArgs e) => RefreshTotals();

    private void cboPayment_SelectedIndexChanged(object sender, EventArgs e) => grpCard.Visible = cboPayment.SelectedIndex == 0;

    private void btnNewAddress_Click(object sender, EventArgs e)
    {
        using var f = new AddressForm();
        if (f.ShowDialog(this) == DialogResult.OK) LoadAddresses(f.SavedId);
    }

    private void btnPlaceOrder_Click(object sender, EventArgs e)
    {
        try
        {
            if (cboAddress.SelectedItem is not ComboItem addr) throw new AppException("Please select or add a delivery address.");
            string method = (string)cboPayment.SelectedItem;
            if (method == "Card") Validator.Card(txtCardName.Text, txtCardNumber.Text, txtExpiry.Text, txtCvv.Text);
            var ship = Pricing.Shipping[cboShipping.SelectedIndex];
            int orderId = _orders.PlaceOrder(Session.UserId, addr.Id, ship.Name, ship.Fee, method, _coupon?.Code);
            UI.Info($"Order #{orderId} placed successfully! A confirmation email was sent (see Notifications).");
            if (UI.Confirm("Do you want to open the invoice now?"))
            {
                using var inv = new InvoiceForm(orderId);
                inv.ShowDialog(this);
            }
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex) { UI.Error(ex); }
    }
}
