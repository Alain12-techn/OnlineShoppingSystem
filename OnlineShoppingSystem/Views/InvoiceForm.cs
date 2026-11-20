using OnlineShoppingSystem.Controllers;
using OnlineShoppingSystem.Helpers;

namespace OnlineShoppingSystem.Views;

public partial class InvoiceForm : Form
{
    private readonly int _orderId;

    public InvoiceForm(int orderId)
    {
        InitializeComponent();
        _orderId = orderId;
        Text = "Invoice #" + orderId.ToString("D6");
        try { txtInvoice.Text = new OrderController().BuildInvoice(orderId); }
        catch (Exception ex) { UI.Error(ex); }
    }

    private void btnPrint_Click(object sender, EventArgs e) => PrintHelper.PrintPreview(Text, txtInvoice.Text);

    private void btnSaveFile_Click(object sender, EventArgs e)
    {
        using var dlg = new SaveFileDialog { Filter = "Text file (*.txt)|*.txt", FileName = "Invoice_" + _orderId.ToString("D6") + ".txt" };
        if (dlg.ShowDialog(this) == DialogResult.OK) { File.WriteAllText(dlg.FileName, txtInvoice.Text); UI.Info("Invoice saved."); }
    }
}
