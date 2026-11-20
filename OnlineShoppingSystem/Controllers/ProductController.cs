using System.Data;
using OnlineShoppingSystem.Data;
using OnlineShoppingSystem.Helpers;
using OnlineShoppingSystem.Models;

namespace OnlineShoppingSystem.Controllers;

public class ProductController
{
    /// <summary>FR-6, 8, 9: search, filter and sort. Used by both the shop and the admin product screen.</summary>
    public DataTable Search(string keyword, int categoryId, int brandId, decimal minPrice, decimal? maxPrice, int minRating, string sort)
    {
        string order;
        switch (sort)
        {
            case "Price: Low to High": order = "p.price ASC"; break;
            case "Price: High to Low": order = "p.price DESC"; break;
            case "Popularity": order = "sold DESC, p.name"; break;
            case "Name": order = "p.name"; break;
            default: order = "p.created_at DESC, p.id DESC"; break;
        }
        string sql = @"SELECT p.id,p.name,p.sku,p.description,p.price,p.stock_qty,p.low_stock_level,p.category_id,p.brand_id,
              COALESCE(c.name,'') AS category, COALESCE(b.name,'') AS brand, p.image_url,
              COALESCE((SELECT ROUND(AVG(r.rating),1) FROM reviews r WHERE r.product_id=p.id AND r.is_approved=1),0) AS avg_rating,
              COALESCE((SELECT SUM(oi.quantity) FROM order_items oi JOIN orders o ON o.id=oi.order_id WHERE oi.product_id=p.id AND o.status<>'Cancelled'),0) AS sold,
              CASE WHEN p.stock_qty<=0 THEN 'Out of stock' WHEN p.stock_qty<=p.low_stock_level THEN 'Low stock' ELSE 'In stock' END AS status,
              p.created_at
            FROM products p LEFT JOIN categories c ON c.id=p.category_id LEFT JOIN brands b ON b.id=p.brand_id
            WHERE (p.name LIKE @kw OR p.sku LIKE @kw OR p.description LIKE @kw OR c.name LIKE @kw OR b.name LIKE @kw)
              AND (@cat=0 OR p.category_id=@cat OR c.parent_category_id=@cat)
              AND (@brand=0 OR p.brand_id=@brand)
              AND p.price>=@min AND (@max=0 OR p.price<=@max)
            HAVING avg_rating>=@rating
            ORDER BY " + order;
        return Db.Query(sql, "@kw", "%" + (keyword ?? "") + "%", "@cat", categoryId, "@brand", brandId,
            "@min", minPrice, "@max", maxPrice ?? 0m, "@rating", minRating);
    }

    private static void Validate(Product p)
    {
        Validator.Required(p.Name, "Product name");
        Validator.Required(p.Sku, "SKU");
        if (p.Price < 0) throw new AppException("Price cannot be negative.");
        if (p.StockQty < 0) throw new AppException("Stock cannot be negative.");
    }

    public int Add(Product p)
    {
        Validate(p);
        return (int)Db.Insert(@"INSERT INTO products(name,sku,description,price,stock_qty,low_stock_level,category_id,brand_id,image_url)
                                VALUES(@n,@s,@d,@p,@q,@l,@c,@b,@i)",
            "@n", p.Name.Trim(), "@s", p.Sku.Trim(), "@d", p.Description, "@p", p.Price, "@q", p.StockQty, "@l", p.LowStockLevel,
            "@c", p.CategoryId, "@b", p.BrandId, "@i", string.IsNullOrWhiteSpace(p.ImageUrl) ? null : p.ImageUrl);
    }

    public void Update(Product p)
    {
        Validate(p);
        Db.Execute(@"UPDATE products SET name=@n,sku=@s,description=@d,price=@p,stock_qty=@q,low_stock_level=@l,category_id=@c,brand_id=@b,image_url=@i WHERE id=@id",
            "@n", p.Name.Trim(), "@s", p.Sku.Trim(), "@d", p.Description, "@p", p.Price, "@q", p.StockQty, "@l", p.LowStockLevel,
            "@c", p.CategoryId, "@b", p.BrandId, "@i", string.IsNullOrWhiteSpace(p.ImageUrl) ? null : p.ImageUrl, "@id", p.Id);
    }

    public void Delete(int id) => Db.Execute("DELETE FROM products WHERE id=@i", "@i", id);

    /// <summary>FR-28: products at or below their alert level.</summary>
    public DataTable LowStock() => Db.Query(
        "SELECT name,sku,stock_qty,low_stock_level FROM products WHERE stock_qty<=low_stock_level ORDER BY stock_qty, name");

    // ----- reviews shown on the product page (FR-10) -----
    public DataTable GetApprovedReviews(int productId) => Db.Query(
        @"SELECT u.name AS reviewer,r.rating,r.comment,r.created_at FROM reviews r JOIN users u ON u.id=r.user_id
          WHERE r.product_id=@p AND r.is_approved=1 ORDER BY r.created_at DESC", "@p", productId);

    // ----- wishlist (FR-14) -----
    public void AddToWishlist(int userId, int productId)
        => Db.Execute("INSERT IGNORE INTO wishlist(user_id,product_id) VALUES(@u,@p)", "@u", userId, "@p", productId);

    public DataTable GetWishlist(int userId) => Db.Query(
        @"SELECT w.id AS wishlist_id,p.id AS product_id,p.name,p.price,p.stock_qty,COALESCE(b.name,'') AS brand
          FROM wishlist w JOIN products p ON p.id=w.product_id LEFT JOIN brands b ON b.id=p.brand_id
          WHERE w.user_id=@u ORDER BY w.id DESC", "@u", userId);

    public void RemoveFromWishlist(int wishlistId, int userId)
        => Db.Execute("DELETE FROM wishlist WHERE id=@i AND user_id=@u", "@i", wishlistId, "@u", userId);
}
