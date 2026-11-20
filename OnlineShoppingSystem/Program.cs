using OnlineShoppingSystem.Data;
using OnlineShoppingSystem.Helpers;
using OnlineShoppingSystem.Views;

namespace OnlineShoppingSystem;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        try { DbInitializer.Initialize(); }
        catch (Exception ex)
        {
            MessageBox.Show("Could not connect to the MySQL database.\n\n" + ex.Message +
                "\n\nCheck that MySQL is running, that you ran Database/oss_db.sql and that the password in appsettings.json is correct.",
                "Online Shopping System", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        while (true)
        {
            using var login = new LoginForm();
            if (login.ShowDialog() != DialogResult.OK) break;
            using var main = new MainForm();
            Application.Run(main);
            if (!main.LoggedOut) break;
        }
    }
}
