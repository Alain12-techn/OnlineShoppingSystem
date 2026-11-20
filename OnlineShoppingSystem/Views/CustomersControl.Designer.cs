namespace OnlineShoppingSystem.Views
{
    partial class CustomersControl
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gridCustomers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).BeginInit();
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
            this.txtSearch.Size = new System.Drawing.Size(240, 23);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new EventHandler(this.txtSearch_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 30);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new EventHandler(this.btnRefresh_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(310, 100);
            this.pnlForm.AutoScroll = true;
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlForm.TabIndex = 4;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 12);
            this.lblName.Name = "lblName";
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Full name";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtName.Location = new System.Drawing.Point(14, 32);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(280, 23);
            this.txtName.TabIndex = 6;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(14, 63);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtEmail.Location = new System.Drawing.Point(14, 83);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(280, 23);
            this.txtEmail.TabIndex = 8;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(14, 114);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.TabIndex = 9;
            this.lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtPhone.Location = new System.Drawing.Point(14, 134);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(280, 23);
            this.txtPhone.TabIndex = 10;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(14, 165);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.TabIndex = 11;
            this.lblPassword.Text = "Password (blank = keep current)";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtPassword.Location = new System.Drawing.Point(14, 185);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(280, 23);
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 222);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(136, 32);
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add customer";
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(158, 222);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(136, 32);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new EventHandler(this.btnUpdate_Click);
            // 
            // btnToggle
            // 
            this.btnToggle.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnToggle.Location = new System.Drawing.Point(14, 262);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Size = new System.Drawing.Size(280, 32);
            this.btnToggle.TabIndex = 15;
            this.btnToggle.Text = "Activate / Deactivate";
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new EventHandler(this.btnToggle_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(14, 302);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(136, 32);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(158, 302);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 32);
            this.btnClear.TabIndex = 17;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new EventHandler(this.btnClear_Click);
            // 
            // gridCustomers
            // 
            this.gridCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCustomers.Name = "gridCustomers";
            this.gridCustomers.Size = new System.Drawing.Size(300, 200);
            this.gridCustomers.AllowUserToAddRows = false;
            this.gridCustomers.AllowUserToDeleteRows = false;
            this.gridCustomers.AllowUserToResizeRows = false;
            this.gridCustomers.ReadOnly = true;
            this.gridCustomers.MultiSelect = false;
            this.gridCustomers.RowHeadersVisible = false;
            this.gridCustomers.BackgroundColor = System.Drawing.Color.White;
            this.gridCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCustomers.TabIndex = 18;
            this.gridCustomers.SelectionChanged += new EventHandler(this.gridCustomers_SelectionChanged);
            // 
            // pnlSearch (children)
            // 
            this.pnlSearch.Controls.Add(this.lblSearch);
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Controls.Add(this.btnRefresh);
            // 
            // pnlForm (children)
            // 
            this.pnlForm.Controls.Add(this.lblName);
            this.pnlForm.Controls.Add(this.txtName);
            this.pnlForm.Controls.Add(this.lblEmail);
            this.pnlForm.Controls.Add(this.txtEmail);
            this.pnlForm.Controls.Add(this.lblPhone);
            this.pnlForm.Controls.Add(this.txtPhone);
            this.pnlForm.Controls.Add(this.lblPassword);
            this.pnlForm.Controls.Add(this.txtPassword);
            this.pnlForm.Controls.Add(this.btnAdd);
            this.pnlForm.Controls.Add(this.btnUpdate);
            this.pnlForm.Controls.Add(this.btnToggle);
            this.pnlForm.Controls.Add(this.btnDelete);
            this.pnlForm.Controls.Add(this.btnClear);
            // 
            // CustomersControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.gridCustomers);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlSearch);
            this.Name = "CustomersControl";
            this.Load += new EventHandler(this.CustomersControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCustomers)).EndInit();
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
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView gridCustomers;
    }
}
