namespace OnlineShoppingSystem.Views
{
    partial class OrdersControl
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
            this.pnlActions = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.gridOrders = new System.Windows.Forms.DataGridView();
            this.pnlReview = new System.Windows.Forms.Panel();
            this.lblReviewHdr = new System.Windows.Forms.Label();
            this.lblSelItem = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            this.lblComment = new System.Windows.Forms.Label();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.btnSubmitReview = new System.Windows.Forms.Button();
            this.gridItems = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
            this.pnlActions.SuspendLayout();
            this.pnlReview.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlActions
            // 
            this.pnlActions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlActions.Name = "pnlActions";
            this.pnlActions.Size = new System.Drawing.Size(300, 40);
            this.pnlActions.AutoSize = true;
            this.pnlActions.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlActions.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pnlActions.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new EventHandler(this.btnRefresh_Click);
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(110, 30);
            this.btnCancelOrder.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnCancelOrder.ForeColor = System.Drawing.Color.White;
            this.btnCancelOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelOrder.FlatAppearance.BorderSize = 0;
            this.btnCancelOrder.TabIndex = 2;
            this.btnCancelOrder.Text = "Cancel order";
            this.btnCancelOrder.Click += new EventHandler(this.btnCancelOrder_Click);
            // 
            // btnInvoice
            // 
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(110, 30);
            this.btnInvoice.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnInvoice.ForeColor = System.Drawing.Color.White;
            this.btnInvoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInvoice.FlatAppearance.BorderSize = 0;
            this.btnInvoice.TabIndex = 3;
            this.btnInvoice.Text = "View invoice";
            this.btnInvoice.Click += new EventHandler(this.btnInvoice_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(170, 30);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "Request return / refund";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new EventHandler(this.btnReturn_Click);
            // 
            // gridOrders
            // 
            this.gridOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridOrders.Name = "gridOrders";
            this.gridOrders.Size = new System.Drawing.Size(300, 230);
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
            this.gridOrders.TabIndex = 5;
            this.gridOrders.SelectionChanged += new EventHandler(this.gridOrders_SelectionChanged);
            // 
            // pnlReview
            // 
            this.pnlReview.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlReview.Name = "pnlReview";
            this.pnlReview.Size = new System.Drawing.Size(300, 100);
            this.pnlReview.BackColor = System.Drawing.Color.White;
            this.pnlReview.TabIndex = 6;
            // 
            // lblReviewHdr
            // 
            this.lblReviewHdr.AutoSize = true;
            this.lblReviewHdr.Location = new System.Drawing.Point(14, 14);
            this.lblReviewHdr.Name = "lblReviewHdr";
            this.lblReviewHdr.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReviewHdr.TabIndex = 7;
            this.lblReviewHdr.Text = "Rate && review a delivered item";
            // 
            // lblSelItem
            // 
            this.lblSelItem.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.lblSelItem.Location = new System.Drawing.Point(14, 42);
            this.lblSelItem.Name = "lblSelItem";
            this.lblSelItem.Size = new System.Drawing.Size(270, 36);
            this.lblSelItem.ForeColor = System.Drawing.Color.Gray;
            this.lblSelItem.TabIndex = 8;
            this.lblSelItem.Text = "Select an item in the list.";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(14, 86);
            this.lblRating.Name = "lblRating";
            this.lblRating.TabIndex = 9;
            this.lblRating.Text = "Rating (1-5 stars)";
            // 
            // nudRating
            // 
            this.nudRating.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.nudRating.Location = new System.Drawing.Point(14, 106);
            this.nudRating.Name = "nudRating";
            this.nudRating.Size = new System.Drawing.Size(80, 23);
            this.nudRating.Maximum = new decimal(new int[] {5, 0, 0, 0});
            this.nudRating.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.nudRating.Value = new decimal(new int[] {5, 0, 0, 0});
            this.nudRating.TabIndex = 10;
            // 
            // lblComment
            // 
            this.lblComment.AutoSize = true;
            this.lblComment.Location = new System.Drawing.Point(14, 142);
            this.lblComment.Name = "lblComment";
            this.lblComment.TabIndex = 11;
            this.lblComment.Text = "Comment";
            // 
            // txtComment
            // 
            this.txtComment.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtComment.Location = new System.Drawing.Point(14, 162);
            this.txtComment.Name = "txtComment";
            this.txtComment.Size = new System.Drawing.Size(270, 100);
            this.txtComment.Multiline = true;
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComment.TabIndex = 12;
            // 
            // btnSubmitReview
            // 
            this.btnSubmitReview.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnSubmitReview.Location = new System.Drawing.Point(14, 274);
            this.btnSubmitReview.Name = "btnSubmitReview";
            this.btnSubmitReview.Size = new System.Drawing.Size(270, 36);
            this.btnSubmitReview.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnSubmitReview.ForeColor = System.Drawing.Color.White;
            this.btnSubmitReview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmitReview.FlatAppearance.BorderSize = 0;
            this.btnSubmitReview.TabIndex = 13;
            this.btnSubmitReview.Text = "Submit review";
            this.btnSubmitReview.Click += new EventHandler(this.btnSubmitReview_Click);
            // 
            // gridItems
            // 
            this.gridItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridItems.Name = "gridItems";
            this.gridItems.Size = new System.Drawing.Size(300, 200);
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
            this.gridItems.TabIndex = 14;
            this.gridItems.SelectionChanged += new EventHandler(this.gridItems_SelectionChanged);
            // 
            // pnlActions (children)
            // 
            this.pnlActions.Controls.Add(this.btnRefresh);
            this.pnlActions.Controls.Add(this.btnCancelOrder);
            this.pnlActions.Controls.Add(this.btnInvoice);
            this.pnlActions.Controls.Add(this.btnReturn);
            // 
            // pnlReview (children)
            // 
            this.pnlReview.Controls.Add(this.lblReviewHdr);
            this.pnlReview.Controls.Add(this.lblSelItem);
            this.pnlReview.Controls.Add(this.lblRating);
            this.pnlReview.Controls.Add(this.nudRating);
            this.pnlReview.Controls.Add(this.lblComment);
            this.pnlReview.Controls.Add(this.txtComment);
            this.pnlReview.Controls.Add(this.btnSubmitReview);
            // 
            // OrdersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.gridItems);
            this.Controls.Add(this.pnlReview);
            this.Controls.Add(this.gridOrders);
            this.Controls.Add(this.pnlActions);
            this.Name = "OrdersControl";
            this.Load += new EventHandler(this.OrdersControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            this.pnlReview.ResumeLayout(false);
            this.pnlReview.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlActions;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.DataGridView gridOrders;
        private System.Windows.Forms.Panel pnlReview;
        private System.Windows.Forms.Label lblReviewHdr;
        private System.Windows.Forms.Label lblSelItem;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.NumericUpDown nudRating;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnSubmitReview;
        private System.Windows.Forms.DataGridView gridItems;
    }
}
