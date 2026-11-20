using System.Data;
using OnlineShoppingSystem.Controllers;
using OnlineShoppingSystem.Helpers;

namespace OnlineShoppingSystem.Views;

public partial class ProfileControl : UserControl
{
    private readonly UserController _users = new();
    private readonly AddressController _addresses = new();
    private int _addrId;

    public ProfileControl() { InitializeComponent(); }

    private void ProfileControl_Load(object sender, EventArgs e)
    {
        if (DesignMode) return;
        try
        {
            var u = _users.GetById(Session.UserId);
            txtName.Text = u.Name; txtEmail.Text = u.Email; txtPhone.Text = u.Phone;
            LoadAddresses();
        }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnSaveProfile_Click(object sender, EventArgs e)
    {
        try
        {
            _users.UpdateProfile(Session.UserId, txtName.Text, txtPhone.Text, txtNewPassword.Text, txtConfirm.Text);
            Session.CurrentUser = _users.GetById(Session.UserId);
            txtNewPassword.Clear(); txtConfirm.Clear();
            UI.Info("Profile updated.");
        }
        catch (Exception ex) { UI.Error(ex); }
    }

    // ---------- addresses ----------
    private void LoadAddresses()
    {
        gridAddresses.DataSource = _addresses.GetTable(Session.UserId);
        UI.ShowColumns(gridAddresses, ("street", "Street"), ("city", "City"), ("phone", "Phone"));
        if (gridAddresses.Rows.Count == 0) ClearAddress();
    }

    private void ClearAddress()
    {
        _addrId = 0; txtStreet.Clear(); txtCity.Clear(); txtAddrPhone.Clear();
        gridAddresses.CurrentCell = null;
    }

    private void gridAddresses_SelectionChanged(object sender, EventArgs e)
    {
        var r = UI.SelectedRow(gridAddresses);
        if (r == null) return;
        _addrId = Convert.ToInt32(r["id"]);
        txtStreet.Text = UI.Str(r["street"]); txtCity.Text = UI.Str(r["city"]); txtAddrPhone.Text = UI.Str(r["phone"]);
    }

    private void btnAddrAdd_Click(object sender, EventArgs e)
    {
        try { _addresses.Add(Session.UserId, txtStreet.Text, txtCity.Text, txtAddrPhone.Text); LoadAddresses(); ClearAddress(); }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnAddrUpdate_Click(object sender, EventArgs e)
    {
        if (_addrId == 0) { UI.Warn("Select an address in the list first."); return; }
        try { _addresses.Update(_addrId, Session.UserId, txtStreet.Text, txtCity.Text, txtAddrPhone.Text); LoadAddresses(); }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnAddrDelete_Click(object sender, EventArgs e)
    {
        if (_addrId == 0) { UI.Warn("Select an address in the list first."); return; }
        if (!UI.Confirm("Delete this address?")) return;
        try { _addresses.Delete(_addrId, Session.UserId); LoadAddresses(); ClearAddress(); }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnAddrClear_Click(object sender, EventArgs e) => ClearAddress();
}
