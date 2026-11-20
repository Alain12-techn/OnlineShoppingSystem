using OnlineShoppingSystem.Helpers;

namespace OnlineShoppingSystem.Views;

public partial class MainForm : Form
{
    public bool LoggedOut { get; private set; }

    private UserControl _current;
    private readonly Color _navColor = Color.FromArgb(31, 42, 68);
    private readonly Color _navActive = Color.FromArgb(0, 120, 212);

    public MainForm() { InitializeComponent(); }

    private void MainForm_Load(object sender, EventArgs e)
    {
        var u = Session.CurrentUser;
        lblUser.Text = $"{u.Name}  |  {u.Role}   ";
        bool admin = Session.IsAdmin;
        foreach (var b in new[] { btnDashboard, btnProducts, btnLookups, btnAdminOrders, btnCustomers, btnCoupons, btnReviews, btnReports }) b.Visible = admin;
        foreach (var b in new[] { btnShop, btnCart, btnWishlist, btnMyOrders, btnNotifications, btnProfile }) b.Visible = !admin;
        if (admin) btnDashboard.PerformClick(); else btnShop.PerformClick();
    }

    /// <summary>Shows a module (UserControl) in the content area and highlights its menu button.</summary>
    private void Open(UserControl module, string title, Button nav)
    {
        pnlContent.SuspendLayout();
        if (_current != null) { pnlContent.Controls.Remove(_current); _current.Dispose(); }
        module.Dock = DockStyle.Fill;
        pnlContent.Controls.Add(module);
        _current = module;
        lblHeading.Text = title;
        foreach (Control c in pnlSide.Controls)
            if (c is Button b && b != btnLogout) b.BackColor = _navColor;
        nav.BackColor = _navActive;
        pnlContent.ResumeLayout();
    }

    // customer
    private void btnShop_Click(object sender, EventArgs e) => Open(new ShopControl(), "Shop", btnShop);
    private void btnCart_Click(object sender, EventArgs e) => Open(new CartControl(), "My Cart", btnCart);
    private void btnWishlist_Click(object sender, EventArgs e) => Open(new WishlistControl(), "My Wishlist", btnWishlist);
    private void btnMyOrders_Click(object sender, EventArgs e) => Open(new OrdersControl(), "My Orders", btnMyOrders);
    private void btnNotifications_Click(object sender, EventArgs e) => Open(new NotificationsControl(), "Notifications", btnNotifications);
    private void btnProfile_Click(object sender, EventArgs e) => Open(new ProfileControl(), "My Profile", btnProfile);

    // admin
    private void btnDashboard_Click(object sender, EventArgs e) => Open(new DashboardControl(), "Dashboard", btnDashboard);
    private void btnProducts_Click(object sender, EventArgs e) => Open(new ProductsControl(), "Products & Inventory", btnProducts);
    private void btnLookups_Click(object sender, EventArgs e) => Open(new LookupControl(), "Categories & Brands", btnLookups);
    private void btnAdminOrders_Click(object sender, EventArgs e) => Open(new OrdersAdminControl(), "Orders", btnAdminOrders);
    private void btnCustomers_Click(object sender, EventArgs e) => Open(new CustomersControl(), "Customers", btnCustomers);
    private void btnCoupons_Click(object sender, EventArgs e) => Open(new CouponsControl(), "Discounts & Coupons", btnCoupons);
    private void btnReviews_Click(object sender, EventArgs e) => Open(new ReviewsControl(), "Reviews", btnReviews);
    private void btnReports_Click(object sender, EventArgs e) => Open(new ReportsControl(), "Sales Reports", btnReports);

    private void btnLogout_Click(object sender, EventArgs e)
    {
        if (!UI.Confirm("Log out?")) return;
        LoggedOut = true;
        Session.CurrentUser = null;
        Close();
    }
}
