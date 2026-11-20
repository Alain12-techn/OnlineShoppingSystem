using System.Data;
using OnlineShoppingSystem.Data;
using OnlineShoppingSystem.Helpers;
using OnlineShoppingSystem.Models;

namespace OnlineShoppingSystem.Controllers;

public class UserController
{
    public static User FromRow(DataRow r) => new User
    {
        Id = Convert.ToInt32(r["id"]),
        Name = (string)r["name"],
        Email = (string)r["email"],
        Phone = UI.Str(r["phone"]),
        Role = (string)r["role"],
        IsActive = Convert.ToBoolean(r["is_active"])
    };

    public User GetById(int id)
    {
        var dt = Db.Query("SELECT id,name,email,phone,role,is_active FROM users WHERE id=@i", "@i", id);
        return dt.Rows.Count == 0 ? null : FromRow(dt.Rows[0]);
    }

    /// <summary>FR-5: customer edits own profile (password optional).</summary>
    public void UpdateProfile(int id, string name, string phone, string newPassword, string confirm)
    {
        Validator.Required(name, "Name");
        Validator.Phone(phone);
        if (!string.IsNullOrEmpty(newPassword))
        {
            Validator.Password(newPassword, confirm);
            Db.Execute("UPDATE users SET name=@n,phone=@p,password_hash=@h WHERE id=@i", "@n", name.Trim(), "@p", phone.Trim(), "@h", PasswordHasher.Hash(newPassword), "@i", id);
        }
        else Db.Execute("UPDATE users SET name=@n,phone=@p WHERE id=@i", "@n", name.Trim(), "@p", phone.Trim(), "@i", id);
    }

    // ---------- admin: customer management (FR-30) ----------
    public DataTable GetCustomers(string search)
    {
        return Db.Query(@"SELECT u.id,u.name,u.email,u.phone,IF(u.is_active=1,'Active','Inactive') AS status,u.created_at,
                          (SELECT COUNT(*) FROM orders o WHERE o.user_id=u.id) AS order_count
                          FROM users u WHERE u.role='Customer' AND (u.name LIKE @s OR u.email LIKE @s) ORDER BY u.name",
            "@s", "%" + (search ?? "") + "%");
    }

    public void AddCustomer(string name, string email, string phone, string password)
        => new AuthController().Register(name, email, phone, password, password);

    public void UpdateCustomer(int id, string name, string phone, string newPassword)
        => UpdateProfile(id, name, phone, newPassword, newPassword);

    public void SetActive(int id, bool active) => Db.Execute("UPDATE users SET is_active=@a WHERE id=@i AND role='Customer'", "@a", active ? 1 : 0, "@i", id);

    public void Delete(int id) => Db.Execute("DELETE FROM users WHERE id=@i AND role='Customer'", "@i", id);

    public DataTable GetNotifications(int userId)
        => Db.Query("SELECT id,created_at,subject,message FROM notifications WHERE user_id=@u ORDER BY id DESC", "@u", userId);
}
