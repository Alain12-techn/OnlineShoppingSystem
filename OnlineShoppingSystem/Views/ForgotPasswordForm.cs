using OnlineShoppingSystem.Controllers;
using OnlineShoppingSystem.Helpers;

namespace OnlineShoppingSystem.Views;

public partial class ForgotPasswordForm : Form
{
    private readonly AuthController _auth = new();

    public ForgotPasswordForm() { InitializeComponent(); }

    private void btnSendCode_Click(object sender, EventArgs e)
    {
        try
        {
            string code = _auth.StartReset(txtEmail.Text.Trim());
            grpReset.Enabled = true;
            string msg = "A 6-digit reset code was sent to " + txtEmail.Text.Trim() + ".";
            if (!AppSettings.SmtpEnabled)
                msg += "\n\n(Demo mode: SMTP is switched off in appsettings.json, so the code is shown here: " + code + ")";
            UI.Info(msg);
            txtCode.Focus();
        }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnReset_Click(object sender, EventArgs e)
    {
        try
        {
            _auth.CompleteReset(txtEmail.Text.Trim(), txtCode.Text.Trim(), txtNewPassword.Text, txtConfirm.Text);
            UI.Info("Password changed. You can now log in with your new password.");
            DialogResult = DialogResult.OK;
        }
        catch (Exception ex) { UI.Error(ex); }
    }
}
