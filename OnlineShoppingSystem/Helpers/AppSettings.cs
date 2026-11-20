using System.Text.Json;

namespace OnlineShoppingSystem.Helpers;

public static class AppSettings
{
    private static readonly JsonElement Root;

    static AppSettings()
    {
        var path = Path.Combine(AppContext.BaseDirectory, "appsettings.json");
        using var doc = JsonDocument.Parse(File.ReadAllText(path));
        Root = doc.RootElement.Clone();
    }

    public static string ConnectionString => Root.GetProperty("ConnectionString").GetString();
    public static decimal TaxRate => Root.GetProperty("TaxRate").GetDecimal();
    public static bool SmtpEnabled => Root.GetProperty("Smtp").GetProperty("Enabled").GetBoolean();
    public static int SmtpPort => Root.GetProperty("Smtp").GetProperty("Port").GetInt32();
    public static string Smtp(string key) => Root.GetProperty("Smtp").GetProperty(key).GetString();
}
