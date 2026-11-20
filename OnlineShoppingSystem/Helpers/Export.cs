using System.Data;
using System.Globalization;
using System.Text;

namespace OnlineShoppingSystem.Helpers;

public static class CsvHelper
{
    public static void Export(DataTable dt, string path)
    {
        var sb = new StringBuilder();
        sb.AppendLine(string.Join(",", dt.Columns.Cast<DataColumn>().Select(c => Q(c.ColumnName))));
        foreach (DataRow r in dt.Rows)
            sb.AppendLine(string.Join(",", r.ItemArray.Select(v => Q(v == DBNull.Value ? "" : Convert.ToString(v, CultureInfo.InvariantCulture)))));
        File.WriteAllText(path, sb.ToString(), new UTF8Encoding(true));
    }

    private static string Q(string s) => "\"" + s.Replace("\"", "\"\"") + "\"";
}

public static class PrintHelper
{
    /// <summary>Opens a print preview. Choose "Microsoft Print to PDF" as the printer to save a PDF.</summary>
    public static void PrintPreview(string title, string text)
    {
        var lines = text.Replace("\r", "").Split('\n');
        int idx = 0;
        var doc = new System.Drawing.Printing.PrintDocument { DocumentName = title };
        using var font = new Font("Consolas", 9f);
        doc.PrintPage += (s, e) =>
        {
            float y = e.MarginBounds.Top, lh = font.GetHeight(e.Graphics);
            while (idx < lines.Length && y + lh <= e.MarginBounds.Bottom)
            {
                e.Graphics.DrawString(lines[idx++], font, Brushes.Black, e.MarginBounds.Left, y);
                y += lh;
            }
            e.HasMorePages = idx < lines.Length;
        };
        using var dlg = new PrintPreviewDialog { Document = doc, Width = 900, Height = 700 };
        dlg.ShowDialog();
    }

    public static string TableToText(DataTable dt)
    {
        string Fmt(object v) => v is decimal d ? d.ToString("N2") : v is DateTime t ? t.ToString("yyyy-MM-dd") : v == DBNull.Value ? "" : Convert.ToString(v);
        var widths = dt.Columns.Cast<DataColumn>().Select(c =>
            Math.Min(32, Math.Max(c.ColumnName.Length, dt.Rows.Cast<DataRow>().Select(r => Fmt(r[c]).Length).DefaultIfEmpty(0).Max()))).ToArray();
        var sb = new StringBuilder();
        for (int i = 0; i < dt.Columns.Count; i++) sb.Append(dt.Columns[i].ColumnName.PadRight(widths[i] + 2));
        sb.AppendLine();
        sb.AppendLine(new string('-', widths.Sum() + 2 * widths.Length));
        foreach (DataRow r in dt.Rows)
        {
            for (int i = 0; i < dt.Columns.Count; i++)
            {
                string s = Fmt(r[i]); if (s.Length > widths[i]) s = s.Substring(0, widths[i]);
                sb.Append(s.PadRight(widths[i] + 2));
            }
            sb.AppendLine();
        }
        return sb.ToString();
    }
}
