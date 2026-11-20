using System.Data;
using OnlineShoppingSystem.Models;

namespace OnlineShoppingSystem.Helpers;

public static class Pricing
{
    public static readonly (string Name, decimal Fee)[] Shipping =
    {
        ("Standard (3-5 days)", 5.00m),
        ("Express (1-2 days)", 15.00m),
        ("Store pickup", 0.00m)
    };

    public static decimal Subtotal(DataTable items)
    {
        decimal s = 0;
        foreach (DataRow r in items.Rows) s += Convert.ToDecimal(r["line_total"]);
        return s;
    }

    /// <summary>FR-12: subtotal, discount, tax and total.</summary>
    public static CartTotals Compute(decimal subtotal, decimal discountPercent, decimal shippingFee = 0)
    {
        decimal discount = Math.Round(subtotal * discountPercent / 100m, 2);
        decimal taxable = subtotal - discount;
        decimal tax = Math.Round(taxable * AppSettings.TaxRate, 2);
        return new CartTotals { Subtotal = subtotal, Discount = discount, Tax = tax, Shipping = shippingFee, Total = taxable + tax + shippingFee };
    }
}
