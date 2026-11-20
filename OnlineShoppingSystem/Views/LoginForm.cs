using OnlineShoppingSystem.Controllers;
using OnlineShoppingSystem.Helpers;

namespace OnlineShoppingSystem.Views;

public partial class LoginForm : Form
{
    private readonly AuthController _auth = new();

    public LoginForm() { InitializeComponent(); }

    private void btnLogin_Click(object sender, EventArgs e)
    {
        try
        {
            Session.CurrentUser = _auth.Login(txtEmail.Text.Trim(), txtPassword.Text);
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void chkShow_CheckedChanged(object sender, EventArgs e) => txtPassword.UseSystemPasswordChar = !chkShow.Checked;

    private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        using var f = new RegisterForm();
        f.ShowDialog(this);
        if (!string.IsNullOrEmpty(f.RegisteredEmail))
        {
            txtEmail.Text = f.RegisteredEmail; txtPassword.Clear(); txtPassword.Focus();
        }
    }

    private void lnkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        using var f = new ForgotPasswordForm();
        f.ShowDialog(this);
    }
}
