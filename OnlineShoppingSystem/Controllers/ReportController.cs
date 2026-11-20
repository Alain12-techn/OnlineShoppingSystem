using System.Data;
using OnlineShoppingSystem.Data;

namespace OnlineShoppingSystem.Controllers;

public class ReportController
{
    /// <summary>FR-33: sales (excluding cancelled orders) for a date range grouped by date, product or category.</summary>
    public DataTable Sales(DateTime from, DateTime to, string groupBy)
    {
        string grp, join = "";
        switch (groupBy)
        {
            case "By Product": grp = "oi.product_name"; break;
            case "By Category":
                join = "LEFT JOIN products p ON p.id=oi.product_id LEFT JOIN categories c ON c.id=p.category_id";
                grp = "COALESCE(c.name,'(Uncategorised / deleted)')"; break;
            default: grp = "DATE_FORMAT(o.order_date,'%Y-%m-%d')"; break;
        }
        string sql = $@"SELECT {grp} AS `Group`, COUNT(DISTINCT o.id) AS `Orders`, SUM(oi.quantity) AS `Units Sold`,
                               SUM(oi.quantity*oi.unit_price) AS `Revenue`
                        FROM orders o JOIN order_items oi ON oi.order_id=o.id {join}
                        WHERE o.status<>'Cancelled' AND o.order_date>=@f AND o.order_date<@t
                        GROUP BY {grp} ORDER BY {grp}";
        return Db.Query(sql, "@f", from.Date, "@t", to.Date.AddDays(1));
    }
}
