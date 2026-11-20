namespace OnlineShoppingSystem.Views
{
    partial class ProfileControl
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
            this.pnlProfile = new System.Windows.Forms.Panel();
            this.lblProfileHdr = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.btnSaveProfile = new System.Windows.Forms.Button();
            this.lblAddrHdr = new System.Windows.Forms.Label();
            this.pnlAddrEdit = new System.Windows.Forms.FlowLayoutPanel();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblAddrPhone = new System.Windows.Forms.Label();
            this.txtAddrPhone = new System.Windows.Forms.TextBox();
            this.btnAddrAdd = new System.Windows.Forms.Button();
            this.btnAddrUpdate = new System.Windows.Forms.Button();
            this.btnAddrDelete = new System.Windows.Forms.Button();
            this.btnAddrClear = new System.Windows.Forms.Button();
            this.gridAddresses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridAddresses)).BeginInit();
            this.pnlProfile.SuspendLayout();
            this.pnlAddrEdit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProfile
            // 
            this.pnlProfile.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlProfile.Name = "pnlProfile";
            this.pnlProfile.Size = new System.Drawing.Size(330, 100);
            this.pnlProfile.BackColor = System.Drawing.Color.White;
            this.pnlProfile.AutoScroll = true;
            this.pnlProfile.TabIndex = 0;
            // 
            // lblProfileHdr
            // 
            this.lblProfileHdr.AutoSize = true;
            this.lblProfileHdr.Location = new System.Drawing.Point(14, 12);
            this.lblProfileHdr.Name = "lblProfileHdr";
            this.lblProfileHdr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProfileHdr.TabIndex = 1;
            this.lblProfileHdr.Text = "My profile";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(14, 46);
            this.lblName.Name = "lblName";
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Full name";
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtName.Location = new System.Drawing.Point(14, 66);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(300, 23);
            this.txtName.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(14, 97);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email (cannot be changed)";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtEmail.Location = new System.Drawing.Point(14, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(300, 23);
            this.txtEmail.ReadOnly = true;
            this.txtEmail.TabIndex = 5;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(14, 148);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone";
            // 
            // txtPhone
            // 
            this.txtPhone.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtPhone.Location = new System.Drawing.Point(14, 168);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(300, 23);
            this.txtPhone.TabIndex = 7;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(14, 199);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.TabIndex = 8;
            this.lblNewPassword.Text = "New password (optional)";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtNewPassword.Location = new System.Drawing.Point(14, 219);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(300, 23);
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.TabIndex = 9;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(14, 250);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.TabIndex = 10;
            this.lblConfirm.Text = "Confirm new password";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtConfirm.Location = new System.Drawing.Point(14, 270);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(300, 23);
            this.txtConfirm.UseSystemPasswordChar = true;
            this.txtConfirm.TabIndex = 11;
            // 
            // btnSaveProfile
            // 
            this.btnSaveProfile.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnSaveProfile.Location = new System.Drawing.Point(14, 307);
            this.btnSaveProfile.Name = "btnSaveProfile";
            this.btnSaveProfile.Size = new System.Drawing.Size(300, 38);
            this.btnSaveProfile.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnSaveProfile.ForeColor = System.Drawing.Color.White;
            this.btnSaveProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveProfile.FlatAppearance.BorderSize = 0;
            this.btnSaveProfile.TabIndex = 12;
            this.btnSaveProfile.Text = "Save profile";
            this.btnSaveProfile.Click += new EventHandler(this.btnSaveProfile_Click);
            // 
            // lblAddrHdr
            // 
            this.lblAddrHdr.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAddrHdr.Name = "lblAddrHdr";
            this.lblAddrHdr.Size = new System.Drawing.Size(300, 40);
            this.lblAddrHdr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAddrHdr.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.lblAddrHdr.TabIndex = 13;
            this.lblAddrHdr.Text = "My delivery addresses";
            // 
            // pnlAddrEdit
            // 
            this.pnlAddrEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAddrEdit.Name = "pnlAddrEdit";
            this.pnlAddrEdit.Size = new System.Drawing.Size(300, 40);
            this.pnlAddrEdit.AutoSize = true;
            this.pnlAddrEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlAddrEdit.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pnlAddrEdit.TabIndex = 14;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.TabIndex = 15;
            this.lblStreet.Text = "Street";
            // 
            // txtStreet
            // 
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(220, 23);
            this.txtStreet.TabIndex = 16;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.TabIndex = 17;
            this.lblCity.Text = "City";
            // 
            // txtCity
            // 
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(120, 23);
            this.txtCity.TabIndex = 18;
            // 
            // lblAddrPhone
            // 
            this.lblAddrPhone.AutoSize = true;
            this.lblAddrPhone.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblAddrPhone.Name = "lblAddrPhone";
            this.lblAddrPhone.TabIndex = 19;
            this.lblAddrPhone.Text = "Phone";
            // 
            // txtAddrPhone
            // 
            this.txtAddrPhone.Name = "txtAddrPhone";
            this.txtAddrPhone.Size = new System.Drawing.Size(120, 23);
            this.txtAddrPhone.TabIndex = 20;
            // 
            // btnAddrAdd
            // 
            this.btnAddrAdd.Name = "btnAddrAdd";
            this.btnAddrAdd.Size = new System.Drawing.Size(70, 30);
            this.btnAddrAdd.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnAddrAdd.ForeColor = System.Drawing.Color.White;
            this.btnAddrAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddrAdd.FlatAppearance.BorderSize = 0;
            this.btnAddrAdd.TabIndex = 21;
            this.btnAddrAdd.Text = "Add";
            this.btnAddrAdd.Click += new EventHandler(this.btnAddrAdd_Click);
            // 
            // btnAddrUpdate
            // 
            this.btnAddrUpdate.Name = "btnAddrUpdate";
            this.btnAddrUpdate.Size = new System.Drawing.Size(70, 30);
            this.btnAddrUpdate.TabIndex = 22;
            this.btnAddrUpdate.Text = "Update";
            this.btnAddrUpdate.UseVisualStyleBackColor = true;
            this.btnAddrUpdate.Click += new EventHandler(this.btnAddrUpdate_Click);
            // 
            // btnAddrDelete
            // 
            this.btnAddrDelete.Name = "btnAddrDelete";
            this.btnAddrDelete.Size = new System.Drawing.Size(70, 30);
            this.btnAddrDelete.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnAddrDelete.ForeColor = System.Drawing.Color.White;
            this.btnAddrDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddrDelete.FlatAppearance.BorderSize = 0;
            this.btnAddrDelete.TabIndex = 23;
            this.btnAddrDelete.Text = "Delete";
            this.btnAddrDelete.Click += new EventHandler(this.btnAddrDelete_Click);
            // 
            // btnAddrClear
            // 
            this.btnAddrClear.Name = "btnAddrClear";
            this.btnAddrClear.Size = new System.Drawing.Size(70, 30);
            this.btnAddrClear.TabIndex = 24;
            this.btnAddrClear.Text = "Clear";
            this.btnAddrClear.UseVisualStyleBackColor = true;
            this.btnAddrClear.Click += new EventHandler(this.btnAddrClear_Click);
            // 
            // gridAddresses
            // 
            this.gridAddresses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAddresses.Name = "gridAddresses";
            this.gridAddresses.Size = new System.Drawing.Size(300, 200);
            this.gridAddresses.AllowUserToAddRows = false;
            this.gridAddresses.AllowUserToDeleteRows = false;
            this.gridAddresses.AllowUserToResizeRows = false;
            this.gridAddresses.ReadOnly = true;
            this.gridAddresses.MultiSelect = false;
            this.gridAddresses.RowHeadersVisible = false;
            this.gridAddresses.BackgroundColor = System.Drawing.Color.White;
            this.gridAddresses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridAddresses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAddresses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridAddresses.TabIndex = 25;
            this.gridAddresses.SelectionChanged += new EventHandler(this.gridAddresses_SelectionChanged);
            // 
            // pnlProfile (children)
            // 
            this.pnlProfile.Controls.Add(this.lblProfileHdr);
            this.pnlProfile.Controls.Add(this.lblName);
            this.pnlProfile.Controls.Add(this.txtName);
            this.pnlProfile.Controls.Add(this.lblEmail);
            this.pnlProfile.Controls.Add(this.txtEmail);
            this.pnlProfile.Controls.Add(this.lblPhone);
            this.pnlProfile.Controls.Add(this.txtPhone);
            this.pnlProfile.Controls.Add(this.lblNewPassword);
            this.pnlProfile.Controls.Add(this.txtNewPassword);
            this.pnlProfile.Controls.Add(this.lblConfirm);
            this.pnlProfile.Controls.Add(this.txtConfirm);
            this.pnlProfile.Controls.Add(this.btnSaveProfile);
            // 
            // pnlAddrEdit (children)
            // 
            this.pnlAddrEdit.Controls.Add(this.lblStreet);
            this.pnlAddrEdit.Controls.Add(this.txtStreet);
            this.pnlAddrEdit.Controls.Add(this.lblCity);
            this.pnlAddrEdit.Controls.Add(this.txtCity);
            this.pnlAddrEdit.Controls.Add(this.lblAddrPhone);
            this.pnlAddrEdit.Controls.Add(this.txtAddrPhone);
            this.pnlAddrEdit.Controls.Add(this.btnAddrAdd);
            this.pnlAddrEdit.Controls.Add(this.btnAddrUpdate);
            this.pnlAddrEdit.Controls.Add(this.btnAddrDelete);
            this.pnlAddrEdit.Controls.Add(this.btnAddrClear);
            // 
            // ProfileControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.gridAddresses);
            this.Controls.Add(this.pnlAddrEdit);
            this.Controls.Add(this.lblAddrHdr);
            this.Controls.Add(this.pnlProfile);
            this.Name = "ProfileControl";
            this.Load += new EventHandler(this.ProfileControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAddresses)).EndInit();
            this.pnlProfile.ResumeLayout(false);
            this.pnlProfile.PerformLayout();
            this.pnlAddrEdit.ResumeLayout(false);
            this.pnlAddrEdit.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlProfile;
        private System.Windows.Forms.Label lblProfileHdr;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Button btnSaveProfile;
        private System.Windows.Forms.Label lblAddrHdr;
        private System.Windows.Forms.FlowLayoutPanel pnlAddrEdit;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblAddrPhone;
        private System.Windows.Forms.TextBox txtAddrPhone;
        private System.Windows.Forms.Button btnAddrAdd;
        private System.Windows.Forms.Button btnAddrUpdate;
        private System.Windows.Forms.Button btnAddrDelete;
        private System.Windows.Forms.Button btnAddrClear;
        private System.Windows.Forms.DataGridView gridAddresses;
    }
}
