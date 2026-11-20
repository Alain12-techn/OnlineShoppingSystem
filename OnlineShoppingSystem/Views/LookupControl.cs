using OnlineShoppingSystem.Controllers;
using OnlineShoppingSystem.Helpers;

namespace OnlineShoppingSystem.Views;

public partial class LookupControl : UserControl
{
    private readonly LookupController _lookup = new();
    private int _catId, _brandId;

    public LookupControl() { InitializeComponent(); }

    private void LookupControl_Load(object sender, EventArgs e)
    {
        if (DesignMode) return;
        LoadCategories();
        LoadBrands();
    }

    // ---------------- categories ----------------
    private void LoadCategories()
    {
        try
        {
            UI.Fill(cboCatParent, _lookup.CategoryItems("(None - top level)"));
            gridCategories.DataSource = _lookup.GetCategories();
            UI.ShowColumns(gridCategories, ("name", "Category"), ("parent", "Parent category"));
        }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void ClearCategory()
    {
        _catId = 0; txtCatName.Clear(); cboCatParent.SelectedIndex = 0; gridCategories.CurrentCell = null;
    }

    private void gridCategories_SelectionChanged(object sender, EventArgs e)
    {
        var r = UI.SelectedRow(gridCategories);
        if (r == null) return;
        _catId = Convert.ToInt32(r["id"]);
        txtCatName.Text = UI.Str(r["name"]);
        UI.SelectId(cboCatParent, UI.IntOrZero(r["parent_id"]));
    }

    private void btnCatAdd_Click(object sender, EventArgs e)
    {
        try { _lookup.AddCategory(txtCatName.Text, UI.NullIfZero(UI.SelectedId(cboCatParent))); LoadCategories(); ClearCategory(); }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnCatUpdate_Click(object sender, EventArgs e)
    {
        if (_catId == 0) { UI.Warn("Select a category first."); return; }
        try { _lookup.UpdateCategory(_catId, txtCatName.Text, UI.NullIfZero(UI.SelectedId(cboCatParent))); LoadCategories(); }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnCatDelete_Click(object sender, EventArgs e)
    {
        if (_catId == 0) { UI.Warn("Select a category first."); return; }
        if (!UI.Confirm("Delete this category? Its products become uncategorised.")) return;
        try { _lookup.DeleteCategory(_catId); LoadCategories(); ClearCategory(); }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnCatClear_Click(object sender, EventArgs e) => ClearCategory();

    // ---------------- brands ----------------
    private void LoadBrands()
    {
        try
        {
            gridBrands.DataSource = _lookup.GetBrands();
            UI.ShowColumns(gridBrands, ("name", "Brand"));
        }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void ClearBrand()
    {
        _brandId = 0; txtBrandName.Clear(); gridBrands.CurrentCell = null;
    }

    private void gridBrands_SelectionChanged(object sender, EventArgs e)
    {
        var r = UI.SelectedRow(gridBrands);
        if (r == null) return;
        _brandId = Convert.ToInt32(r["id"]);
        txtBrandName.Text = UI.Str(r["name"]);
    }

    private void btnBrandAdd_Click(object sender, EventArgs e)
    {
        try { _lookup.AddBrand(txtBrandName.Text); LoadBrands(); ClearBrand(); }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnBrandUpdate_Click(object sender, EventArgs e)
    {
        if (_brandId == 0) { UI.Warn("Select a brand first."); return; }
        try { _lookup.UpdateBrand(_brandId, txtBrandName.Text); LoadBrands(); }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnBrandDelete_Click(object sender, EventArgs e)
    {
        if (_brandId == 0) { UI.Warn("Select a brand first."); return; }
        if (!UI.Confirm("Delete this brand?")) return;
        try { _lookup.DeleteBrand(_brandId); LoadBrands(); ClearBrand(); }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnBrandClear_Click(object sender, EventArgs e) => ClearBrand();
}
