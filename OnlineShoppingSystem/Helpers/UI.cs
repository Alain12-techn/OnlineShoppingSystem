using System.Data;
using MySqlConnector;
using OnlineShoppingSystem.Models;

namespace OnlineShoppingSystem.Helpers;

/// <summary>Shared WinForms helpers (message boxes, grids, combo boxes, images).</summary>
public static class UI
{
    private const string Title = "Online Shopping System";
    public static string ImagesDir => Path.Combine(AppContext.BaseDirectory, "Images");

    public static void Info(string m) => MessageBox.Show(m, Title, MessageBoxButtons.OK, MessageBoxIcon.Information);
    public static void Warn(string m) => MessageBox.Show(m, Title, MessageBoxButtons.OK, MessageBoxIcon.Warning);
    public static bool Confirm(string m) => MessageBox.Show(m, Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;

    public static void Error(Exception ex)
    {
        if (ex is AppException) Warn(ex.Message);
        else if (ex is MySqlException my && (int)my.ErrorCode == 1062) Warn("That value already exists (duplicate). Please use a different one.");
        else if (ex is MySqlException my2 && (int)my2.ErrorCode == 1451) Warn("This record is used by other data (for example orders) and cannot be deleted.");
        else MessageBox.Show(ex.Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public static string Str(object o) => o == null || o == DBNull.Value ? "" : Convert.ToString(o);
    public static int IntOrZero(object o) => o == null || o == DBNull.Value ? 0 : Convert.ToInt32(o);
    public static int? NullIfZero(int v) => v == 0 ? (int?)null : v;
    public static string Money(object o) => Convert.ToDecimal(o).ToString("N2");

    // ---------- grids ----------
    public static DataRow SelectedRow(DataGridView g) => g.CurrentRow?.DataBoundItem is DataRowView v ? v.Row : null;

    public static void ShowColumns(DataGridView g, params (string col, string header)[] cols)
    {
        foreach (DataGridViewColumn c in g.Columns) c.Visible = false;
        int i = 0;
        foreach (var (col, header) in cols)
        {
            var c = g.Columns[col];
            if (c == null) continue;
            c.Visible = true; c.HeaderText = header; c.DisplayIndex = i++;
        }
    }

    public static void Format(DataGridView g, string format, params string[] cols)
    {
        foreach (var c in cols) if (g.Columns[c] != null) g.Columns[c].DefaultCellStyle.Format = format;
    }

    // ---------- combo boxes ----------
    public static void Fill(ComboBox c, IEnumerable<ComboItem> items)
    {
        c.Items.Clear();
        foreach (var i in items) c.Items.Add(i);
        if (c.Items.Count > 0) c.SelectedIndex = 0;
    }

    public static int SelectedId(ComboBox c) => c.SelectedItem is ComboItem i ? i.Id : 0;

    public static void SelectId(ComboBox c, int id)
    {
        foreach (var o in c.Items)
            if (o is ComboItem i && i.Id == id) { c.SelectedItem = i; return; }
        if (c.Items.Count > 0) c.SelectedIndex = 0;
    }

    // ---------- images ----------
    public static void LoadImage(PictureBox pb, string fileName)
    {
        pb.Image?.Dispose(); pb.Image = null;
        if (string.IsNullOrWhiteSpace(fileName)) return;
        string path = Path.Combine(ImagesDir, fileName);
        if (!File.Exists(path)) return;
        try
        {
            using var fs = File.OpenRead(path);
            using var img = Image.FromStream(fs);
            pb.Image = new Bitmap(img);
        }
        catch { }
    }
}
