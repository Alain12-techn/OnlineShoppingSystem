namespace OnlineShoppingSystem.Views
{
    partial class CouponsControl
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
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.nudDiscount = new System.Windows.Forms.NumericUpDown();
            this.lblExpiry = new System.Windows.Forms.Label();
            this.dtpExpiry = new System.Windows.Forms.DateTimePicker();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gridCoupons = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCoupons)).BeginInit();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(310, 100);
            this.pnlForm.AutoScroll = true;
            this.pnlForm.BackColor = System.Drawing.Color.White;
            this.pnlForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlForm.TabIndex = 0;
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(14, 12);
            this.lblCode.Name = "lblCode";
            this.lblCode.TabIndex = 1;
            this.lblCode.Text = "Coupon code";
            // 
            // txtCode
            // 
            this.txtCode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtCode.Location = new System.Drawing.Point(14, 32);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(280, 23);
            this.txtCode.TabIndex = 2;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(14, 63);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.TabIndex = 3;
            this.lblDiscount.Text = "Discount (%)";
            // 
            // nudDiscount
            // 
            this.nudDiscount.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.nudDiscount.Location = new System.Drawing.Point(14, 83);
            this.nudDiscount.Name = "nudDiscount";
            this.nudDiscount.Size = new System.Drawing.Size(280, 23);
            this.nudDiscount.Maximum = new decimal(new int[] {100, 0, 0, 0});
            this.nudDiscount.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.nudDiscount.DecimalPlaces = 2;
            this.nudDiscount.Value = new decimal(new int[] {10, 0, 0, 0});
            this.nudDiscount.TabIndex = 4;
            // 
            // lblExpiry
            // 
            this.lblExpiry.AutoSize = true;
            this.lblExpiry.Location = new System.Drawing.Point(14, 114);
            this.lblExpiry.Name = "lblExpiry";
            this.lblExpiry.TabIndex = 5;
            this.lblExpiry.Text = "Expiry date";
            // 
            // dtpExpiry
            // 
            this.dtpExpiry.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.dtpExpiry.Location = new System.Drawing.Point(14, 134);
            this.dtpExpiry.Name = "dtpExpiry";
            this.dtpExpiry.Size = new System.Drawing.Size(280, 23);
            this.dtpExpiry.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiry.TabIndex = 6;
            // 
            // chkActive
            // 
            this.chkActive.Location = new System.Drawing.Point(14, 165);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(140, 24);
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.TabIndex = 7;
            this.chkActive.Text = "Active";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 205);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(131, 32);
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(153, 205);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(131, 32);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(14, 245);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(131, 32);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(153, 245);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 32);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new EventHandler(this.btnClear_Click);
            // 
            // gridCoupons
            // 
            this.gridCoupons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCoupons.Name = "gridCoupons";
            this.gridCoupons.Size = new System.Drawing.Size(300, 200);
            this.gridCoupons.AllowUserToAddRows = false;
            this.gridCoupons.AllowUserToDeleteRows = false;
            this.gridCoupons.AllowUserToResizeRows = false;
            this.gridCoupons.ReadOnly = true;
            this.gridCoupons.MultiSelect = false;
            this.gridCoupons.RowHeadersVisible = false;
            this.gridCoupons.BackgroundColor = System.Drawing.Color.White;
            this.gridCoupons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCoupons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCoupons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCoupons.TabIndex = 12;
            this.gridCoupons.SelectionChanged += new EventHandler(this.gridCoupons_SelectionChanged);
            // 
            // pnlForm (children)
            // 
            this.pnlForm.Controls.Add(this.lblCode);
            this.pnlForm.Controls.Add(this.txtCode);
            this.pnlForm.Controls.Add(this.lblDiscount);
            this.pnlForm.Controls.Add(this.nudDiscount);
            this.pnlForm.Controls.Add(this.lblExpiry);
            this.pnlForm.Controls.Add(this.dtpExpiry);
            this.pnlForm.Controls.Add(this.chkActive);
            this.pnlForm.Controls.Add(this.btnAdd);
            this.pnlForm.Controls.Add(this.btnUpdate);
            this.pnlForm.Controls.Add(this.btnDelete);
            this.pnlForm.Controls.Add(this.btnClear);
            // 
            // CouponsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.gridCoupons);
            this.Controls.Add(this.pnlForm);
            this.Name = "CouponsControl";
            this.Load += new EventHandler(this.CouponsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCoupons)).EndInit();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.NumericUpDown nudDiscount;
        private System.Windows.Forms.Label lblExpiry;
        private System.Windows.Forms.DateTimePicker dtpExpiry;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView gridCoupons;
    }
}
