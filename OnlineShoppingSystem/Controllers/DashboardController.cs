using System.Data;
using OnlineShoppingSystem.Data;

namespace OnlineShoppingSystem.Controllers;

public class DashboardController
{
    /// <summary>FR-32: totals for the admin dashboard.</summary>
    public DataRow Stats() => Db.Query(
        @"SELECT (SELECT COALESCE(SUM(total_amount),0) FROM orders WHERE status<>'Cancelled') AS total_sales,
                 (SELECT COUNT(*) FROM orders) AS total_orders,
                 (SELECT COUNT(*) FROM users WHERE role='Customer') AS customers,
                 (SELECT COUNT(*) FROM orders WHERE status='Pending') AS pending,
                 (SELECT COUNT(*) FROM products WHERE stock_qty<=low_stock_level) AS low_stock").Rows[0];
}
