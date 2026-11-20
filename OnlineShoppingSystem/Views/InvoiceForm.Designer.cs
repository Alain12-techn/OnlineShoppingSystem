namespace OnlineShoppingSystem.Views
{
    partial class InvoiceForm
    {
        /// <summary>Required designer variable.</summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>Clean up any resources being used.</summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtInvoice = new System.Windows.Forms.TextBox();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(100, 54);
            this.pnlButtons.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(12, 10);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(150, 34);
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.TabIndex = 1;
            this.btnPrint.Text = "Print / Save as PDF";
            this.btnPrint.Click += new EventHandler(this.btnPrint_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(172, 10);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(120, 34);
            this.btnSaveFile.TabIndex = 2;
            this.btnSaveFile.Text = "Save as text";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new EventHandler(this.btnSaveFile_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(302, 10);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(90, 34);
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // txtInvoice
            // 
            this.txtInvoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInvoice.Name = "txtInvoice";
            this.txtInvoice.Size = new System.Drawing.Size(300, 300);
            this.txtInvoice.Multiline = true;
            this.txtInvoice.ReadOnly = true;
            this.txtInvoice.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInvoice.WordWrap = false;
            this.txtInvoice.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtInvoice.BackColor = System.Drawing.Color.White;
            this.txtInvoice.TabIndex = 4;
            // 
            // pnlButtons (children)
            // 
            this.pnlButtons.Controls.Add(this.btnPrint);
            this.pnlButtons.Controls.Add(this.btnSaveFile);
            this.pnlButtons.Controls.Add(this.btnClose);
            // 
            // InvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 640);
            this.Controls.Add(this.txtInvoice);
            this.Controls.Add(this.pnlButtons);
            this.Name = "InvoiceForm";
            this.Text = "Invoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.CancelButton = this.btnClose;
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtInvoice;
    }
}
