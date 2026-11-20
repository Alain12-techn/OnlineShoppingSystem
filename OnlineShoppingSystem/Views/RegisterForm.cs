using OnlineShoppingSystem.Controllers;
using OnlineShoppingSystem.Helpers;

namespace OnlineShoppingSystem.Views;

public partial class RegisterForm : Form
{
    public string RegisteredEmail { get; private set; }

    public RegisterForm() { InitializeComponent(); }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        try
        {
            new AuthController().Register(txtName.Text, txtEmail.Text, txtPhone.Text, txtPassword.Text, txtConfirm.Text);
            RegisteredEmail = txtEmail.Text.Trim();
            UI.Info("Account created! You can now log in.");
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex) { UI.Error(ex); }
    }
}
