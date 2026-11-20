using OnlineShoppingSystem.Controllers;
using OnlineShoppingSystem.Helpers;

namespace OnlineShoppingSystem.Views;

public partial class AddressForm : Form
{
    public int SavedId { get; private set; }

    public AddressForm() { InitializeComponent(); }

    private void btnSave_Click(object sender, EventArgs e)
    {
        try
        {
            SavedId = new AddressController().Add(Session.UserId, txtStreet.Text, txtCity.Text, txtPhone.Text);
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex) { UI.Error(ex); }
    }
}
