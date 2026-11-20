namespace OnlineShoppingSystem.Views
{
    partial class LookupControl
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
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabCategories = new System.Windows.Forms.TabPage();
            this.tabBrands = new System.Windows.Forms.TabPage();
            this.pnlCatForm = new System.Windows.Forms.Panel();
            this.lblCatName = new System.Windows.Forms.Label();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.lblCatParent = new System.Windows.Forms.Label();
            this.cboCatParent = new System.Windows.Forms.ComboBox();
            this.btnCatAdd = new System.Windows.Forms.Button();
            this.btnCatUpdate = new System.Windows.Forms.Button();
            this.btnCatDelete = new System.Windows.Forms.Button();
            this.btnCatClear = new System.Windows.Forms.Button();
            this.gridCategories = new System.Windows.Forms.DataGridView();
            this.pnlBrandForm = new System.Windows.Forms.Panel();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.txtBrandName = new System.Windows.Forms.TextBox();
            this.btnBrandAdd = new System.Windows.Forms.Button();
            this.btnBrandUpdate = new System.Windows.Forms.Button();
            this.btnBrandDelete = new System.Windows.Forms.Button();
            this.btnBrandClear = new System.Windows.Forms.Button();
            this.gridBrands = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBrands)).BeginInit();
            this.tabs.SuspendLayout();
            this.tabCategories.SuspendLayout();
            this.tabBrands.SuspendLayout();
            this.pnlCatForm.SuspendLayout();
            this.pnlBrandForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs
            // 
            this.tabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabs.Name = "tabs";
            this.tabs.Size = new System.Drawing.Size(300, 300);
            this.tabs.TabIndex = 0;
            // 
            // tabCategories
            // 
            this.tabCategories.Name = "tabCategories";
            this.tabCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tabCategories.TabIndex = 1;
            this.tabCategories.Text = "Categories";
            this.tabCategories.UseVisualStyleBackColor = true;
            // 
            // tabBrands
            // 
            this.tabBrands.Name = "tabBrands";
            this.tabBrands.Padding = new System.Windows.Forms.Padding(3);
            this.tabBrands.TabIndex = 2;
            this.tabBrands.Text = "Brands";
            this.tabBrands.UseVisualStyleBackColor = true;
            // 
            // pnlCatForm
            // 
            this.pnlCatForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCatForm.Name = "pnlCatForm";
            this.pnlCatForm.Size = new System.Drawing.Size(300, 100);
            this.pnlCatForm.AutoScroll = true;
            this.pnlCatForm.BackColor = System.Drawing.Color.White;
            this.pnlCatForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCatForm.TabIndex = 3;
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Location = new System.Drawing.Point(14, 14);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.TabIndex = 4;
            this.lblCatName.Text = "Category name";
            // 
            // txtCatName
            // 
            this.txtCatName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtCatName.Location = new System.Drawing.Point(14, 34);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(270, 23);
            this.txtCatName.TabIndex = 5;
            // 
            // lblCatParent
            // 
            this.lblCatParent.AutoSize = true;
            this.lblCatParent.Location = new System.Drawing.Point(14, 65);
            this.lblCatParent.Name = "lblCatParent";
            this.lblCatParent.TabIndex = 6;
            this.lblCatParent.Text = "Parent category (optional)";
            // 
            // cboCatParent
            // 
            this.cboCatParent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboCatParent.Location = new System.Drawing.Point(14, 85);
            this.cboCatParent.Name = "cboCatParent";
            this.cboCatParent.Size = new System.Drawing.Size(270, 23);
            this.cboCatParent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCatParent.FormattingEnabled = true;
            this.cboCatParent.TabIndex = 7;
            // 
            // btnCatAdd
            // 
            this.btnCatAdd.Location = new System.Drawing.Point(14, 122);
            this.btnCatAdd.Name = "btnCatAdd";
            this.btnCatAdd.Size = new System.Drawing.Size(131, 32);
            this.btnCatAdd.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnCatAdd.ForeColor = System.Drawing.Color.White;
            this.btnCatAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatAdd.FlatAppearance.BorderSize = 0;
            this.btnCatAdd.TabIndex = 8;
            this.btnCatAdd.Text = "Add";
            this.btnCatAdd.Click += new EventHandler(this.btnCatAdd_Click);
            // 
            // btnCatUpdate
            // 
            this.btnCatUpdate.Location = new System.Drawing.Point(153, 122);
            this.btnCatUpdate.Name = "btnCatUpdate";
            this.btnCatUpdate.Size = new System.Drawing.Size(131, 32);
            this.btnCatUpdate.TabIndex = 9;
            this.btnCatUpdate.Text = "Update";
            this.btnCatUpdate.UseVisualStyleBackColor = true;
            this.btnCatUpdate.Click += new EventHandler(this.btnCatUpdate_Click);
            // 
            // btnCatDelete
            // 
            this.btnCatDelete.Location = new System.Drawing.Point(14, 162);
            this.btnCatDelete.Name = "btnCatDelete";
            this.btnCatDelete.Size = new System.Drawing.Size(131, 32);
            this.btnCatDelete.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnCatDelete.ForeColor = System.Drawing.Color.White;
            this.btnCatDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCatDelete.FlatAppearance.BorderSize = 0;
            this.btnCatDelete.TabIndex = 10;
            this.btnCatDelete.Text = "Delete";
            this.btnCatDelete.Click += new EventHandler(this.btnCatDelete_Click);
            // 
            // btnCatClear
            // 
            this.btnCatClear.Location = new System.Drawing.Point(153, 162);
            this.btnCatClear.Name = "btnCatClear";
            this.btnCatClear.Size = new System.Drawing.Size(131, 32);
            this.btnCatClear.TabIndex = 11;
            this.btnCatClear.Text = "Clear";
            this.btnCatClear.UseVisualStyleBackColor = true;
            this.btnCatClear.Click += new EventHandler(this.btnCatClear_Click);
            // 
            // gridCategories
            // 
            this.gridCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCategories.Name = "gridCategories";
            this.gridCategories.Size = new System.Drawing.Size(300, 200);
            this.gridCategories.AllowUserToAddRows = false;
            this.gridCategories.AllowUserToDeleteRows = false;
            this.gridCategories.AllowUserToResizeRows = false;
            this.gridCategories.ReadOnly = true;
            this.gridCategories.MultiSelect = false;
            this.gridCategories.RowHeadersVisible = false;
            this.gridCategories.BackgroundColor = System.Drawing.Color.White;
            this.gridCategories.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCategories.TabIndex = 12;
            this.gridCategories.SelectionChanged += new EventHandler(this.gridCategories_SelectionChanged);
            // 
            // pnlBrandForm
            // 
            this.pnlBrandForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBrandForm.Name = "pnlBrandForm";
            this.pnlBrandForm.Size = new System.Drawing.Size(300, 100);
            this.pnlBrandForm.AutoScroll = true;
            this.pnlBrandForm.BackColor = System.Drawing.Color.White;
            this.pnlBrandForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBrandForm.TabIndex = 13;
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Location = new System.Drawing.Point(14, 14);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.TabIndex = 14;
            this.lblBrandName.Text = "Brand name";
            // 
            // txtBrandName
            // 
            this.txtBrandName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtBrandName.Location = new System.Drawing.Point(14, 34);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Size = new System.Drawing.Size(270, 23);
            this.txtBrandName.TabIndex = 15;
            // 
            // btnBrandAdd
            // 
            this.btnBrandAdd.Location = new System.Drawing.Point(14, 71);
            this.btnBrandAdd.Name = "btnBrandAdd";
            this.btnBrandAdd.Size = new System.Drawing.Size(131, 32);
            this.btnBrandAdd.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnBrandAdd.ForeColor = System.Drawing.Color.White;
            this.btnBrandAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrandAdd.FlatAppearance.BorderSize = 0;
            this.btnBrandAdd.TabIndex = 16;
            this.btnBrandAdd.Text = "Add";
            this.btnBrandAdd.Click += new EventHandler(this.btnBrandAdd_Click);
            // 
            // btnBrandUpdate
            // 
            this.btnBrandUpdate.Location = new System.Drawing.Point(153, 71);
            this.btnBrandUpdate.Name = "btnBrandUpdate";
            this.btnBrandUpdate.Size = new System.Drawing.Size(131, 32);
            this.btnBrandUpdate.TabIndex = 17;
            this.btnBrandUpdate.Text = "Update";
            this.btnBrandUpdate.UseVisualStyleBackColor = true;
            this.btnBrandUpdate.Click += new EventHandler(this.btnBrandUpdate_Click);
            // 
            // btnBrandDelete
            // 
            this.btnBrandDelete.Location = new System.Drawing.Point(14, 111);
            this.btnBrandDelete.Name = "btnBrandDelete";
            this.btnBrandDelete.Size = new System.Drawing.Size(131, 32);
            this.btnBrandDelete.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnBrandDelete.ForeColor = System.Drawing.Color.White;
            this.btnBrandDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBrandDelete.FlatAppearance.BorderSize = 0;
            this.btnBrandDelete.TabIndex = 18;
            this.btnBrandDelete.Text = "Delete";
            this.btnBrandDelete.Click += new EventHandler(this.btnBrandDelete_Click);
            // 
            // btnBrandClear
            // 
            this.btnBrandClear.Location = new System.Drawing.Point(153, 111);
            this.btnBrandClear.Name = "btnBrandClear";
            this.btnBrandClear.Size = new System.Drawing.Size(131, 32);
            this.btnBrandClear.TabIndex = 19;
            this.btnBrandClear.Text = "Clear";
            this.btnBrandClear.UseVisualStyleBackColor = true;
            this.btnBrandClear.Click += new EventHandler(this.btnBrandClear_Click);
            // 
            // gridBrands
            // 
            this.gridBrands.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBrands.Name = "gridBrands";
            this.gridBrands.Size = new System.Drawing.Size(300, 200);
            this.gridBrands.AllowUserToAddRows = false;
            this.gridBrands.AllowUserToDeleteRows = false;
            this.gridBrands.AllowUserToResizeRows = false;
            this.gridBrands.ReadOnly = true;
            this.gridBrands.MultiSelect = false;
            this.gridBrands.RowHeadersVisible = false;
            this.gridBrands.BackgroundColor = System.Drawing.Color.White;
            this.gridBrands.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridBrands.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBrands.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBrands.TabIndex = 20;
            this.gridBrands.SelectionChanged += new EventHandler(this.gridBrands_SelectionChanged);
            // 
            // tabs (children)
            // 
            this.tabs.Controls.Add(this.tabCategories);
            this.tabs.Controls.Add(this.tabBrands);
            // 
            // tabCategories (children)
            // 
            this.tabCategories.Controls.Add(this.gridCategories);
            this.tabCategories.Controls.Add(this.pnlCatForm);
            // 
            // tabBrands (children)
            // 
            this.tabBrands.Controls.Add(this.gridBrands);
            this.tabBrands.Controls.Add(this.pnlBrandForm);
            // 
            // pnlCatForm (children)
            // 
            this.pnlCatForm.Controls.Add(this.lblCatName);
            this.pnlCatForm.Controls.Add(this.txtCatName);
            this.pnlCatForm.Controls.Add(this.lblCatParent);
            this.pnlCatForm.Controls.Add(this.cboCatParent);
            this.pnlCatForm.Controls.Add(this.btnCatAdd);
            this.pnlCatForm.Controls.Add(this.btnCatUpdate);
            this.pnlCatForm.Controls.Add(this.btnCatDelete);
            this.pnlCatForm.Controls.Add(this.btnCatClear);
            // 
            // pnlBrandForm (children)
            // 
            this.pnlBrandForm.Controls.Add(this.lblBrandName);
            this.pnlBrandForm.Controls.Add(this.txtBrandName);
            this.pnlBrandForm.Controls.Add(this.btnBrandAdd);
            this.pnlBrandForm.Controls.Add(this.btnBrandUpdate);
            this.pnlBrandForm.Controls.Add(this.btnBrandDelete);
            this.pnlBrandForm.Controls.Add(this.btnBrandClear);
            // 
            // LookupControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.tabs);
            this.Name = "LookupControl";
            this.Load += new EventHandler(this.LookupControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBrands)).EndInit();
            this.tabs.ResumeLayout(false);
            this.tabs.PerformLayout();
            this.tabCategories.ResumeLayout(false);
            this.tabCategories.PerformLayout();
            this.tabBrands.ResumeLayout(false);
            this.tabBrands.PerformLayout();
            this.pnlCatForm.ResumeLayout(false);
            this.pnlCatForm.PerformLayout();
            this.pnlBrandForm.ResumeLayout(false);
            this.pnlBrandForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabCategories;
        private System.Windows.Forms.TabPage tabBrands;
        private System.Windows.Forms.Panel pnlCatForm;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.TextBox txtCatName;
        private System.Windows.Forms.Label lblCatParent;
        private System.Windows.Forms.ComboBox cboCatParent;
        private System.Windows.Forms.Button btnCatAdd;
        private System.Windows.Forms.Button btnCatUpdate;
        private System.Windows.Forms.Button btnCatDelete;
        private System.Windows.Forms.Button btnCatClear;
        private System.Windows.Forms.DataGridView gridCategories;
        private System.Windows.Forms.Panel pnlBrandForm;
        private System.Windows.Forms.Label lblBrandName;
        private System.Windows.Forms.TextBox txtBrandName;
        private System.Windows.Forms.Button btnBrandAdd;
        private System.Windows.Forms.Button btnBrandUpdate;
        private System.Windows.Forms.Button btnBrandDelete;
        private System.Windows.Forms.Button btnBrandClear;
        private System.Windows.Forms.DataGridView gridBrands;
    }
}
