namespace OnlineShoppingSystem.Views
{
    partial class CartControl
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
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblQtyHdr = new System.Windows.Forms.Label();
            this.nudQty = new System.Windows.Forms.NumericUpDown();
            this.btnUpdateQty = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblCouponHdr = new System.Windows.Forms.Label();
            this.txtCoupon = new System.Windows.Forms.TextBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.lblCouponMsg = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.gridCart = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCart)).BeginInit();
            this.pnlSummary.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSummary
            // 
            this.pnlSummary.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(310, 100);
            this.pnlSummary.BackColor = System.Drawing.Color.White;
            this.pnlSummary.TabIndex = 0;
            // 
            // lblQtyHdr
            // 
            this.lblQtyHdr.AutoSize = true;
            this.lblQtyHdr.Location = new System.Drawing.Point(14, 14);
            this.lblQtyHdr.Name = "lblQtyHdr";
            this.lblQtyHdr.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblQtyHdr.TabIndex = 1;
            this.lblQtyHdr.Text = "Change quantity of selected item";
            // 
            // nudQty
            // 
            this.nudQty.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.nudQty.Location = new System.Drawing.Point(14, 38);
            this.nudQty.Name = "nudQty";
            this.nudQty.Size = new System.Drawing.Size(80, 23);
            this.nudQty.Maximum = new decimal(new int[] {1000, 0, 0, 0});
            this.nudQty.Minimum = new decimal(new int[] {1, 0, 0, 0});
            this.nudQty.Value = new decimal(new int[] {1, 0, 0, 0});
            this.nudQty.TabIndex = 2;
            // 
            // btnUpdateQty
            // 
            this.btnUpdateQty.Location = new System.Drawing.Point(104, 34);
            this.btnUpdateQty.Name = "btnUpdateQty";
            this.btnUpdateQty.Size = new System.Drawing.Size(90, 30);
            this.btnUpdateQty.TabIndex = 3;
            this.btnUpdateQty.Text = "Update";
            this.btnUpdateQty.UseVisualStyleBackColor = true;
            this.btnUpdateQty.Click += new EventHandler(this.btnUpdateQty_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(14, 76);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(135, 30);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new EventHandler(this.btnRemove_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(159, 76);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 30);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear cart";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new EventHandler(this.btnClear_Click);
            // 
            // lblCouponHdr
            // 
            this.lblCouponHdr.AutoSize = true;
            this.lblCouponHdr.Location = new System.Drawing.Point(14, 128);
            this.lblCouponHdr.Name = "lblCouponHdr";
            this.lblCouponHdr.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCouponHdr.TabIndex = 6;
            this.lblCouponHdr.Text = "Coupon code";
            // 
            // txtCoupon
            // 
            this.txtCoupon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.txtCoupon.Location = new System.Drawing.Point(14, 150);
            this.txtCoupon.Name = "txtCoupon";
            this.txtCoupon.Size = new System.Drawing.Size(170, 23);
            this.txtCoupon.TabIndex = 7;
            // 
            // btnApply
            // 
            this.btnApply.Location = new System.Drawing.Point(194, 146);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(100, 30);
            this.btnApply.TabIndex = 8;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new EventHandler(this.btnApply_Click);
            // 
            // lblCouponMsg
            // 
            this.lblCouponMsg.AutoSize = true;
            this.lblCouponMsg.Location = new System.Drawing.Point(14, 182);
            this.lblCouponMsg.Name = "lblCouponMsg";
            this.lblCouponMsg.ForeColor = System.Drawing.Color.Gray;
            this.lblCouponMsg.TabIndex = 9;
            this.lblCouponMsg.Text = "";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Location = new System.Drawing.Point(14, 235);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSubtotal.TabIndex = 10;
            this.lblSubtotal.Text = "Subtotal: 0.00";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Location = new System.Drawing.Point(14, 262);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDiscount.TabIndex = 11;
            this.lblDiscount.Text = "Discount: 0.00";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Location = new System.Drawing.Point(14, 289);
            this.lblTax.Name = "lblTax";
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTax.TabIndex = 12;
            this.lblTax.Text = "Tax: 0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(14, 326);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total: 0.00";
            // 
            // btnCheckout
            // 
            this.btnCheckout.Location = new System.Drawing.Point(14, 380);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(280, 44);
            this.btnCheckout.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnCheckout.ForeColor = System.Drawing.Color.White;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.TabIndex = 14;
            this.btnCheckout.Text = "Proceed to checkout";
            this.btnCheckout.Click += new EventHandler(this.btnCheckout_Click);
            // 
            // gridCart
            // 
            this.gridCart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridCart.Name = "gridCart";
            this.gridCart.Size = new System.Drawing.Size(300, 200);
            this.gridCart.AllowUserToAddRows = false;
            this.gridCart.AllowUserToDeleteRows = false;
            this.gridCart.AllowUserToResizeRows = false;
            this.gridCart.ReadOnly = true;
            this.gridCart.MultiSelect = false;
            this.gridCart.RowHeadersVisible = false;
            this.gridCart.BackgroundColor = System.Drawing.Color.White;
            this.gridCart.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCart.TabIndex = 15;
            this.gridCart.SelectionChanged += new EventHandler(this.gridCart_SelectionChanged);
            // 
            // pnlSummary (children)
            // 
            this.pnlSummary.Controls.Add(this.lblQtyHdr);
            this.pnlSummary.Controls.Add(this.nudQty);
            this.pnlSummary.Controls.Add(this.btnUpdateQty);
            this.pnlSummary.Controls.Add(this.btnRemove);
            this.pnlSummary.Controls.Add(this.btnClear);
            this.pnlSummary.Controls.Add(this.lblCouponHdr);
            this.pnlSummary.Controls.Add(this.txtCoupon);
            this.pnlSummary.Controls.Add(this.btnApply);
            this.pnlSummary.Controls.Add(this.lblCouponMsg);
            this.pnlSummary.Controls.Add(this.lblSubtotal);
            this.pnlSummary.Controls.Add(this.lblDiscount);
            this.pnlSummary.Controls.Add(this.lblTax);
            this.pnlSummary.Controls.Add(this.lblTotal);
            this.pnlSummary.Controls.Add(this.btnCheckout);
            // 
            // CartControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.gridCart);
            this.Controls.Add(this.pnlSummary);
            this.Name = "CartControl";
            this.Load += new EventHandler(this.CartControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCart)).EndInit();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblQtyHdr;
        private System.Windows.Forms.NumericUpDown nudQty;
        private System.Windows.Forms.Button btnUpdateQty;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblCouponHdr;
        private System.Windows.Forms.TextBox txtCoupon;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lblCouponMsg;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.DataGridView gridCart;
    }
}
