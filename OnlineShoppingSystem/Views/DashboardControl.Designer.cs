namespace OnlineShoppingSystem.Views
{
    partial class DashboardControl
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
            this.pnlCards = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlCardSales = new System.Windows.Forms.Panel();
            this.lblSalesTitle = new System.Windows.Forms.Label();
            this.lblSalesValue = new System.Windows.Forms.Label();
            this.pnlCardOrders = new System.Windows.Forms.Panel();
            this.lblOrdersTitle = new System.Windows.Forms.Label();
            this.lblOrdersValue = new System.Windows.Forms.Label();
            this.pnlCardCustomers = new System.Windows.Forms.Panel();
            this.lblCustomersTitle = new System.Windows.Forms.Label();
            this.lblCustomersValue = new System.Windows.Forms.Label();
            this.pnlCardPending = new System.Windows.Forms.Panel();
            this.lblPendingTitle = new System.Windows.Forms.Label();
            this.lblPendingValue = new System.Windows.Forms.Label();
            this.pnlCardLow = new System.Windows.Forms.Panel();
            this.lblLowTitle = new System.Windows.Forms.Label();
            this.lblLowValue = new System.Windows.Forms.Label();
            this.pnlLowHeader = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblLowHdr = new System.Windows.Forms.Label();
            this.gridLow = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridLow)).BeginInit();
            this.pnlCards.SuspendLayout();
            this.pnlCardSales.SuspendLayout();
            this.pnlCardOrders.SuspendLayout();
            this.pnlCardCustomers.SuspendLayout();
            this.pnlCardPending.SuspendLayout();
            this.pnlCardLow.SuspendLayout();
            this.pnlLowHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCards
            // 
            this.pnlCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Size = new System.Drawing.Size(300, 40);
            this.pnlCards.AutoSize = true;
            this.pnlCards.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlCards.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pnlCards.TabIndex = 0;
            // 
            // pnlCardSales
            // 
            this.pnlCardSales.Name = "pnlCardSales";
            this.pnlCardSales.Size = new System.Drawing.Size(210, 96);
            this.pnlCardSales.BackColor = System.Drawing.Color.FromArgb(46, 125, 50);
            this.pnlCardSales.Margin = new System.Windows.Forms.Padding(8);
            this.pnlCardSales.TabIndex = 1;
            // 
            // lblSalesTitle
            // 
            this.lblSalesTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSalesTitle.Name = "lblSalesTitle";
            this.lblSalesTitle.Size = new System.Drawing.Size(210, 30);
            this.lblSalesTitle.ForeColor = System.Drawing.Color.White;
            this.lblSalesTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSalesTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblSalesTitle.TabIndex = 2;
            this.lblSalesTitle.Text = "Total sales";
            // 
            // lblSalesValue
            // 
            this.lblSalesValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSalesValue.Name = "lblSalesValue";
            this.lblSalesValue.Size = new System.Drawing.Size(210, 60);
            this.lblSalesValue.ForeColor = System.Drawing.Color.White;
            this.lblSalesValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSalesValue.TabIndex = 3;
            this.lblSalesValue.Text = "0";
            // 
            // pnlCardOrders
            // 
            this.pnlCardOrders.Name = "pnlCardOrders";
            this.pnlCardOrders.Size = new System.Drawing.Size(210, 96);
            this.pnlCardOrders.BackColor = System.Drawing.Color.FromArgb(21, 101, 192);
            this.pnlCardOrders.Margin = new System.Windows.Forms.Padding(8);
            this.pnlCardOrders.TabIndex = 4;
            // 
            // lblOrdersTitle
            // 
            this.lblOrdersTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblOrdersTitle.Name = "lblOrdersTitle";
            this.lblOrdersTitle.Size = new System.Drawing.Size(210, 30);
            this.lblOrdersTitle.ForeColor = System.Drawing.Color.White;
            this.lblOrdersTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOrdersTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblOrdersTitle.TabIndex = 5;
            this.lblOrdersTitle.Text = "Total orders";
            // 
            // lblOrdersValue
            // 
            this.lblOrdersValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblOrdersValue.Name = "lblOrdersValue";
            this.lblOrdersValue.Size = new System.Drawing.Size(210, 60);
            this.lblOrdersValue.ForeColor = System.Drawing.Color.White;
            this.lblOrdersValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrdersValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOrdersValue.TabIndex = 6;
            this.lblOrdersValue.Text = "0";
            // 
            // pnlCardCustomers
            // 
            this.pnlCardCustomers.Name = "pnlCardCustomers";
            this.pnlCardCustomers.Size = new System.Drawing.Size(210, 96);
            this.pnlCardCustomers.BackColor = System.Drawing.Color.FromArgb(106, 27, 154);
            this.pnlCardCustomers.Margin = new System.Windows.Forms.Padding(8);
            this.pnlCardCustomers.TabIndex = 7;
            // 
            // lblCustomersTitle
            // 
            this.lblCustomersTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCustomersTitle.Name = "lblCustomersTitle";
            this.lblCustomersTitle.Size = new System.Drawing.Size(210, 30);
            this.lblCustomersTitle.ForeColor = System.Drawing.Color.White;
            this.lblCustomersTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustomersTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblCustomersTitle.TabIndex = 8;
            this.lblCustomersTitle.Text = "Customers";
            // 
            // lblCustomersValue
            // 
            this.lblCustomersValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCustomersValue.Name = "lblCustomersValue";
            this.lblCustomersValue.Size = new System.Drawing.Size(210, 60);
            this.lblCustomersValue.ForeColor = System.Drawing.Color.White;
            this.lblCustomersValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCustomersValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCustomersValue.TabIndex = 9;
            this.lblCustomersValue.Text = "0";
            // 
            // pnlCardPending
            // 
            this.pnlCardPending.Name = "pnlCardPending";
            this.pnlCardPending.Size = new System.Drawing.Size(210, 96);
            this.pnlCardPending.BackColor = System.Drawing.Color.FromArgb(239, 108, 0);
            this.pnlCardPending.Margin = new System.Windows.Forms.Padding(8);
            this.pnlCardPending.TabIndex = 10;
            // 
            // lblPendingTitle
            // 
            this.lblPendingTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPendingTitle.Name = "lblPendingTitle";
            this.lblPendingTitle.Size = new System.Drawing.Size(210, 30);
            this.lblPendingTitle.ForeColor = System.Drawing.Color.White;
            this.lblPendingTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPendingTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblPendingTitle.TabIndex = 11;
            this.lblPendingTitle.Text = "Pending orders";
            // 
            // lblPendingValue
            // 
            this.lblPendingValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPendingValue.Name = "lblPendingValue";
            this.lblPendingValue.Size = new System.Drawing.Size(210, 60);
            this.lblPendingValue.ForeColor = System.Drawing.Color.White;
            this.lblPendingValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPendingValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPendingValue.TabIndex = 12;
            this.lblPendingValue.Text = "0";
            // 
            // pnlCardLow
            // 
            this.pnlCardLow.Name = "pnlCardLow";
            this.pnlCardLow.Size = new System.Drawing.Size(210, 96);
            this.pnlCardLow.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.pnlCardLow.Margin = new System.Windows.Forms.Padding(8);
            this.pnlCardLow.TabIndex = 13;
            // 
            // lblLowTitle
            // 
            this.lblLowTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLowTitle.Name = "lblLowTitle";
            this.lblLowTitle.Size = new System.Drawing.Size(210, 30);
            this.lblLowTitle.ForeColor = System.Drawing.Color.White;
            this.lblLowTitle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLowTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblLowTitle.TabIndex = 14;
            this.lblLowTitle.Text = "Low-stock items";
            // 
            // lblLowValue
            // 
            this.lblLowValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLowValue.Name = "lblLowValue";
            this.lblLowValue.Size = new System.Drawing.Size(210, 60);
            this.lblLowValue.ForeColor = System.Drawing.Color.White;
            this.lblLowValue.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLowValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLowValue.TabIndex = 15;
            this.lblLowValue.Text = "0";
            // 
            // pnlLowHeader
            // 
            this.pnlLowHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLowHeader.Name = "pnlLowHeader";
            this.pnlLowHeader.Size = new System.Drawing.Size(300, 44);
            this.pnlLowHeader.TabIndex = 16;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(110, 44);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new EventHandler(this.btnRefresh_Click);
            // 
            // lblLowHdr
            // 
            this.lblLowHdr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLowHdr.Name = "lblLowHdr";
            this.lblLowHdr.Size = new System.Drawing.Size(300, 44);
            this.lblLowHdr.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLowHdr.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblLowHdr.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.lblLowHdr.TabIndex = 18;
            this.lblLowHdr.Text = "Low-stock alert: products at or below their alert level";
            // 
            // gridLow
            // 
            this.gridLow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridLow.Name = "gridLow";
            this.gridLow.Size = new System.Drawing.Size(300, 200);
            this.gridLow.AllowUserToAddRows = false;
            this.gridLow.AllowUserToDeleteRows = false;
            this.gridLow.AllowUserToResizeRows = false;
            this.gridLow.ReadOnly = true;
            this.gridLow.MultiSelect = false;
            this.gridLow.RowHeadersVisible = false;
            this.gridLow.BackgroundColor = System.Drawing.Color.White;
            this.gridLow.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridLow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridLow.TabIndex = 19;
            // 
            // pnlCards (children)
            // 
            this.pnlCards.Controls.Add(this.pnlCardSales);
            this.pnlCards.Controls.Add(this.pnlCardOrders);
            this.pnlCards.Controls.Add(this.pnlCardCustomers);
            this.pnlCards.Controls.Add(this.pnlCardPending);
            this.pnlCards.Controls.Add(this.pnlCardLow);
            // 
            // pnlCardSales (children)
            // 
            this.pnlCardSales.Controls.Add(this.lblSalesValue);
            this.pnlCardSales.Controls.Add(this.lblSalesTitle);
            // 
            // pnlCardOrders (children)
            // 
            this.pnlCardOrders.Controls.Add(this.lblOrdersValue);
            this.pnlCardOrders.Controls.Add(this.lblOrdersTitle);
            // 
            // pnlCardCustomers (children)
            // 
            this.pnlCardCustomers.Controls.Add(this.lblCustomersValue);
            this.pnlCardCustomers.Controls.Add(this.lblCustomersTitle);
            // 
            // pnlCardPending (children)
            // 
            this.pnlCardPending.Controls.Add(this.lblPendingValue);
            this.pnlCardPending.Controls.Add(this.lblPendingTitle);
            // 
            // pnlCardLow (children)
            // 
            this.pnlCardLow.Controls.Add(this.lblLowValue);
            this.pnlCardLow.Controls.Add(this.lblLowTitle);
            // 
            // pnlLowHeader (children)
            // 
            this.pnlLowHeader.Controls.Add(this.lblLowHdr);
            this.pnlLowHeader.Controls.Add(this.btnRefresh);
            // 
            // DashboardControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.gridLow);
            this.Controls.Add(this.pnlLowHeader);
            this.Controls.Add(this.pnlCards);
            this.Name = "DashboardControl";
            this.Load += new EventHandler(this.DashboardControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLow)).EndInit();
            this.pnlCards.ResumeLayout(false);
            this.pnlCards.PerformLayout();
            this.pnlCardSales.ResumeLayout(false);
            this.pnlCardSales.PerformLayout();
            this.pnlCardOrders.ResumeLayout(false);
            this.pnlCardOrders.PerformLayout();
            this.pnlCardCustomers.ResumeLayout(false);
            this.pnlCardCustomers.PerformLayout();
            this.pnlCardPending.ResumeLayout(false);
            this.pnlCardPending.PerformLayout();
            this.pnlCardLow.ResumeLayout(false);
            this.pnlCardLow.PerformLayout();
            this.pnlLowHeader.ResumeLayout(false);
            this.pnlLowHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlCards;
        private System.Windows.Forms.Panel pnlCardSales;
        private System.Windows.Forms.Label lblSalesTitle;
        private System.Windows.Forms.Label lblSalesValue;
        private System.Windows.Forms.Panel pnlCardOrders;
        private System.Windows.Forms.Label lblOrdersTitle;
        private System.Windows.Forms.Label lblOrdersValue;
        private System.Windows.Forms.Panel pnlCardCustomers;
        private System.Windows.Forms.Label lblCustomersTitle;
        private System.Windows.Forms.Label lblCustomersValue;
        private System.Windows.Forms.Panel pnlCardPending;
        private System.Windows.Forms.Label lblPendingTitle;
        private System.Windows.Forms.Label lblPendingValue;
        private System.Windows.Forms.Panel pnlCardLow;
        private System.Windows.Forms.Label lblLowTitle;
        private System.Windows.Forms.Label lblLowValue;
        private System.Windows.Forms.Panel pnlLowHeader;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblLowHdr;
        private System.Windows.Forms.DataGridView gridLow;
    }
}
