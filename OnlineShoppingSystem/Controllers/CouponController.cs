using System.Data;
using OnlineShoppingSystem.Data;
using OnlineShoppingSystem.Helpers;
using OnlineShoppingSystem.Models;

namespace OnlineShoppingSystem.Controllers;

public class CouponController
{
    public DataTable GetAll() => Db.Query("SELECT id,code,discount_percent,expiry_date,is_active FROM coupons ORDER BY code");

    /// <summary>FR-17: returns the coupon if it exists, is active and has not expired.</summary>
    public Coupon GetValid(string code)
    {
        Validator.Required(code, "Coupon code");
        var dt = Db.Query("SELECT id,code,discount_percent,expiry_date,is_active FROM coupons WHERE code=@c", "@c", code.Trim());
        if (dt.Rows.Count == 0) throw new AppException("Invalid coupon code.");
        var r = dt.Rows[0];
        var c = new Coupon
        {
            Id = Convert.ToInt32(r["id"]), Code = (string)r["code"], DiscountPercent = Convert.ToDecimal(r["discount_percent"]),
            ExpiryDate = Convert.ToDateTime(r["expiry_date"]), IsActive = Convert.ToBoolean(r["is_active"])
        };
        if (!c.IsActive) throw new AppException("This coupon is not active.");
        if (c.ExpiryDate.Date < DateTime.Today) throw new AppException("This coupon has expired.");
        return c;
    }

    private static void Check(string code, decimal pct)
    {
        Validator.Required(code, "Code");
        if (pct <= 0 || pct > 100) throw new AppException("Discount must be between 0.01 and 100 percent.");
    }

    public void Add(string code, decimal pct, DateTime expiry, bool active)
    {
        Check(code, pct);
        Db.Execute("INSERT INTO coupons(code,discount_percent,expiry_date,is_active) VALUES(@c,@d,@e,@a)",
            "@c", code.Trim().ToUpper(), "@d", pct, "@e", expiry.Date, "@a", active ? 1 : 0);
    }

    public void Update(int id, string code, decimal pct, DateTime expiry, bool active)
    {
        Check(code, pct);
        Db.Execute("UPDATE coupons SET code=@c,discount_percent=@d,expiry_date=@e,is_active=@a WHERE id=@i",
            "@c", code.Trim().ToUpper(), "@d", pct, "@e", expiry.Date, "@a", active ? 1 : 0, "@i", id);
    }

    public void Delete(int id) => Db.Execute("DELETE FROM coupons WHERE id=@i", "@i", id);
}
