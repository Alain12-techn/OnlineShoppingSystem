namespace OnlineShoppingSystem.Views
{
    partial class WishlistControl
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
            this.btnMoveToCart = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.gridWishlist = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridWishlist)).BeginInit();
            this.pnlActions.SuspendLayout();
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
            // btnMoveToCart
            // 
            this.btnMoveToCart.Name = "btnMoveToCart";
            this.btnMoveToCart.Size = new System.Drawing.Size(110, 30);
            this.btnMoveToCart.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnMoveToCart.ForeColor = System.Drawing.Color.White;
            this.btnMoveToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveToCart.FlatAppearance.BorderSize = 0;
            this.btnMoveToCart.TabIndex = 2;
            this.btnMoveToCart.Text = "Move to cart";
            this.btnMoveToCart.Click += new EventHandler(this.btnMoveToCart_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(90, 30);
            this.btnRemove.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.FlatAppearance.BorderSize = 0;
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Remove";
            this.btnRemove.Click += new EventHandler(this.btnRemove_Click);
            // 
            // gridWishlist
            // 
            this.gridWishlist.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridWishlist.Name = "gridWishlist";
            this.gridWishlist.Size = new System.Drawing.Size(300, 200);
            this.gridWishlist.AllowUserToAddRows = false;
            this.gridWishlist.AllowUserToDeleteRows = false;
            this.gridWishlist.AllowUserToResizeRows = false;
            this.gridWishlist.ReadOnly = true;
            this.gridWishlist.MultiSelect = false;
            this.gridWishlist.RowHeadersVisible = false;
            this.gridWishlist.BackgroundColor = System.Drawing.Color.White;
            this.gridWishlist.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridWishlist.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridWishlist.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridWishlist.TabIndex = 4;
            // 
            // pnlActions (children)
            // 
            this.pnlActions.Controls.Add(this.btnRefresh);
            this.pnlActions.Controls.Add(this.btnMoveToCart);
            this.pnlActions.Controls.Add(this.btnRemove);
            // 
            // WishlistControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.gridWishlist);
            this.Controls.Add(this.pnlActions);
            this.Name = "WishlistControl";
            this.Load += new EventHandler(this.WishlistControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridWishlist)).EndInit();
            this.pnlActions.ResumeLayout(false);
            this.pnlActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlActions;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnMoveToCart;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView gridWishlist;
    }
}
