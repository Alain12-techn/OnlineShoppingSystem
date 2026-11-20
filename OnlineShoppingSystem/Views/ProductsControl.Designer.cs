namespace OnlineShoppingSystem.Views
{
    partial class ProductsControl
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
            this.pnlSearch = new System.Windows.Forms.FlowLayoutPanel();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.chkLowStock = new System.Windows.Forms.CheckBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblSku = new System.Windows.Forms.Label();
            this.txtSku = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.nudPrice = new System.Windows.Forms.NumericUpDown();
            this.lblStock = new System.Windows.Forms.Label();
            this.nudStock = new System.Windows.Forms.NumericUpDown();
            this.lblLowLevel = new System.Windows.Forms.Label();
            this.nudLowLevel = new System.Windows.Forms.NumericUpDown();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cboBrand = new System.Windows.Forms.ComboBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblImage = new System.Windows.Forms.Label();
            this.txtImage = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.picPreview = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gridProducts = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).BeginInit();
            this.pnlSearch.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(300, 40);
            this.pnlSearch.AutoSize = true;
            this.pnlSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlSearch.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pnlSearch.TabIndex = 0;
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
            this.txtSearch.Size = new System.Drawing.Size(220, 23);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new EventHandler(this.txtSearch_TextChanged);
            // 
            // chkLowStock
            // 
            this.chkLowStock.Name = "chkLowStock";
            this.chkLowStock.Size = new System.Drawing.Size(130, 24);
            this.chkLowStock.TabIndex = 3;
            this.chkLowStock.Text = "Low stock only";
            this.chkLowStock.CheckedChanged += new EventHandler(this.chkLowStock_CheckedChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new EventHandler(this.btnRefresh_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(330, 100);
            this.pnlForm.AutoScroll = true;
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlForm.TabIndex = 5;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 10);
            this.lblName.Name = "lblName";
            this.lblName.TabIndex = 6;
            this.lblName.Text = "Product name";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtName.Location = new System.Drawing.Point(14, 30);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(290, 23);
            this.txtName.TabIndex = 7;
            // 
            // lblSku
            // 
            this.lblSku.AutoSize = true;
            this.lblSku.Location = new System.Drawing.Point(14, 61);
            this.lblSku.Name = "lblSku";
            this.lblSku.TabIndex = 8;
            this.lblSku.Text = "SKU (unique code)";
            // 
            // txtSku
            // 
            this.txtSku.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtSku.Location = new System.Drawing.Point(14, 81);
            this.txtSku.Name = "txtSku";
            this.txtSku.Size = new System.Drawing.Size(290, 23);
            this.txtSku.TabIndex = 9;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(14, 112);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.TabIndex = 10;
            this.lblPrice.Text = "Price";
            // 
            // nudPrice
            // 
            this.nudPrice.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.nudPrice.Location = new System.Drawing.Point(14, 132);
            this.nudPrice.Name = "nudPrice";
            this.nudPrice.Size = new System.Drawing.Size(290, 23);
            this.nudPrice.Maximum = new decimal(new int[] {100000000, 0, 0, 0});
            this.nudPrice.DecimalPlaces = 2;
            this.nudPrice.TabIndex = 11;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(14, 163);
            this.lblStock.Name = "lblStock";
            this.lblStock.TabIndex = 12;
            this.lblStock.Text = "Stock quantity";
            // 
            // nudStock
            // 
            this.nudStock.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.nudStock.Location = new System.Drawing.Point(14, 183);
            this.nudStock.Name = "nudStock";
            this.nudStock.Size = new System.Drawing.Size(290, 23);
            this.nudStock.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
            this.nudStock.TabIndex = 13;
            // 
            // lblLowLevel
            // 
            this.lblLowLevel.AutoSize = true;
            this.lblLowLevel.Location = new System.Drawing.Point(14, 214);
            this.lblLowLevel.Name = "lblLowLevel";
            this.lblLowLevel.TabIndex = 14;
            this.lblLowLevel.Text = "Low-stock alert level";
            // 
            // nudLowLevel
            // 
            this.nudLowLevel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.nudLowLevel.Location = new System.Drawing.Point(14, 234);
            this.nudLowLevel.Name = "nudLowLevel";
            this.nudLowLevel.Size = new System.Drawing.Size(290, 23);
            this.nudLowLevel.Maximum = new decimal(new int[] {1000000, 0, 0, 0});
            this.nudLowLevel.Value = new decimal(new int[] {5, 0, 0, 0});
            this.nudLowLevel.TabIndex = 15;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(14, 265);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.TabIndex = 16;
            this.lblCategory.Text = "Category";
            // 
            // cboCategory
            // 
            this.cboCategory.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboCategory.Location = new System.Drawing.Point(14, 285);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(290, 23);
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.TabIndex = 17;
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(14, 316);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.TabIndex = 18;
            this.lblBrand.Text = "Brand";
            // 
            // cboBrand
            // 
            this.cboBrand.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboBrand.Location = new System.Drawing.Point(14, 336);
            this.cboBrand.Name = "cboBrand";
            this.cboBrand.Size = new System.Drawing.Size(290, 23);
            this.cboBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBrand.FormattingEnabled = true;
            this.cboBrand.TabIndex = 19;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(14, 367);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.TabIndex = 20;
            this.lblDescription.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtDescription.Location = new System.Drawing.Point(14, 387);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(290, 70);
            this.txtDescription.Multiline = true;
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.TabIndex = 21;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(14, 465);
            this.lblImage.Name = "lblImage";
            this.lblImage.TabIndex = 22;
            this.lblImage.Text = "Image";
            // 
            // txtImage
            // 
            this.txtImage.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtImage.Location = new System.Drawing.Point(14, 485);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(200, 23);
            this.txtImage.ReadOnly = true;
            this.txtImage.TabIndex = 23;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnBrowse.Location = new System.Drawing.Point(222, 483);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(82, 27);
            this.btnBrowse.TabIndex = 24;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new EventHandler(this.btnBrowse_Click);
            // 
            // picPreview
            // 
            this.picPreview.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.picPreview.Location = new System.Drawing.Point(14, 517);
            this.picPreview.Name = "picPreview";
            this.picPreview.Size = new System.Drawing.Size(290, 90);
            this.picPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picPreview.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.picPreview.TabIndex = 25;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 619);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 32);
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(153, 619);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 32);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(14, 659);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 32);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.TabIndex = 28;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(153, 659);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 32);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new EventHandler(this.btnClear_Click);
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
            this.gridProducts.TabIndex = 30;
            this.gridProducts.SelectionChanged += new EventHandler(this.gridProducts_SelectionChanged);
            this.gridProducts.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.gridProducts_CellFormatting);
            // 
            // pnlSearch (children)
            // 
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.chkLowStock);
            this.pnlSearch.Controls.Add(this.btnRefresh);
            // 
            // pnlForm (children)
            // 
            this.pnlForm.Controls.Add(this.lblName);
            this.pnlForm.Controls.Add(this.txtName);
            this.pnlForm.Controls.Add(this.lblSku);
            this.pnlForm.Controls.Add(this.txtSku);
            this.pnlForm.Controls.Add(this.lblPrice);
            this.pnlForm.Controls.Add(this.nudPrice);
            this.pnlForm.Controls.Add(this.lblStock);
            this.pnlForm.Controls.Add(this.nudStock);
            this.pnlForm.Controls.Add(this.lblLowLevel);
            this.pnlForm.Controls.Add(this.nudLowLevel);
            this.pnlForm.Controls.Add(this.lblCategory);
            this.pnlForm.Controls.Add(this.cboCategory);
            this.pnlForm.Controls.Add(this.lblBrand);
            this.pnlForm.Controls.Add(this.cboBrand);
            this.pnlForm.Controls.Add(this.lblDescription);
            this.pnlForm.Controls.Add(this.txtDescription);
            this.pnlForm.Controls.Add(this.lblImage);
            this.pnlForm.Controls.Add(this.txtImage);
            this.pnlForm.Controls.Add(this.btnBrowse);
            this.pnlForm.Controls.Add(this.picPreview);
            this.pnlForm.Controls.Add(this.btnAdd);
            this.pnlForm.Controls.Add(this.btnUpdate);
            this.pnlForm.Controls.Add(this.btnDelete);
            this.pnlForm.Controls.Add(this.btnClear);
            // 
            // ProductsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.gridProducts);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlSearch);
            this.Name = "ProductsControl";
            this.Load += new EventHandler(this.ProductsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLowLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProducts)).EndInit();
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.CheckBox chkLowStock;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblSku;
        private System.Windows.Forms.TextBox txtSku;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown nudPrice;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown nudStock;
        private System.Windows.Forms.Label lblLowLevel;
        private System.Windows.Forms.NumericUpDown nudLowLevel;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.ComboBox cboBrand;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.TextBox txtImage;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox picPreview;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView gridProducts;
    }
}
