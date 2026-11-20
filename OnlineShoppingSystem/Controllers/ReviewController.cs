using System.Data;
using OnlineShoppingSystem.Data;
using OnlineShoppingSystem.Helpers;

namespace OnlineShoppingSystem.Controllers;

public class ReviewController
{
    /// <summary>FR-24: only customers whose order containing the product was delivered may review it.</summary>
    public bool CanReview(int userId, int productId)
        => Convert.ToInt32(Db.Scalar(@"SELECT COUNT(*) FROM order_items oi JOIN orders o ON o.id=oi.order_id
                                       WHERE o.user_id=@u AND oi.product_id=@p AND o.status='Delivered'", "@u", userId, "@p", productId)) > 0;

    public void Submit(int userId, int productId, int rating, string comment)
    {
        if (rating < 1 || rating > 5) throw new AppException("Rating must be between 1 and 5.");
        if (!CanReview(userId, productId)) throw new AppException("You can review a product only after an order containing it has been delivered.");
        Db.Execute(@"INSERT INTO reviews(product_id,user_id,rating,comment,is_approved) VALUES(@p,@u,@r,@c,0)
                     ON DUPLICATE KEY UPDATE rating=@r, comment=@c, is_approved=0, created_at=NOW()",
            "@p", productId, "@u", userId, "@r", rating, "@c", comment);
    }

    // ----- admin (FR-25) -----
    public DataTable GetAll(string filter) => Db.Query(
        @"SELECT r.id,p.name AS product,u.name AS reviewer,r.rating,r.comment,r.is_approved,r.created_at
          FROM reviews r JOIN products p ON p.id=r.product_id JOIN users u ON u.id=r.user_id
          WHERE (@f='All' OR (@f='Pending' AND r.is_approved=0) OR (@f='Approved' AND r.is_approved=1))
          ORDER BY r.created_at DESC", "@f", filter ?? "All");

    public void SetApproved(int id, bool approved) => Db.Execute("UPDATE reviews SET is_approved=@a WHERE id=@i", "@a", approved ? 1 : 0, "@i", id);

    public void Delete(int id) => Db.Execute("DELETE FROM reviews WHERE id=@i", "@i", id);
}
