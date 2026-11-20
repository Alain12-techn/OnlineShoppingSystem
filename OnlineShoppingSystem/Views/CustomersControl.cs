using OnlineShoppingSystem.Controllers;
using OnlineShoppingSystem.Helpers;

namespace OnlineShoppingSystem.Views;

public partial class CustomersControl : UserControl
{
    private readonly UserController _users = new();
    private int _selectedId;
    private bool _selectedActive;

    public CustomersControl() { InitializeComponent(); }

    private void CustomersControl_Load(object sender, EventArgs e)
    {
        if (DesignMode) return;
        LoadData();
    }

    private void LoadData()
    {
        try
        {
            gridCustomers.DataSource = _users.GetCustomers(txtSearch.Text.Trim());
            UI.ShowColumns(gridCustomers, ("name", "Name"), ("email", "Email"), ("phone", "Phone"), ("status", "Status"), ("order_count", "Orders"), ("created_at", "Registered"));
            UI.Format(gridCustomers, "yyyy-MM-dd", "created_at");
        }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void txtSearch_TextChanged(object sender, EventArgs e) => LoadData();
    private void btnRefresh_Click(object sender, EventArgs e) => LoadData();

    private void gridCustomers_SelectionChanged(object sender, EventArgs e)
    {
        var r = UI.SelectedRow(gridCustomers);
        if (r == null) return;
        _selectedId = Convert.ToInt32(r["id"]);
        _selectedActive = UI.Str(r["status"]) == "Active";
        txtName.Text = UI.Str(r["name"]); txtEmail.Text = UI.Str(r["email"]); txtPhone.Text = UI.Str(r["phone"]);
        txtPassword.Clear(); txtEmail.ReadOnly = true;
        btnToggle.Text = _selectedActive ? "Deactivate account" : "Activate account";
    }

    private void ClearForm()
    {
        _selectedId = 0; txtName.Clear(); txtEmail.Clear(); txtPhone.Clear(); txtPassword.Clear();
        txtEmail.ReadOnly = false; btnToggle.Text = "Activate / Deactivate";
        gridCustomers.CurrentCell = null;
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        try { _users.AddCustomer(txtName.Text, txtEmail.Text, txtPhone.Text, txtPassword.Text); LoadData(); ClearForm(); UI.Info("Customer account created."); }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (_selectedId == 0) { UI.Warn("Select a customer first."); return; }
        try { _users.UpdateCustomer(_selectedId, txtName.Text, txtPhone.Text, txtPassword.Text); LoadData(); UI.Info("Customer updated."); }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnToggle_Click(object sender, EventArgs e)
    {
        if (_selectedId == 0) { UI.Warn("Select a customer first."); return; }
        try { _users.SetActive(_selectedId, !_selectedActive); LoadData(); }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (_selectedId == 0) { UI.Warn("Select a customer first."); return; }
        if (!UI.Confirm("Delete this customer account? (Customers with orders cannot be deleted - deactivate them instead.)")) return;
        try { _users.Delete(_selectedId); LoadData(); ClearForm(); }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnClear_Click(object sender, EventArgs e) => ClearForm();
}
