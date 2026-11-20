using System.Text.RegularExpressions;

namespace OnlineShoppingSystem.Helpers;

public static class Validator
{
    public static void Required(string v, string field)
    {
        if (string.IsNullOrWhiteSpace(v)) throw new AppException(field + " is required.");
    }

    public static void Email(string v)
    {
        Required(v, "Email");
        if (!Regex.IsMatch(v.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$")) throw new AppException("Enter a valid email address.");
    }

    public static void Phone(string v)
    {
        Required(v, "Phone");
        if (!Regex.IsMatch(v.Trim(), @"^\+?[0-9\s\-]{7,15}$")) throw new AppException("Enter a valid phone number (7-15 digits).");
    }

    public static void Password(string p, string confirm)
    {
        if (p == null || p.Length < 6) throw new AppException("Password must be at least 6 characters.");
        if (p != confirm) throw new AppException("Passwords do not match.");
    }

    /// <summary>Sandbox card check (nothing is stored or sent anywhere).</summary>
    public static void Card(string name, string number, string expiry, string cvv)
    {
        Required(name, "Name on card");
        string digits = new string((number ?? "").Where(char.IsDigit).ToArray());
        if (digits.Length < 13 || digits.Length > 19 || !Luhn(digits)) throw new AppException("Card number is not valid. (Sandbox test card: 4242 4242 4242 4242)");
        var m = Regex.Match(expiry ?? "", @"^(0[1-9]|1[0-2])/(\d{2})$");
        if (!m.Success) throw new AppException("Expiry must be in MM/YY format.");
        var exp = new DateTime(2000 + int.Parse(m.Groups[2].Value), int.Parse(m.Groups[1].Value), 1).AddMonths(1).AddDays(-1);
        if (exp < DateTime.Today) throw new AppException("This card has expired.");
        if (!Regex.IsMatch(cvv ?? "", @"^\d{3,4}$")) throw new AppException("CVV must be 3 or 4 digits.");
    }

    private static bool Luhn(string digits)
    {
        int sum = 0; bool alt = false;
        for (int i = digits.Length - 1; i >= 0; i--)
        {
            int d = digits[i] - '0';
            if (alt) { d *= 2; if (d > 9) d -= 9; }
            sum += d; alt = !alt;
        }
        return sum % 10 == 0;
    }
}
