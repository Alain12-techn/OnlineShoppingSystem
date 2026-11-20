using OnlineShoppingSystem.Controllers;
using OnlineShoppingSystem.Helpers;

namespace OnlineShoppingSystem.Views;

public partial class CouponsControl : UserControl
{
    private readonly CouponController _coupons = new();
    private int _selectedId;

    public CouponsControl() { InitializeComponent(); }

    private void CouponsControl_Load(object sender, EventArgs e)
    {
        if (DesignMode) return;
        dtpExpiry.Value = DateTime.Today.AddMonths(3);
        LoadData();
    }

    private void LoadData()
    {
        try
        {
            gridCoupons.DataSource = _coupons.GetAll();
            UI.ShowColumns(gridCoupons, ("code", "Code"), ("discount_percent", "Discount %"), ("expiry_date", "Expires"), ("is_active", "Active"));
            UI.Format(gridCoupons, "yyyy-MM-dd", "expiry_date");
        }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void gridCoupons_SelectionChanged(object sender, EventArgs e)
    {
        var r = UI.SelectedRow(gridCoupons);
        if (r == null) return;
        _selectedId = Convert.ToInt32(r["id"]);
        txtCode.Text = UI.Str(r["code"]);
        nudDiscount.Value = Math.Max(nudDiscount.Minimum, Math.Min(nudDiscount.Maximum, Convert.ToDecimal(r["discount_percent"])));
        dtpExpiry.Value = Convert.ToDateTime(r["expiry_date"]);
        chkActive.Checked = Convert.ToBoolean(r["is_active"]);
    }

    private void ClearForm()
    {
        _selectedId = 0; txtCode.Clear(); nudDiscount.Value = 10; dtpExpiry.Value = DateTime.Today.AddMonths(3); chkActive.Checked = true;
        gridCoupons.CurrentCell = null;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        try { _coupons.Add(txtCode.Text, nudDiscount.Value, dtpExpiry.Value, chkActive.Checked); LoadData(); ClearForm(); }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (_selectedId == 0) { UI.Warn("Select a coupon first."); return; }
        try { _coupons.Update(_selectedId, txtCode.Text, nudDiscount.Value, dtpExpiry.Value, chkActive.Checked); LoadData(); }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (_selectedId == 0) { UI.Warn("Select a coupon first."); return; }
        if (!UI.Confirm("Delete this coupon?")) return;
        try { _coupons.Delete(_selectedId); LoadData(); ClearForm(); }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnClear_Click(object sender, EventArgs e) => ClearForm();
}
