namespace OnlineShoppingSystem.Views
{
    partial class ReportsControl
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
            this.pnlTop = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFrom = new System.Windows.Forms.Label();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.lblGroup = new System.Windows.Forms.Label();
            this.cboGroup = new System.Windows.Forms.ComboBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnExportCsv = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.lblTotals = new System.Windows.Forms.Label();
            this.gridReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridReport)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(300, 40);
            this.pnlTop.AutoSize = true;
            this.pnlTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTop.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pnlTop.TabIndex = 0;
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.TabIndex = 1;
            this.lblFrom.Text = "From";
            // 
            // dtpFrom
            // 
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(110, 23);
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.TabIndex = 2;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblTo.Name = "lblTo";
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "To";
            // 
            // dtpTo
            // 
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(110, 23);
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.TabIndex = 4;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.TabIndex = 5;
            this.lblGroup.Text = "Group by";
            // 
            // cboGroup
            // 
            this.cboGroup.Name = "cboGroup";
            this.cboGroup.Size = new System.Drawing.Size(120, 23);
            this.cboGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGroup.FormattingEnabled = true;
            this.cboGroup.TabIndex = 6;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(90, 30);
            this.btnGenerate.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate.FlatAppearance.BorderSize = 0;
            this.btnGenerate.TabIndex = 7;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.Click += new EventHandler(this.btnGenerate_Click);
            // 
            // btnExportCsv
            // 
            this.btnExportCsv.Name = "btnExportCsv";
            this.btnExportCsv.Size = new System.Drawing.Size(150, 30);
            this.btnExportCsv.TabIndex = 8;
            this.btnExportCsv.Text = "Export to Excel (CSV)";
            this.btnExportCsv.UseVisualStyleBackColor = true;
            this.btnExportCsv.Click += new EventHandler(this.btnExportCsv_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(90, 30);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print / PDF";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new EventHandler(this.btnPrint_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(300, 40);
            this.pnlBottom.BackColor = System.Drawing.Color.White;
            this.pnlBottom.TabIndex = 10;
            // 
            // lblTotals
            // 
            this.lblTotals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotals.Name = "lblTotals";
            this.lblTotals.Size = new System.Drawing.Size(300, 40);
            this.lblTotals.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotals.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTotals.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblTotals.TabIndex = 11;
            this.lblTotals.Text = "Generate a report to see totals.";
            // 
            // gridReport
            // 
            this.gridReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridReport.Name = "gridReport";
            this.gridReport.Size = new System.Drawing.Size(300, 200);
            this.gridReport.AllowUserToAddRows = false;
            this.gridReport.AllowUserToDeleteRows = false;
            this.gridReport.AllowUserToResizeRows = false;
            this.gridReport.ReadOnly = true;
            this.gridReport.MultiSelect = false;
            this.gridReport.RowHeadersVisible = false;
            this.gridReport.BackgroundColor = System.Drawing.Color.White;
            this.gridReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridReport.TabIndex = 12;
            // 
            // pnlTop (children)
            // 
            this.pnlTop.Controls.Add(this.lblFrom);
            this.pnlTop.Controls.Add(this.dtpFrom);
            this.pnlTop.Controls.Add(this.lblTo);
            this.pnlTop.Controls.Add(this.dtpTo);
            this.pnlTop.Controls.Add(this.lblGroup);
            this.pnlTop.Controls.Add(this.cboGroup);
            this.pnlTop.Controls.Add(this.btnGenerate);
            this.pnlTop.Controls.Add(this.btnExportCsv);
            this.pnlTop.Controls.Add(this.btnPrint);
            // 
            // pnlBottom (children)
            // 
            this.pnlBottom.Controls.Add(this.lblTotals);
            // 
            // ReportsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.gridReport);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlTop);
            this.Name = "ReportsControl";
            this.Load += new EventHandler(this.ReportsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridReport)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.pnlBottom.ResumeLayout(false);
            this.pnlBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlTop;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.DateTimePicker dtpFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.DateTimePicker dtpTo;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.ComboBox cboGroup;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnExportCsv;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Label lblTotals;
        private System.Windows.Forms.DataGridView gridReport;
    }
}
