namespace OnlineShoppingSystem.Views
{
    partial class LoginForm
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkShow = new System.Windows.Forms.CheckBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lnkRegister = new System.Windows.Forms.LinkLabel();
            this.lnkForgot = new System.Windows.Forms.LinkLabel();
            this.lblHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 70);
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(31, 42, 68);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Online Shopping System";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(40, 95);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtEmail.Location = new System.Drawing.Point(40, 115);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(320, 23);
            this.txtEmail.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(40, 155);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtPassword.Location = new System.Drawing.Point(40, 175);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(320, 23);
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.TabIndex = 4;
            // 
            // chkShow
            // 
            this.chkShow.Location = new System.Drawing.Point(40, 205);
            this.chkShow.Name = "chkShow";
            this.chkShow.Size = new System.Drawing.Size(140, 24);
            this.chkShow.TabIndex = 5;
            this.chkShow.Text = "Show password";
            this.chkShow.CheckedChanged += new EventHandler(this.chkShow_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnLogin.Location = new System.Drawing.Point(40, 240);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(320, 38);
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new EventHandler(this.btnLogin_Click);
            // 
            // lnkRegister
            // 
            this.lnkRegister.AutoSize = true;
            this.lnkRegister.Location = new System.Drawing.Point(40, 295);
            this.lnkRegister.Name = "lnkRegister";
            this.lnkRegister.TabIndex = 7;
            this.lnkRegister.Text = "Create an account";
            this.lnkRegister.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRegister_LinkClicked);
            // 
            // lnkForgot
            // 
            this.lnkForgot.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lnkForgot.AutoSize = true;
            this.lnkForgot.Location = new System.Drawing.Point(255, 295);
            this.lnkForgot.Name = "lnkForgot";
            this.lnkForgot.TabIndex = 8;
            this.lnkForgot.Text = "Forgot password?";
            this.lnkForgot.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkForgot_LinkClicked);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Location = new System.Drawing.Point(40, 335);
            this.lblHint.Name = "lblHint";
            this.lblHint.ForeColor = System.Drawing.Color.Gray;
            this.lblHint.TabIndex = 9;
            this.lblHint.Text = "Demo admin: admin@oss.com / Admin@123";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 380);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.chkShow);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.lnkRegister);
            this.Controls.Add(this.lnkForgot);
            this.Controls.Add(this.lblHint);
            this.Name = "LoginForm";
            this.Text = "Login - Online Shopping System";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.AcceptButton = this.btnLogin;
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkShow;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel lnkRegister;
        private System.Windows.Forms.LinkLabel lnkForgot;
        private System.Windows.Forms.Label lblHint;
    }
}
