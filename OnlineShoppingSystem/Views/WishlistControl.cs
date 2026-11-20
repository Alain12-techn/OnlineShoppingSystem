using OnlineShoppingSystem.Controllers;
using OnlineShoppingSystem.Helpers;

namespace OnlineShoppingSystem.Views;

public partial class WishlistControl : UserControl
{
    private readonly ProductController _products = new();
    private readonly CartController _cart = new();

    public WishlistControl() { InitializeComponent(); }

    private void WishlistControl_Load(object sender, EventArgs e)
    {
        if (DesignMode) return;
        LoadData();
    }

    private void LoadData()
    {
        try
        {
            gridWishlist.DataSource = _products.GetWishlist(Session.UserId);
            UI.ShowColumns(gridWishlist, ("name", "Product"), ("brand", "Brand"), ("price", "Price"), ("stock_qty", "In stock"));
            UI.Format(gridWishlist, "N2", "price");
        }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnRefresh_Click(object sender, EventArgs e) => LoadData();

    private void btnMoveToCart_Click(object sender, EventArgs e)
    {
        var r = UI.SelectedRow(gridWishlist);
        if (r == null) { UI.Warn("Select a product first."); return; }
        try
        {
            _cart.Add(Session.UserId, Convert.ToInt32(r["product_id"]), 1);
            _products.RemoveFromWishlist(Convert.ToInt32(r["wishlist_id"]), Session.UserId);
            UI.Info("Moved to your cart.");
            LoadData();
        }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
        var r = UI.SelectedRow(gridWishlist);
        if (r == null) { UI.Warn("Select a product first."); return; }
        try { _products.RemoveFromWishlist(Convert.ToInt32(r["wishlist_id"]), Session.UserId); LoadData(); }
        catch (Exception ex) { UI.Error(ex); }
    }
}
