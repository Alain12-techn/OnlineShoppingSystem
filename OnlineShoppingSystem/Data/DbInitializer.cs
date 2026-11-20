using OnlineShoppingSystem.Helpers;

namespace OnlineShoppingSystem.Data;

public static class DbInitializer
{
    public const string AdminEmail = "admin@oss.com";
    public const string AdminPassword = "Admin@123";

    /// <summary>Checks the connection and creates the default admin account on first run.</summary>
    public static void Initialize()
    {
        using (var c = Db.CreateConnection()) c.Open();
        int admins = Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM users WHERE role='Admin'"));
        if (admins == 0)
            Db.Execute("INSERT INTO users(name,email,phone,password_hash,role) VALUES('Administrator',@e,'0780000000',@h,'Admin')",
                "@e", AdminEmail, "@h", PasswordHasher.Hash(AdminPassword));
    }
}
