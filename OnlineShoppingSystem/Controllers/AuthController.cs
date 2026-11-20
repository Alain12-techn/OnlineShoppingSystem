using System.Data;
using System.Security.Cryptography;
using OnlineShoppingSystem.Data;
using OnlineShoppingSystem.Helpers;
using OnlineShoppingSystem.Models;

namespace OnlineShoppingSystem.Controllers;

public class AuthController
{
    /// <summary>FR-2: log in. Throws AppException with a friendly message on failure.</summary>
    public User Login(string email, string password)
    {
        var dt = Db.Query("SELECT id,name,email,phone,role,is_active,password_hash FROM users WHERE email=@e", "@e", email);
        if (dt.Rows.Count == 0 || !PasswordHasher.Verify(password ?? "", (string)dt.Rows[0]["password_hash"]))
            throw new AppException("Invalid email or password.");
        var r = dt.Rows[0];
        if (!Convert.ToBoolean(r["is_active"]))
            throw new AppException("This account has been deactivated. Please contact the administrator.");
        return UserController.FromRow(r);
    }

    /// <summary>FR-1: register a customer.</summary>
    public void Register(string name, string email, string phone, string password, string confirm)
    {
        Validator.Required(name, "Name");
        Validator.Email(email);
        Validator.Phone(phone);
        Validator.Password(password, confirm);
        email = email.Trim();
        if (Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM users WHERE email=@e", "@e", email)) > 0)
            throw new AppException("This email is already registered.");
        long id = Db.Insert("INSERT INTO users(name,email,phone,password_hash,role) VALUES(@n,@e,@p,@h,'Customer')",
            "@n", name.Trim(), "@e", email, "@p", phone.Trim(), "@h", PasswordHasher.Hash(password));
        Notifier.Send((int)id, email, "Welcome to Online Shopping System", $"Hi {name.Trim()}, your account has been created successfully.");
    }

    /// <summary>FR-4 step 1: create a 6-digit reset code valid for 15 minutes. Returns the code (shown only when SMTP is off).</summary>
    public string StartReset(string email)
    {
        Validator.Email(email);
        var dt = Db.Query("SELECT id FROM users WHERE email=@e AND is_active=1", "@e", email);
        if (dt.Rows.Count == 0) throw new AppException("No active account was found with that email.");
        string code = RandomNumberGenerator.GetInt32(100000, 1000000).ToString();
        Db.Execute("UPDATE users SET reset_code=@c, reset_expiry=DATE_ADD(NOW(), INTERVAL 15 MINUTE) WHERE email=@e", "@c", code, "@e", email);
        Notifier.Send(Convert.ToInt32(dt.Rows[0]["id"]), email, "Password reset code", $"Your password reset code is {code}. It expires in 15 minutes.");
        return code;
    }

    /// <summary>FR-4 step 2: verify the code and set a new password.</summary>
    public void CompleteReset(string email, string code, string newPassword, string confirm)
    {
        Validator.Password(newPassword, confirm);
        int n = Db.Execute("UPDATE users SET password_hash=@h, reset_code=NULL, reset_expiry=NULL WHERE email=@e AND reset_code=@c AND reset_expiry>NOW()",
            "@h", PasswordHasher.Hash(newPassword), "@e", email, "@c", code);
        if (n == 0) throw new AppException("The code is invalid or has expired.");
    }
}
