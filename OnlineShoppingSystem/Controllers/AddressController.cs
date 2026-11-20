using System.Data;
using OnlineShoppingSystem.Data;
using OnlineShoppingSystem.Helpers;
using OnlineShoppingSystem.Models;

namespace OnlineShoppingSystem.Controllers;

public class AddressController
{
    public DataTable GetTable(int userId) => Db.Query("SELECT id,street,city,phone FROM addresses WHERE user_id=@u ORDER BY id", "@u", userId);

    public List<Address> GetByUser(int userId)
    {
        var list = new List<Address>();
        foreach (DataRow r in GetTable(userId).Rows)
            list.Add(new Address { Id = Convert.ToInt32(r["id"]), UserId = userId, Street = (string)r["street"], City = (string)r["city"], Phone = (string)r["phone"] });
        return list;
    }

    private static void Check(string street, string city, string phone)
    {
        Validator.Required(street, "Street");
        Validator.Required(city, "City");
        Validator.Phone(phone);
    }

    public int Add(int userId, string street, string city, string phone)
    {
        Check(street, city, phone);
        return (int)Db.Insert("INSERT INTO addresses(user_id,street,city,phone) VALUES(@u,@s,@c,@p)", "@u", userId, "@s", street.Trim(), "@c", city.Trim(), "@p", phone.Trim());
    }

    public void Update(int id, int userId, string street, string city, string phone)
    {
        Check(street, city, phone);
        Db.Execute("UPDATE addresses SET street=@s,city=@c,phone=@p WHERE id=@i AND user_id=@u", "@s", street.Trim(), "@c", city.Trim(), "@p", phone.Trim(), "@i", id, "@u", userId);
    }

    public void Delete(int id, int userId) => Db.Execute("DELETE FROM addresses WHERE id=@i AND user_id=@u", "@i", id, "@u", userId);
}
