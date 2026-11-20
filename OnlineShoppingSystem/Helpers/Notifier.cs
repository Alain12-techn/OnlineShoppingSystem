using System.Net;
using System.Net.Mail;
using OnlineShoppingSystem.Data;

namespace OnlineShoppingSystem.Helpers;

/// <summary>Stores every email in the notifications table and sends it by SMTP when enabled in appsettings.json.</summary>
public static class Notifier
{
    public static void Send(int userId, string email, string subject, string body)
    {
        try
        {
            Db.Execute("INSERT INTO notifications(user_id,email,subject,message) VALUES(@u,@e,@s,@m)",
                "@u", userId, "@e", email, "@s", subject, "@m", body);
        }
        catch { /* a notification problem must never block the main action */ }

        if (!AppSettings.SmtpEnabled) return;
        try
        {
            using var client = new SmtpClient(AppSettings.Smtp("Host"), AppSettings.SmtpPort)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(AppSettings.Smtp("User"), AppSettings.Smtp("Password"))
            };
            client.Send(new MailMessage(AppSettings.Smtp("From"), email, subject, body));
        }
        catch { }
    }
}
