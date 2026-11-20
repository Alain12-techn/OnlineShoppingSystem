using System.Data;
using OnlineShoppingSystem.Controllers;
using OnlineShoppingSystem.Helpers;

namespace OnlineShoppingSystem.Views;

public partial class ShopControl : UserControl
{
    private readonly ProductController _products = new();
    private readonly LookupController _lookup = new();
    private readonly CartController _cart = new();

    public ShopControl() { InitializeComponent(); }

    private void ShopControl_Load(object sender, EventArgs e)
    {
        if (DesignMode) return;
        try
        {
            UI.Fill(cboCategory, _lookup.CategoryItems("All categories"));
            UI.Fill(cboBrand, _lookup.BrandItems("All brands"));
            cboRating.Items.AddRange(new object[] { "Any rating", "1+ stars", "2+ stars", "3+ stars", "4+ stars" });
            cboRating.SelectedIndex = 0;
            cboSort.Items.AddRange(new object[] { "Newest", "Price: Low to High", "Price: High to Low", "Popularity", "Name" });
            cboSort.SelectedIndex = 0;
            LoadProducts();
        }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void LoadProducts()
    {
        try
        {
            decimal? max = nudMax.Value > 0 ? nudMax.Value : (decimal?)null;
            var dt = _products.Search(txtSearch.Text.Trim(), UI.SelectedId(cboCategory), UI.SelectedId(cboBrand), nudMin.Value, max,
                cboRating.SelectedIndex < 0 ? 0 : cboRating.SelectedIndex, cboSort.SelectedItem?.ToString() ?? "Newest");
            gridProducts.DataSource = dt;
            UI.ShowColumns(gridProducts, ("name", "Product"), ("category", "Category"), ("brand", "Brand"), ("price", "Price"), ("avg_rating", "Rating"), ("status", "Availability"));
            UI.Format(gridProducts, "N2", "price");
            ShowDetails();
        }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void ShowDetails()
    {
        var r = UI.SelectedRow(gridProducts);
        if (r == null)
        {
            lblName.Text = ""; lblInfo.Text = ""; txtDescription.Clear(); txtReviews.Clear(); UI.LoadImage(picDetails, null);
            return;
        }
        lblName.Text = UI.Str(r["name"]);
        lblInfo.Text = $"Price: {UI.Money(r["price"])}\r\nAvailability: {r["status"]} ({r["stock_qty"]} in stock)\r\nRating: {r["avg_rating"]} / 5";
        txtDescription.Text = UI.Str(r["description"]);
        UI.LoadImage(picDetails, UI.Str(r["image_url"]));
        var rv = _products.GetApprovedReviews(Convert.ToInt32(r["id"]));
        txtReviews.Text = rv.Rows.Count == 0
            ? "No reviews yet."
            : string.Join("\r\n\r\n", rv.Rows.Cast<DataRow>().Select(x => $"{x["reviewer"]} - {x["rating"]}/5\r\n{UI.Str(x["comment"])}"));
    }

    private void txtSearch_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter) { e.SuppressKeyPress = true; LoadProducts(); }
    }

    private void btnSearch_Click(object sender, EventArgs e) => LoadProducts();

    private void btnReset_Click(object sender, EventArgs e)
    {
        txtSearch.Clear(); nudMin.Value = 0; nudMax.Value = 0;
        cboCategory.SelectedIndex = 0; cboBrand.SelectedIndex = 0; cboRating.SelectedIndex = 0; cboSort.SelectedIndex = 0;
        LoadProducts();
    }

    private void gridProducts_SelectionChanged(object sender, EventArgs e)
    {
        try { ShowDetails(); } catch (Exception ex) { UI.Error(ex); }
    }

    private void btnAddToCart_Click(object sender, EventArgs e)
    {
        var r = UI.SelectedRow(gridProducts);
        if (r == null) { UI.Warn("Select a product first."); return; }
        try
        {
            _cart.Add(Session.UserId, Convert.ToInt32(r["id"]), (int)nudQty.Value);
            UI.Info("Added to your cart.");
        }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnWishlist_Click(object sender, EventArgs e)
    {
        var r = UI.SelectedRow(gridProducts);
        if (r == null) { UI.Warn("Select a product first."); return; }
        try
        {
            _products.AddToWishlist(Session.UserId, Convert.ToInt32(r["id"]));
            UI.Info("Saved to your wishlist.");
        }
        catch (Exception ex) { UI.Error(ex); }
    }
}
