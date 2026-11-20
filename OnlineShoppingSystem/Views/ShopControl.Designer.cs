namespace OnlineShoppingSystem.Views
{
    partial class ShopControl
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
            this.pnlFilters = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.lblMin = new System.Windows.Forms.Label();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.lblMax = new System.Windows.Forms.Label();
            this.nudMax = new System.Windows.Forms.NumericUpDown();
            this.lblRating = new System.Windows.Forms.Label();
            this.cboRating = new System.Windows.Forms.ComboBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.cboSort = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.picDetails = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblReviewsHdr = new System.Windows.Forms.Label();
            this.pnlBuy = new System.Windows.Forms.Panel();
            this.lblQty = new System.Windows.Forms.Label();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.btnWishlist = new System.Windows.Forms.Button();
            this.txtReviews = new System.Windows.Forms.TextBox();
            this.gridProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            this.pnlFilters.SuspendLayout();
            this.pnlDetails.SuspendLayout();
            this.pnlBuy.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFilters
            // 
            this.pnlFilters.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(300, 40);
            this.pnlFilters.AutoSize = true;
            this.pnlFilters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlFilters.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pnlFilters.TabIndex = 0;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(170, 23);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category";
            // 
            // cboCategory
            // 
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(140, 23);
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.TabIndex = 4;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.TabIndex = 5;
            this.lblBrand.Text = "Brand";
            // 
            // cboBrand
            // 
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(120, 23);
            this.cboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.TabIndex = 6;
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblMin.Name = "lblMin";
            this.lblMin.TabIndex = 7;
            this.lblMin.Text = "Min price";
            // 
            // nudMin
            // 
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(80, 23);
            this.nudMin.Maximum = new decimal(new int[] {10000000, 0, 0, 0});
            this.nudMin.DecimalPlaces = 2;
            this.nudMin.TabIndex = 8;
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblMax.Name = "lblMax";
            this.lblMax.TabIndex = 9;
            this.lblMax.Text = "Max (0 = any)";
            // 
            // nudMax
            // 
            this.nudMax.Name = "nudMax";
            this.nudMax.Size = new System.Drawing.Size(80, 23);
            this.nudMax.Maximum = new decimal(new int[] {10000000, 0, 0, 0});
            this.nudMax.DecimalPlaces = 2;
            this.nudMax.TabIndex = 10;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblRating.Name = "lblRating";
            this.lblRating.TabIndex = 11;
            this.lblRating.Text = "Rating";
            // 
            // cboRating
            // 
            this.cboRating.Name = "cboRating";
            this.cboRating.Size = new System.Drawing.Size(100, 23);
            this.cboRating.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboRating.FormattingEnabled = true;
            this.cboRating.TabIndex = 12;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblSort.Name = "lblSort";
            this.lblSort.TabIndex = 13;
            this.lblSort.Text = "Sort by";
            // 
            // cboSort
            // 
            this.cboSort.Name = "cboSort";
            this.cboSort.Size = new System.Drawing.Size(140, 23);
            this.cboSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSort.FormattingEnabled = true;
            this.cboSort.TabIndex = 14;
            // 
            // btnSearch
            // 
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 30);
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.Click += new EventHandler(this.btnSearch_Click);
            // 
            // btnReset
            // 
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 30);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new EventHandler(this.btnReset_Click);
            // 
            // pnlDetails
            // 
            this.pnlDetails.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(340, 100);
            this.pnlDetails.BackColor = System.Drawing.Color.White;
            this.pnlDetails.TabIndex = 17;
            // 
            // picDetails
            // 
            this.picDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.picDetails.Name = "picDetails";
            this.picDetails.Size = new System.Drawing.Size(340, 190);
            this.picDetails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDetails.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.picDetails.TabIndex = 18;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(340, 34);
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Padding = new System.Windows.Forms.Padding(8, 8, 8, 0);
            this.lblName.TabIndex = 19;
            this.lblName.Text = "";
            // 
            // lblInfo
            // 
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(340, 62);
            this.lblInfo.Padding = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.lblInfo.TabIndex = 20;
            this.lblInfo.Text = "";
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(340, 84);
            this.txtDescription.ReadOnly = true;
            this.txtDescription.BackColor = System.Drawing.Color.White;
            this.txtDescription.Multiline = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.TabIndex = 21;
            // 
            // lblReviewsHdr
            // 
            this.lblReviewsHdr.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblReviewsHdr.Name = "lblReviewsHdr";
            this.lblReviewsHdr.Size = new System.Drawing.Size(340, 24);
            this.lblReviewsHdr.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblReviewsHdr.Padding = new System.Windows.Forms.Padding(8, 4, 0, 0);
            this.lblReviewsHdr.TabIndex = 22;
            this.lblReviewsHdr.Text = "Customer reviews";
            // 
            // pnlBuy
            // 
            this.pnlBuy.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBuy.Name = "pnlBuy";
            this.pnlBuy.Size = new System.Drawing.Size(340, 100);
            this.pnlBuy.TabIndex = 23;
            // 
            // lblQty
            // 
            this.lblQty.AutoSize = true;
            this.lblQty.Location = new System.Drawing.Point(10, 15);
            this.lblQty.Name = "lblQty";
            this.lblQty.TabIndex = 24;
            this.lblQty.Text = "Quantity";
            // 
            // nudQty
            // 
            this.nudQty.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.nudQty.Location = new System.Drawing.Point(80, 11);
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(70, 23);
            this.nudQty.Maximum = new decimal(new int[] {100, 0, 0, 0});
            this.nudQty.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.nudQty.Value = new decimal(new int[] {1, 0, 0, 0});
            this.nudQty.TabIndex = 25;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.Location = new System.Drawing.Point(10, 50);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(150, 36);
            this.btnAddToCart.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnAddToCart.ForeColor = System.Drawing.Color.White;
            this.btnAddToCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToCart.FlatAppearance.BorderSize = 0;
            this.btnAddToCart.TabIndex = 26;
            this.btnAddToCart.Text = "Add to cart";
            this.btnAddToCart.Click += new EventHandler(this.btnAddToCart_Click);
            // 
            // btnWishlist
            // 
            this.btnWishlist.Location = new System.Drawing.Point(170, 50);
            this.btnWishlist.Name = "btnWishlist";
            this.btnWishlist.Size = new System.Drawing.Size(150, 36);
            this.btnWishlist.TabIndex = 27;
            this.btnWishlist.Text = "Add to wishlist";
            this.btnWishlist.UseVisualStyleBackColor = true;
            this.btnWishlist.Click += new EventHandler(this.btnWishlist_Click);
            // 
            // txtReviews
            // 
            this.txtReviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtReviews.Name = "txtReviews";
            this.txtReviews.Size = new System.Drawing.Size(340, 100);
            this.txtReviews.ReadOnly = true;
            this.txtReviews.BackColor = System.Drawing.Color.White;
            this.txtReviews.Multiline = true;
            this.txtReviews.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtReviews.TabIndex = 28;
            // 
            // gridProducts
            // 
            this.gridProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridProducts.Name = "gridProducts";
            this.gridProducts.Size = new System.Drawing.Size(300, 200);
            this.gridProducts.AllowUserToAddRows = false;
            this.gridProducts.AllowUserToDeleteRows = false;
            this.gridProducts.AllowUserToResizeRows = false;
            this.gridProducts.ReadOnly = true;
            this.gridProducts.MultiSelect = false;
            this.gridProducts.RowHeadersVisible = false;
            this.gridProducts.BackgroundColor = System.Drawing.Color.White;
            this.gridProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridProducts.TabIndex = 29;
            this.gridProducts.SelectionChanged += new EventHandler(this.gridProducts_SelectionChanged);
            // 
            // pnlFilters (children)
            // 
            this.pnlFilters.Controls.Add(this.lblSearch);
            this.pnlFilters.Controls.Add(this.txtSearch);
            this.pnlFilters.Controls.Add(this.lblCategory);
            this.pnlFilters.Controls.Add(this.cboCategory);
            this.pnlFilters.Controls.Add(this.lblBrand);
            this.pnlFilters.Controls.Add(this.cboBrand);
            this.pnlFilters.Controls.Add(this.lblMin);
            this.pnlFilters.Controls.Add(this.nudMin);
            this.pnlFilters.Controls.Add(this.lblMax);
            this.pnlFilters.Controls.Add(this.nudMax);
            this.pnlFilters.Controls.Add(this.lblRating);
            this.pnlFilters.Controls.Add(this.cboRating);
            this.pnlFilters.Controls.Add(this.lblSort);
            this.pnlFilters.Controls.Add(this.cboSort);
            this.pnlFilters.Controls.Add(this.btnSearch);
            this.pnlFilters.Controls.Add(this.btnReset);
            // 
            // pnlDetails (children)
            // 
            this.pnlDetails.Controls.Add(this.txtReviews);
            this.pnlDetails.Controls.Add(this.pnlBuy);
            this.pnlDetails.Controls.Add(this.lblReviewsHdr);
            this.pnlDetails.Controls.Add(this.txtDescription);
            this.pnlDetails.Controls.Add(this.lblInfo);
            this.pnlDetails.Controls.Add(this.lblName);
            this.pnlDetails.Controls.Add(this.picDetails);
            // 
            // pnlBuy (children)
            // 
            this.pnlBuy.Controls.Add(this.lblQty);
            this.pnlBuy.Controls.Add(this.nudQty);
            this.pnlBuy.Controls.Add(this.btnAddToCart);
            this.pnlBuy.Controls.Add(this.btnWishlist);
            // 
            // ShopControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.gridProducts);
            this.Controls.Add(this.pnlDetails);
            this.Controls.Add(this.pnlFilters);
            this.Name = "ShopControl";
            this.Load += new EventHandler(this.ShopControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            this.pnlBuy.ResumeLayout(false);
            this.pnlBuy.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlFilters;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.Label lblMax;
        private System.Windows.Forms.NumericUpDown nudMax;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.ComboBox cboRating;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.ComboBox cboSort;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlDetails;
        private System.Windows.Forms.PictureBox picDetails;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblReviewsHdr;
        private System.Windows.Forms.Panel pnlBuy;
        private System.Windows.Forms.Label lblQty;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Button btnAddToCart;
        private System.Windows.Forms.Button btnWishlist;
        private System.Windows.Forms.TextBox txtReviews;
        private System.Windows.Forms.DataGridView gridProducts;
    }
}
