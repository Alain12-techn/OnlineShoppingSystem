namespace OnlineShoppingSystem.Views
{
    partial class MainForm
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.pnlSide = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnProducts = new System.Windows.Forms.Button();
            this.btnLookups = new System.Windows.Forms.Button();
            this.btnAdminOrders = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnCoupons = new System.Windows.Forms.Button();
            this.btnReviews = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnShop = new System.Windows.Forms.Button();
            this.btnCart = new System.Windows.Forms.Button();
            this.btnWishlist = new System.Windows.Forms.Button();
            this.btnMyOrders = new System.Windows.Forms.Button();
            this.btnNotifications = new System.Windows.Forms.Button();
            this.btnProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlHeader.SuspendLayout();
            this.pnlSide.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(100, 54);
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(320, 54);
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "";
            // 
            // lblHeading
            // 
            this.lblHeading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(300, 54);
            this.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHeading.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.lblHeading.TabIndex = 2;
            this.lblHeading.Text = "";
            // 
            // pnlSide
            // 
            this.pnlSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSide.Name = "pnlSide";
            this.pnlSide.Size = new System.Drawing.Size(210, 100);
            this.pnlSide.BackColor = System.Drawing.Color.FromArgb(31, 42, 68);
            this.pnlSide.TabIndex = 3;
            // 
            // lblLogo
            // 
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.Size = new System.Drawing.Size(210, 54);
            this.lblLogo.ForeColor = System.Drawing.Color.White;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogo.TabIndex = 4;
            this.lblLogo.Text = "OSS Store";
            // 
            // btnDashboard
            // 
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(210, 44);
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(31, 42, 68);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDashboard.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.TabIndex = 5;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.Click += new EventHandler(this.btnDashboard_Click);
            // 
            // btnProducts
            // 
            this.btnProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducts.Name = "btnProducts";
            this.btnProducts.Size = new System.Drawing.Size(210, 44);
            this.btnProducts.BackColor = System.Drawing.Color.FromArgb(31, 42, 68);
            this.btnProducts.ForeColor = System.Drawing.Color.White;
            this.btnProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProducts.FlatAppearance.BorderSize = 0;
            this.btnProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducts.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProducts.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnProducts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducts.TabIndex = 6;
            this.btnProducts.Text = "Products";
            this.btnProducts.Click += new EventHandler(this.btnProducts_Click);
            // 
            // btnLookups
            // 
            this.btnLookups.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLookups.Name = "btnLookups";
            this.btnLookups.Size = new System.Drawing.Size(210, 44);
            this.btnLookups.BackColor = System.Drawing.Color.FromArgb(31, 42, 68);
            this.btnLookups.ForeColor = System.Drawing.Color.White;
            this.btnLookups.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLookups.FlatAppearance.BorderSize = 0;
            this.btnLookups.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLookups.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLookups.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnLookups.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLookups.TabIndex = 7;
            this.btnLookups.Text = "Categories && Brands";
            this.btnLookups.Click += new EventHandler(this.btnLookups_Click);
            // 
            // btnAdminOrders
            // 
            this.btnAdminOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminOrders.Name = "btnAdminOrders";
            this.btnAdminOrders.Size = new System.Drawing.Size(210, 44);
            this.btnAdminOrders.BackColor = System.Drawing.Color.FromArgb(31, 42, 68);
            this.btnAdminOrders.ForeColor = System.Drawing.Color.White;
            this.btnAdminOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdminOrders.FlatAppearance.BorderSize = 0;
            this.btnAdminOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdminOrders.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdminOrders.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnAdminOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminOrders.TabIndex = 8;
            this.btnAdminOrders.Text = "Orders";
            this.btnAdminOrders.Click += new EventHandler(this.btnAdminOrders_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(210, 44);
            this.btnCustomers.BackColor = System.Drawing.Color.FromArgb(31, 42, 68);
            this.btnCustomers.ForeColor = System.Drawing.Color.White;
            this.btnCustomers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomers.FlatAppearance.BorderSize = 0;
            this.btnCustomers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomers.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCustomers.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnCustomers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomers.TabIndex = 9;
            this.btnCustomers.Text = "Customers";
            this.btnCustomers.Click += new EventHandler(this.btnCustomers_Click);
            // 
            // btnCoupons
            // 
            this.btnCoupons.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCoupons.Name = "btnCoupons";
            this.btnCoupons.Size = new System.Drawing.Size(210, 44);
            this.btnCoupons.BackColor = System.Drawing.Color.FromArgb(31, 42, 68);
            this.btnCoupons.ForeColor = System.Drawing.Color.White;
            this.btnCoupons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCoupons.FlatAppearance.BorderSize = 0;
            this.btnCoupons.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCoupons.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCoupons.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnCoupons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCoupons.TabIndex = 10;
            this.btnCoupons.Text = "Coupons";
            this.btnCoupons.Click += new EventHandler(this.btnCoupons_Click);
            // 
            // btnReviews
            // 
            this.btnReviews.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReviews.Name = "btnReviews";
            this.btnReviews.Size = new System.Drawing.Size(210, 44);
            this.btnReviews.BackColor = System.Drawing.Color.FromArgb(31, 42, 68);
            this.btnReviews.ForeColor = System.Drawing.Color.White;
            this.btnReviews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReviews.FlatAppearance.BorderSize = 0;
            this.btnReviews.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReviews.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReviews.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnReviews.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReviews.TabIndex = 11;
            this.btnReviews.Text = "Reviews";
            this.btnReviews.Click += new EventHandler(this.btnReviews_Click);
            // 
            // btnReports
            // 
            this.btnReports.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(210, 44);
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(31, 42, 68);
            this.btnReports.ForeColor = System.Drawing.Color.White;
            this.btnReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReports.FlatAppearance.BorderSize = 0;
            this.btnReports.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReports.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReports.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnReports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReports.TabIndex = 12;
            this.btnReports.Text = "Reports";
            this.btnReports.Click += new EventHandler(this.btnReports_Click);
            // 
            // btnShop
            // 
            this.btnShop.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(210, 44);
            this.btnShop.BackColor = System.Drawing.Color.FromArgb(31, 42, 68);
            this.btnShop.ForeColor = System.Drawing.Color.White;
            this.btnShop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShop.FlatAppearance.BorderSize = 0;
            this.btnShop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShop.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnShop.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnShop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShop.TabIndex = 13;
            this.btnShop.Text = "Shop";
            this.btnShop.Click += new EventHandler(this.btnShop_Click);
            // 
            // btnCart
            // 
            this.btnCart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCart.Name = "btnCart";
            this.btnCart.Size = new System.Drawing.Size(210, 44);
            this.btnCart.BackColor = System.Drawing.Color.FromArgb(31, 42, 68);
            this.btnCart.ForeColor = System.Drawing.Color.White;
            this.btnCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCart.FlatAppearance.BorderSize = 0;
            this.btnCart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCart.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCart.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCart.TabIndex = 14;
            this.btnCart.Text = "My Cart";
            this.btnCart.Click += new EventHandler(this.btnCart_Click);
            // 
            // btnWishlist
            // 
            this.btnWishlist.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnWishlist.Name = "btnWishlist";
            this.btnWishlist.Size = new System.Drawing.Size(210, 44);
            this.btnWishlist.BackColor = System.Drawing.Color.FromArgb(31, 42, 68);
            this.btnWishlist.ForeColor = System.Drawing.Color.White;
            this.btnWishlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWishlist.FlatAppearance.BorderSize = 0;
            this.btnWishlist.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWishlist.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnWishlist.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnWishlist.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWishlist.TabIndex = 15;
            this.btnWishlist.Text = "My Wishlist";
            this.btnWishlist.Click += new EventHandler(this.btnWishlist_Click);
            // 
            // btnMyOrders
            // 
            this.btnMyOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMyOrders.Name = "btnMyOrders";
            this.btnMyOrders.Size = new System.Drawing.Size(210, 44);
            this.btnMyOrders.BackColor = System.Drawing.Color.FromArgb(31, 42, 68);
            this.btnMyOrders.ForeColor = System.Drawing.Color.White;
            this.btnMyOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyOrders.FlatAppearance.BorderSize = 0;
            this.btnMyOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyOrders.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMyOrders.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnMyOrders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyOrders.TabIndex = 16;
            this.btnMyOrders.Text = "My Orders";
            this.btnMyOrders.Click += new EventHandler(this.btnMyOrders_Click);
            // 
            // btnNotifications
            // 
            this.btnNotifications.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNotifications.Name = "btnNotifications";
            this.btnNotifications.Size = new System.Drawing.Size(210, 44);
            this.btnNotifications.BackColor = System.Drawing.Color.FromArgb(31, 42, 68);
            this.btnNotifications.ForeColor = System.Drawing.Color.White;
            this.btnNotifications.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNotifications.FlatAppearance.BorderSize = 0;
            this.btnNotifications.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNotifications.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNotifications.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnNotifications.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNotifications.TabIndex = 17;
            this.btnNotifications.Text = "Notifications";
            this.btnNotifications.Click += new EventHandler(this.btnNotifications_Click);
            // 
            // btnProfile
            // 
            this.btnProfile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProfile.Name = "btnProfile";
            this.btnProfile.Size = new System.Drawing.Size(210, 44);
            this.btnProfile.BackColor = System.Drawing.Color.FromArgb(31, 42, 68);
            this.btnProfile.ForeColor = System.Drawing.Color.White;
            this.btnProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfile.FlatAppearance.BorderSize = 0;
            this.btnProfile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProfile.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnProfile.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnProfile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfile.TabIndex = 18;
            this.btnProfile.Text = "My Profile";
            this.btnProfile.Click += new EventHandler(this.btnProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(210, 46);
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(150, 30, 30);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.Padding = new System.Windows.Forms.Padding(14, 0, 0, 0);
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.TabIndex = 19;
            this.btnLogout.Text = "Log out";
            this.btnLogout.Click += new EventHandler(this.btnLogout_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(300, 300);
            this.pnlContent.BackColor = System.Drawing.Color.FromArgb(245, 246, 250);
            this.pnlContent.TabIndex = 20;
            // 
            // pnlHeader (children)
            // 
            this.pnlHeader.Controls.Add(this.lblHeading);
            this.pnlHeader.Controls.Add(this.lblUser);
            // 
            // pnlSide (children)
            // 
            this.pnlSide.Controls.Add(this.btnLogout);
            this.pnlSide.Controls.Add(this.btnProfile);
            this.pnlSide.Controls.Add(this.btnNotifications);
            this.pnlSide.Controls.Add(this.btnMyOrders);
            this.pnlSide.Controls.Add(this.btnWishlist);
            this.pnlSide.Controls.Add(this.btnCart);
            this.pnlSide.Controls.Add(this.btnShop);
            this.pnlSide.Controls.Add(this.btnReports);
            this.pnlSide.Controls.Add(this.btnReviews);
            this.pnlSide.Controls.Add(this.btnCoupons);
            this.pnlSide.Controls.Add(this.btnCustomers);
            this.pnlSide.Controls.Add(this.btnAdminOrders);
            this.pnlSide.Controls.Add(this.btnLookups);
            this.pnlSide.Controls.Add(this.btnProducts);
            this.pnlSide.Controls.Add(this.btnDashboard);
            this.pnlSide.Controls.Add(this.lblLogo);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlSide);
            this.Controls.Add(this.pnlHeader);
            this.Name = "MainForm";
            this.Text = "Online Shopping System";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.MinimumSize = new System.Drawing.Size(900, 560);
            this.Load += new EventHandler(this.MainForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlSide.ResumeLayout(false);
            this.pnlSide.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Panel pnlSide;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnLookups;
        private System.Windows.Forms.Button btnAdminOrders;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnCoupons;
        private System.Windows.Forms.Button btnReviews;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnShop;
        private System.Windows.Forms.Button btnCart;
        private System.Windows.Forms.Button btnWishlist;
        private System.Windows.Forms.Button btnMyOrders;
        private System.Windows.Forms.Button btnNotifications;
        private System.Windows.Forms.Button btnProfile;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Panel pnlContent;
    }
}
