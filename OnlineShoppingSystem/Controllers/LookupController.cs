using System.Data;
using OnlineShoppingSystem.Data;
using OnlineShoppingSystem.Helpers;
using OnlineShoppingSystem.Models;

namespace OnlineShoppingSystem.Controllers;

/// <summary>Categories (with sub-categories) and brands - FR-7, FR-27.</summary>
public class LookupController
{
    // ----- categories -----
    public DataTable GetCategories() => Db.Query(
        @"SELECT c.id,c.name,c.parent_category_id AS parent_id,COALESCE(p.name,'') AS parent
          FROM categories c LEFT JOIN categories p ON p.id=c.parent_category_id ORDER BY c.name");

    public void AddCategory(string name, int? parentId)
    {
        Validator.Required(name, "Category name");
        Db.Execute("INSERT INTO categories(name,parent_category_id) VALUES(@n,@p)", "@n", name.Trim(), "@p", parentId);
    }

    public void UpdateCategory(int id, string name, int? parentId)
    {
        Validator.Required(name, "Category name");
        if (parentId == id) throw new AppException("A category cannot be its own parent.");
        Db.Execute("UPDATE categories SET name=@n,parent_category_id=@p WHERE id=@i", "@n", name.Trim(), "@p", parentId, "@i", id);
    }

    public void DeleteCategory(int id) => Db.Execute("DELETE FROM categories WHERE id=@i", "@i", id);

    public List<ComboItem> CategoryItems(string firstText)
    {
        var list = new List<ComboItem>();
        if (firstText != null) list.Add(new ComboItem(0, firstText));
        foreach (DataRow r in Db.Query("SELECT id,name FROM categories ORDER BY name").Rows)
            list.Add(new ComboItem(Convert.ToInt32(r["id"]), (string)r["name"]));
        return list;
    }

    // ----- brands -----
    public DataTable GetBrands() => Db.Query("SELECT id,name FROM brands ORDER BY name");

    public void AddBrand(string name)
    {
        Validator.Required(name, "Brand name");
        Db.Execute("INSERT INTO brands(name) VALUES(@n)", "@n", name.Trim());
    }

    public void UpdateBrand(int id, string name)
    {
        Validator.Required(name, "Brand name");
        Db.Execute("UPDATE brands SET name=@n WHERE id=@i", "@n", name.Trim(), "@i", id);
    }

    public void DeleteBrand(int id) => Db.Execute("DELETE FROM brands WHERE id=@i", "@i", id);

    public List<ComboItem> BrandItems(string firstText)
    {
        var list = new List<ComboItem>();
        if (firstText != null) list.Add(new ComboItem(0, firstText));
        foreach (DataRow r in Db.Query("SELECT id,name FROM brands ORDER BY name").Rows)
            list.Add(new ComboItem(Convert.ToInt32(r["id"]), (string)r["name"]));
        return list;
    }
}
