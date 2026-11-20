using OnlineShoppingSystem.Controllers;
using OnlineShoppingSystem.Helpers;

namespace OnlineShoppingSystem.Views;

public partial class ReviewsControl : UserControl
{
    private readonly ReviewController _reviews = new();
    private bool _ready;

    public ReviewsControl() { InitializeComponent(); }

    private void ReviewsControl_Load(object sender, EventArgs e)
    {
        if (DesignMode) return;
        cboFilter.Items.AddRange(new object[] { "All", "Pending", "Approved" });
        cboFilter.SelectedIndex = 1;
        _ready = true;
        LoadData();
    }

    private void LoadData()
    {
        if (!_ready) return;
        try
        {
            gridReviews.DataSource = _reviews.GetAll(cboFilter.SelectedItem?.ToString() ?? "All");
            UI.ShowColumns(gridReviews, ("product", "Product"), ("reviewer", "Customer"), ("rating", "Rating"), ("comment", "Comment"), ("is_approved", "Approved"), ("created_at", "Date"));
            UI.Format(gridReviews, "yyyy-MM-dd", "created_at");
        }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void cboFilter_SelectedIndexChanged(object sender, EventArgs e) => LoadData();
    private void btnRefresh_Click(object sender, EventArgs e) => LoadData();

    private void gridReviews_SelectionChanged(object sender, EventArgs e)
    {
        var r = UI.SelectedRow(gridReviews);
        txtFull.Text = r == null ? "" : UI.Str(r["comment"]);
    }

    private void SetApproved(bool approved)
    {
        var r = UI.SelectedRow(gridReviews);
        if (r == null) { UI.Warn("Select a review first."); return; }
        try { _reviews.SetApproved(Convert.ToInt32(r["id"]), approved); LoadData(); }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnApprove_Click(object sender, EventArgs e) => SetApproved(true);
    private void btnUnapprove_Click(object sender, EventArgs e) => SetApproved(false);

    private void btnDelete_Click(object sender, EventArgs e)
    {
        var r = UI.SelectedRow(gridReviews);
        if (r == null) { UI.Warn("Select a review first."); return; }
        if (!UI.Confirm("Delete this review?")) return;
        try { _reviews.Delete(Convert.ToInt32(r["id"])); LoadData(); }
        catch (Exception ex) { UI.Error(ex); }
    }
}
