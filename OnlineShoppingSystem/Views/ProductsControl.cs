using System.Data;
using OnlineShoppingSystem.Controllers;
using OnlineShoppingSystem.Helpers;
using OnlineShoppingSystem.Models;

namespace OnlineShoppingSystem.Views;

public partial class ProductsControl : UserControl
{
    private readonly ProductController _products = new();
    private readonly LookupController _lookup = new();
    private int _selectedId;
    private string _imageFile = "";

    public ProductsControl() { InitializeComponent(); }

    private void ProductsControl_Load(object sender, EventArgs e)
    {
        if (DesignMode) return;
        try
        {
            UI.Fill(cboCategory, _lookup.CategoryItems("(None)"));
            UI.Fill(cboBrand, _lookup.BrandItems("(None)"));
            LoadData();
        }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void LoadData()
    {
        try
        {
            var dt = _products.Search(txtSearch.Text.Trim(), 0, 0, 0m, null, 0, "Name");
            var view = dt.DefaultView;
            if (chkLowStock.Checked) view.RowFilter = "stock_qty <= low_stock_level";
            gridProducts.DataSource = view;
            UI.ShowColumns(gridProducts, ("sku", "SKU"), ("name", "Product"), ("category", "Category"), ("brand", "Brand"), ("price", "Price"),
                ("stock_qty", "Stock"), ("low_stock_level", "Alert level"), ("status", "Status"));
            UI.Format(gridProducts, "N2", "price");
        }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void txtSearch_TextChanged(object sender, EventArgs e) => LoadData();
    private void chkLowStock_CheckedChanged(object sender, EventArgs e) => LoadData();
    private void btnRefresh_Click(object sender, EventArgs e) => LoadData();

    /// <summary>FR-28: rows at/below their alert level are highlighted.</summary>
    private void gridProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
    {
        if (e.RowIndex < 0 || e.RowIndex >= gridProducts.Rows.Count) return;
        if (gridProducts.Rows[e.RowIndex].DataBoundItem is DataRowView v &&
            Convert.ToInt32(v["stock_qty"]) <= Convert.ToInt32(v["low_stock_level"]))
        {
            e.CellStyle.BackColor = Color.MistyRose;
            e.CellStyle.ForeColor = Color.DarkRed;
        }
    }

    private void gridProducts_SelectionChanged(object sender, EventArgs e)
    {
        var r = UI.SelectedRow(gridProducts);
        if (r == null) return;
        _selectedId = Convert.ToInt32(r["id"]);
        txtName.Text = UI.Str(r["name"]);
        txtSku.Text = UI.Str(r["sku"]);
        txtDescription.Text = UI.Str(r["description"]);
        nudPrice.Value = Math.Min(nudPrice.Maximum, Convert.ToDecimal(r["price"]));
        nudStock.Value = Math.Min(nudStock.Maximum, Convert.ToDecimal(r["stock_qty"]));
        nudLowLevel.Value = Math.Min(nudLowLevel.Maximum, Convert.ToDecimal(r["low_stock_level"]));
        UI.SelectId(cboCategory, UI.IntOrZero(r["category_id"]));
        UI.SelectId(cboBrand, UI.IntOrZero(r["brand_id"]));
        _imageFile = UI.Str(r["image_url"]);
        txtImage.Text = _imageFile;
        UI.LoadImage(picPreview, _imageFile);
    }

    private Product ReadForm() => new Product
    {
        Id = _selectedId,
        Name = txtName.Text,
        Sku = txtSku.Text,
        Description = txtDescription.Text.Trim(),
        Price = nudPrice.Value,
        StockQty = (int)nudStock.Value,
        LowStockLevel = (int)nudLowLevel.Value,
        CategoryId = UI.NullIfZero(UI.SelectedId(cboCategory)),
        BrandId = UI.NullIfZero(UI.SelectedId(cboBrand)),
        ImageUrl = _imageFile
    };

    private void ClearForm()
    {
        _selectedId = 0; _imageFile = "";
        txtName.Clear(); txtSku.Clear(); txtDescription.Clear(); txtImage.Clear();
        nudPrice.Value = 0; nudStock.Value = 0; nudLowLevel.Value = 5;
        if (cboCategory.Items.Count > 0) cboCategory.SelectedIndex = 0;
        if (cboBrand.Items.Count > 0) cboBrand.SelectedIndex = 0;
        UI.LoadImage(picPreview, null);
        gridProducts.CurrentCell = null;
    }

    private void btnBrowse_Click(object sender, EventArgs e)
    {
        using var dlg = new OpenFileDialog { Filter = "Images|*.jpg;*.jpeg;*.png;*.gif;*.bmp" };
        if (dlg.ShowDialog(this) != DialogResult.OK) return;
        try
        {
            Directory.CreateDirectory(UI.ImagesDir);
            string name = Path.GetFileName(dlg.FileName);
            File.Copy(dlg.FileName, Path.Combine(UI.ImagesDir, name), true);
            _imageFile = name; txtImage.Text = name;
            UI.LoadImage(picPreview, name);
        }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
        try { _products.Add(ReadForm()); LoadData(); ClearForm(); UI.Info("Product added."); }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnUpdate_Click(object sender, EventArgs e)
    {
        if (_selectedId == 0) { UI.Warn("Select a product in the list first."); return; }
        try { _products.Update(ReadForm()); LoadData(); UI.Info("Product updated."); }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
        if (_selectedId == 0) { UI.Warn("Select a product in the list first."); return; }
        if (!UI.Confirm("Delete this product? Past orders keep their product name.")) return;
        try { _products.Delete(_selectedId); LoadData(); ClearForm(); }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnClear_Click(object sender, EventArgs e) => ClearForm();
}
