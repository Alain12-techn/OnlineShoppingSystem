using OnlineShoppingSystem.Models;

namespace OnlineShoppingSystem.Helpers;

public static class Session
{
    public static User CurrentUser { get; set; }
    public static int UserId => CurrentUser?.Id ?? 0;
    public static bool IsAdmin => CurrentUser?.Role == "Admin";
}
