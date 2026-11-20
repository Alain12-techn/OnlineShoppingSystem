namespace OnlineShoppingSystem.Models;

/// <summary>Id + text pair used to fill ComboBoxes.</summary>
public class ComboItem
{
    public ComboItem(int id, string text) { Id = id; Text = text; }
    public int Id { get; }
    public string Text { get; }
    public override string ToString() => Text;
}
