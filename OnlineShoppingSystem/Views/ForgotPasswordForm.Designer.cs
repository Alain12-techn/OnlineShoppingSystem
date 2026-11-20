namespace OnlineShoppingSystem.Views
{
    partial class ForgotPasswordForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.grpReset = new System.Windows.Forms.GroupBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblConfirm = new System.Windows.Forms.Label();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpReset.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 60);
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(31, 42, 68);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Reset your password";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(30, 75);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.TabIndex = 1;
            this.lblInfo.Text = "Step 1: enter your account email to receive a 6-digit code.";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 100);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtEmail.Location = new System.Drawing.Point(30, 120);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(340, 23);
            this.txtEmail.TabIndex = 3;
            // 
            // btnSendCode
            // 
            this.btnSendCode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnSendCode.Location = new System.Drawing.Point(30, 155);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(340, 34);
            this.btnSendCode.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnSendCode.ForeColor = System.Drawing.Color.White;
            this.btnSendCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendCode.FlatAppearance.BorderSize = 0;
            this.btnSendCode.TabIndex = 4;
            this.btnSendCode.Text = "Send reset code";
            this.btnSendCode.Click += new EventHandler(this.btnSendCode_Click);
            // 
            // grpReset
            // 
            this.grpReset.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.grpReset.Location = new System.Drawing.Point(30, 203);
            this.grpReset.Name = "grpReset";
            this.grpReset.Size = new System.Drawing.Size(340, 240);
            this.grpReset.Enabled = false;
            this.grpReset.TabIndex = 5;
            this.grpReset.Text = "Step 2: enter the code and a new password";
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(14, 22);
            this.lblCode.Name = "lblCode";
            this.lblCode.TabIndex = 6;
            this.lblCode.Text = "Code";
            // 
            // txtCode
            // 
            this.txtCode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtCode.Location = new System.Drawing.Point(14, 42);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(310, 23);
            this.txtCode.TabIndex = 7;
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(14, 73);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.TabIndex = 8;
            this.lblNewPassword.Text = "New password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtNewPassword.Location = new System.Drawing.Point(14, 93);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(310, 23);
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.TabIndex = 9;
            // 
            // lblConfirm
            // 
            this.lblConfirm.AutoSize = true;
            this.lblConfirm.Location = new System.Drawing.Point(14, 124);
            this.lblConfirm.Name = "lblConfirm";
            this.lblConfirm.TabIndex = 10;
            this.lblConfirm.Text = "Confirm new password";
            // 
            // txtConfirm
            // 
            this.txtConfirm.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtConfirm.Location = new System.Drawing.Point(14, 144);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(310, 23);
            this.txtConfirm.UseSystemPasswordChar = true;
            this.txtConfirm.TabIndex = 11;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnReset.Location = new System.Drawing.Point(14, 177);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(310, 34);
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "Reset password";
            this.btnReset.Click += new EventHandler(this.btnReset_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnClose.Location = new System.Drawing.Point(30, 453);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(340, 30);
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // grpReset (children)
            // 
            this.grpReset.Controls.Add(this.lblCode);
            this.grpReset.Controls.Add(this.txtCode);
            this.grpReset.Controls.Add(this.lblNewPassword);
            this.grpReset.Controls.Add(this.txtNewPassword);
            this.grpReset.Controls.Add(this.lblConfirm);
            this.grpReset.Controls.Add(this.txtConfirm);
            this.grpReset.Controls.Add(this.btnReset);
            // 
            // ForgotPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 498);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnSendCode);
            this.Controls.Add(this.grpReset);
            this.Controls.Add(this.btnClose);
            this.Name = "ForgotPasswordForm";
            this.Text = "Forgot password";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.CancelButton = this.btnClose;
            this.grpReset.ResumeLayout(false);
            this.grpReset.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.GroupBox grpReset;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Label lblConfirm;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnClose;
    }
}
