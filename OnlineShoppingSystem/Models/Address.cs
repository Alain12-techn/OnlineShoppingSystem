namespace OnlineShoppingSystem.Models;

public class Address
{
    public int Id { get; set; }
    public int UserId { get; set; }
    public string Street { get; set; }
    public string City { get; set; }
    public string Phone { get; set; }
    public override string ToString() => $"{Street}, {City} ({Phone})";
}
