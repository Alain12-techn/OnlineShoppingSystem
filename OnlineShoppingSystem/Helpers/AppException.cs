namespace OnlineShoppingSystem.Helpers;

/// <summary>Business-rule / validation error whose message is safe to show to the user.</summary>
public class AppException : Exception
{
    public AppException(string message) : base(message) { }
}
