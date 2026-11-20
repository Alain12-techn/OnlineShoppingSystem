using System.Data;
using OnlineShoppingSystem.Controllers;
using OnlineShoppingSystem.Helpers;

namespace OnlineShoppingSystem.Views;

public partial class ReportsControl : UserControl
{
    private DataTable _report;

    public ReportsControl() { InitializeComponent(); }

    private void ReportsControl_Load(object sender, EventArgs e)
    {
        if (DesignMode) return;
        dtpFrom.Value = new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);
        dtpTo.Value = DateTime.Today;
        cboGroup.Items.AddRange(new object[] { "By Date", "By Product", "By Category" });
        cboGroup.SelectedIndex = 0;
    }

    private void btnGenerate_Click(object sender, EventArgs e)
    {
        if (dtpFrom.Value.Date > dtpTo.Value.Date) { UI.Warn("The 'From' date must not be after the 'To' date."); return; }
        try
        {
            _report = new ReportController().Sales(dtpFrom.Value, dtpTo.Value, cboGroup.SelectedItem.ToString());
            gridReport.DataSource = _report;
            UI.Format(gridReport, "N2", "Revenue");
            decimal rev = 0; int units = 0;
            foreach (DataRow r in _report.Rows) { rev += Convert.ToDecimal(r["Revenue"]); units += Convert.ToInt32(r["Units Sold"]); }
            lblTotals.Text = $"Total revenue: {rev:N2}     Units sold: {units}     Rows: {_report.Rows.Count}";
        }
        catch (Exception ex) { UI.Error(ex); }
    }

    private bool HasReport()
    {
        if (_report == null) { UI.Warn("Generate a report first."); return false; }
        return true;
    }

    private void btnExportCsv_Click(object sender, EventArgs e)
    {
        if (!HasReport()) return;
        using var dlg = new SaveFileDialog { Filter = "CSV (opens in Excel)|*.csv", FileName = $"SalesReport_{DateTime.Today:yyyyMMdd}.csv" };
        if (dlg.ShowDialog(this) != DialogResult.OK) return;
        try { CsvHelper.Export(_report, dlg.FileName); UI.Info("Report exported. Open the .csv file with Excel."); }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnPrint_Click(object sender, EventArgs e)
    {
        if (!HasReport()) return;
        string header = $"SALES REPORT ({cboGroup.SelectedItem})\r\nFrom {dtpFrom.Value:yyyy-MM-dd} to {dtpTo.Value:yyyy-MM-dd}\r\n\r\n";
        PrintHelper.PrintPreview("Sales report", header + PrintHelper.TableToText(_report) + "\r\n" + lblTotals.Text);
    }
}
