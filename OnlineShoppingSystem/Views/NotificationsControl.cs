using OnlineShoppingSystem.Controllers;
using OnlineShoppingSystem.Helpers;

namespace OnlineShoppingSystem.Views;

public partial class NotificationsControl : UserControl
{
    public NotificationsControl() { InitializeComponent(); }

    private void NotificationsControl_Load(object sender, EventArgs e)
    {
        if (DesignMode) return;
        try
        {
            gridNotes.DataSource = new UserController().GetNotifications(Session.UserId);
            UI.ShowColumns(gridNotes, ("created_at", "Date"), ("subject", "Subject"));
            UI.Format(gridNotes, "yyyy-MM-dd HH:mm", "created_at");
        }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void gridNotes_SelectionChanged(object sender, EventArgs e)
    {
        var r = UI.SelectedRow(gridNotes);
        txtMessage.Text = r == null ? "" : UI.Str(r["message"]);
    }
}
