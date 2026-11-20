namespace OnlineShoppingSystem.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Sku { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public int StockQty { get; set; }
    public int LowStockLevel { get; set; }
    public int? CategoryId { get; set; }
    public int? BrandId { get; set; }
    public string ImageUrl { get; set; }
}
