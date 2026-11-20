namespace OnlineShoppingSystem.Views
{
    partial class OrdersAdminControl
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
            this.pnlFilter = new System.Windows.Forms.FlowLayoutPanel();
            this.lblStatusFilter = new System.Windows.Forms.Label();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlRight = new System.Windows.Forms.Panel();
            this.lblSelected = new System.Windows.Forms.Label();
            this.lblNewStatus = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.btnUpdateStatus = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.lblReturnHdr = new System.Windows.Forms.Label();
            this.lblReturnState = new System.Windows.Forms.Label();
            this.btnApproveReturn = new System.Windows.Forms.Button();
            this.btnRejectReturn = new System.Windows.Forms.Button();
            this.gridItems = new System.Windows.Forms.DataGridView();
            this.gridOrders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            this.pnlFilter.SuspendLayout();
            this.pnlRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFilter
            // 
            this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilter.Name = "pnlFilter";
            this.pnlFilter.Size = new System.Drawing.Size(300, 40);
            this.pnlFilter.AutoSize = true;
            this.pnlFilter.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFilter.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pnlFilter.TabIndex = 0;
            // 
            // lblStatusFilter
            // 
            this.lblStatusFilter.AutoSize = true;
            this.lblStatusFilter.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblStatusFilter.Name = "lblStatusFilter";
            this.lblStatusFilter.TabIndex = 1;
            this.lblStatusFilter.Text = "Status";
            // 
            // cboFilter
            // 
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(130, 23);
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.TabIndex = 2;
            this.cboFilter.SelectedIndexChanged += new EventHandler(this.cboFilter_SelectedIndexChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.TabIndex = 3;
            this.lblSearch.Text = "Search (order #, customer)";
            // 
            // txtSearch
            // 
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(200, 23);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new EventHandler(this.txtSearch_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new EventHandler(this.btnRefresh_Click);
            // 
            // pnlRight
            // 
            this.pnlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlRight.Name = "pnlRight";
            this.pnlRight.Size = new System.Drawing.Size(300, 100);
            this.pnlRight.AutoScroll = true;
            this.pnlRight.BackColor = System.Drawing.Color.White;
            this.pnlRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlRight.TabIndex = 6;
            // 
            // lblSelected
            // 
            this.lblSelected.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.lblSelected.Location = new System.Drawing.Point(14, 14);
            this.lblSelected.Name = "lblSelected";
            this.lblSelected.Size = new System.Drawing.Size(270, 84);
            this.lblSelected.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSelected.TabIndex = 7;
            this.lblSelected.Text = "Select an order.";
            // 
            // lblNewStatus
            // 
            this.lblNewStatus.AutoSize = true;
            this.lblNewStatus.Location = new System.Drawing.Point(14, 108);
            this.lblNewStatus.Name = "lblNewStatus";
            this.lblNewStatus.TabIndex = 8;
            this.lblNewStatus.Text = "Set order status";
            // 
            // cboStatus
            // 
            this.cboStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboStatus.Location = new System.Drawing.Point(14, 128);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(270, 23);
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.TabIndex = 9;
            // 
            // btnUpdateStatus
            // 
            this.btnUpdateStatus.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnUpdateStatus.Location = new System.Drawing.Point(14, 162);
            this.btnUpdateStatus.Name = "btnUpdateStatus";
            this.btnUpdateStatus.Size = new System.Drawing.Size(270, 36);
            this.btnUpdateStatus.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnUpdateStatus.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStatus.FlatAppearance.BorderSize = 0;
            this.btnUpdateStatus.TabIndex = 10;
            this.btnUpdateStatus.Text = "Update status";
            this.btnUpdateStatus.Click += new EventHandler(this.btnUpdateStatus_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnInvoice.Location = new System.Drawing.Point(14, 206);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(270, 32);
            this.btnInvoice.TabIndex = 11;
            this.btnInvoice.Text = "View invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new EventHandler(this.btnInvoice_Click);
            // 
            // lblReturnHdr
            // 
            this.lblReturnHdr.AutoSize = true;
            this.lblReturnHdr.Location = new System.Drawing.Point(14, 262);
            this.lblReturnHdr.Name = "lblReturnHdr";
            this.lblReturnHdr.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReturnHdr.TabIndex = 12;
            this.lblReturnHdr.Text = "Return / refund request";
            // 
            // lblReturnState
            // 
            this.lblReturnState.AutoSize = true;
            this.lblReturnState.Location = new System.Drawing.Point(14, 286);
            this.lblReturnState.Name = "lblReturnState";
            this.lblReturnState.ForeColor = System.Drawing.Color.Gray;
            this.lblReturnState.TabIndex = 13;
            this.lblReturnState.Text = "None";
            // 
            // btnApproveReturn
            // 
            this.btnApproveReturn.Location = new System.Drawing.Point(14, 312);
            this.btnApproveReturn.Name = "btnApproveReturn";
            this.btnApproveReturn.Size = new System.Drawing.Size(130, 32);
            this.btnApproveReturn.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnApproveReturn.ForeColor = System.Drawing.Color.White;
            this.btnApproveReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApproveReturn.FlatAppearance.BorderSize = 0;
            this.btnApproveReturn.TabIndex = 14;
            this.btnApproveReturn.Text = "Approve";
            this.btnApproveReturn.Click += new EventHandler(this.btnApproveReturn_Click);
            // 
            // btnRejectReturn
            // 
            this.btnRejectReturn.Location = new System.Drawing.Point(154, 312);
            this.btnRejectReturn.Name = "btnRejectReturn";
            this.btnRejectReturn.Size = new System.Drawing.Size(130, 32);
            this.btnRejectReturn.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnRejectReturn.ForeColor = System.Drawing.Color.White;
            this.btnRejectReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRejectReturn.FlatAppearance.BorderSize = 0;
            this.btnRejectReturn.TabIndex = 15;
            this.btnRejectReturn.Text = "Reject";
            this.btnRejectReturn.Click += new EventHandler(this.btnRejectReturn_Click);
            // 
            // gridItems
            // 
            this.gridItems.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridItems.Name = "gridItems";
            this.gridItems.Size = new System.Drawing.Size(300, 170);
            this.gridItems.AllowUserToAddRows = false;
            this.gridItems.AllowUserToDeleteRows = false;
            this.gridItems.AllowUserToResizeRows = false;
            this.gridItems.ReadOnly = true;
            this.gridItems.MultiSelect = false;
            this.gridItems.RowHeadersVisible = false;
            this.gridItems.BackgroundColor = System.Drawing.Color.White;
            this.gridItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridItems.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridItems.TabIndex = 16;
            // 
            // gridOrders
            // 
            this.gridOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.Size = new System.Drawing.Size(300, 200);
            this.gridOrders.AllowUserToAddRows = false;
            this.gridOrders.AllowUserToDeleteRows = false;
            this.gridOrders.AllowUserToResizeRows = false;
            this.gridOrders.ReadOnly = true;
            this.gridOrders.MultiSelect = false;
            this.gridOrders.RowHeadersVisible = false;
            this.gridOrders.BackgroundColor = System.Drawing.Color.White;
            this.gridOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridOrders.TabIndex = 17;
            this.gridOrders.SelectionChanged += new EventHandler(this.gridOrders_SelectionChanged);
            // 
            // pnlFilter (children)
            // 
            this.pnlFilter.Controls.Add(this.lblStatusFilter);
            this.pnlFilter.Controls.Add(this.cboFilter);
            this.pnlFilter.Controls.Add(this.lblSearch);
            this.pnlFilter.Controls.Add(this.txtSearch);
            this.pnlFilter.Controls.Add(this.btnRefresh);
            // 
            // pnlRight (children)
            // 
            this.pnlRight.Controls.Add(this.lblSelected);
            this.pnlRight.Controls.Add(this.lblNewStatus);
            this.pnlRight.Controls.Add(this.cboStatus);
            this.pnlRight.Controls.Add(this.btnUpdateStatus);
            this.pnlRight.Controls.Add(this.btnInvoice);
            this.pnlRight.Controls.Add(this.lblReturnHdr);
            this.pnlRight.Controls.Add(this.lblReturnState);
            this.pnlRight.Controls.Add(this.btnApproveReturn);
            this.pnlRight.Controls.Add(this.btnRejectReturn);
            // 
            // OrdersAdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.gridOrders);
            this.Controls.Add(this.gridItems);
            this.Controls.Add(this.pnlRight);
            this.Controls.Add(this.pnlFilter);
            this.Name = "OrdersAdminControl";
            this.Load += new EventHandler(this.OrdersAdminControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            this.pnlFilter.ResumeLayout(false);
            this.pnlFilter.PerformLayout();
            this.pnlRight.ResumeLayout(false);
            this.pnlRight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlFilter;
        private System.Windows.Forms.Label lblStatusFilter;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlRight;
        private System.Windows.Forms.Label lblSelected;
        private System.Windows.Forms.Label lblNewStatus;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Button btnUpdateStatus;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Label lblReturnHdr;
        private System.Windows.Forms.Label lblReturnState;
        private System.Windows.Forms.Button btnApproveReturn;
        private System.Windows.Forms.Button btnRejectReturn;
        private System.Windows.Forms.DataGridView gridItems;
        private System.Windows.Forms.DataGridView gridOrders;
    }
}
