namespace OnlineShoppingSystem.Views
{
    partial class CheckoutForm
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
            this.lblAddress = new System.Windows.Forms.Label();
            this.cboAddress = new System.Windows.Forms.ComboBox();
            this.btnNewAddress = new System.Windows.Forms.Button();
            this.lblShipping = new System.Windows.Forms.Label();
            this.cboShipping = new System.Windows.Forms.ComboBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.cboPayment = new System.Windows.Forms.ComboBox();
            this.grpCard = new System.Windows.Forms.GroupBox();
            this.lblCardName = new System.Windows.Forms.Label();
            this.txtCardName = new System.Windows.Forms.TextBox();
            this.lblCardNumber = new System.Windows.Forms.Label();
            this.txtCardNumber = new System.Windows.Forms.TextBox();
            this.lblExpiry = new System.Windows.Forms.Label();
            this.txtExpiry = new System.Windows.Forms.TextBox();
            this.lblCvv = new System.Windows.Forms.Label();
            this.txtCvv = new System.Windows.Forms.TextBox();
            this.lblSumSubtotal = new System.Windows.Forms.Label();
            this.lblSumDiscount = new System.Windows.Forms.Label();
            this.lblSumTax = new System.Windows.Forms.Label();
            this.lblSumShipping = new System.Windows.Forms.Label();
            this.lblSumTotal = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpCard.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(300, 50);
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(31, 42, 68);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Checkout";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(20, 62);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.TabIndex = 1;
            this.lblAddress.Text = "Delivery address";
            // 
            // cboAddress
            // 
            this.cboAddress.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboAddress.Location = new System.Drawing.Point(20, 82);
            this.cboAddress.Name = "cboAddress";
            this.cboAddress.Size = new System.Drawing.Size(320, 23);
            this.cboAddress.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAddress.FormattingEnabled = true;
            this.cboAddress.TabIndex = 2;
            // 
            // btnNewAddress
            // 
            this.btnNewAddress.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnNewAddress.Location = new System.Drawing.Point(350, 80);
            this.btnNewAddress.Name = "btnNewAddress";
            this.btnNewAddress.Size = new System.Drawing.Size(90, 27);
            this.btnNewAddress.TabIndex = 3;
            this.btnNewAddress.Text = "New...";
            this.btnNewAddress.UseVisualStyleBackColor = true;
            this.btnNewAddress.Click += new EventHandler(this.btnNewAddress_Click);
            // 
            // lblShipping
            // 
            this.lblShipping.AutoSize = true;
            this.lblShipping.Location = new System.Drawing.Point(20, 113);
            this.lblShipping.Name = "lblShipping";
            this.lblShipping.TabIndex = 4;
            this.lblShipping.Text = "Shipping method";
            // 
            // cboShipping
            // 
            this.cboShipping.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboShipping.Location = new System.Drawing.Point(20, 133);
            this.cboShipping.Name = "cboShipping";
            this.cboShipping.Size = new System.Drawing.Size(420, 23);
            this.cboShipping.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboShipping.FormattingEnabled = true;
            this.cboShipping.TabIndex = 5;
            this.cboShipping.SelectedIndexChanged += new EventHandler(this.cboShipping_SelectedIndexChanged);
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(20, 164);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.TabIndex = 6;
            this.lblPayment.Text = "Payment method";
            // 
            // cboPayment
            // 
            this.cboPayment.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.cboPayment.Location = new System.Drawing.Point(20, 184);
            this.cboPayment.Name = "cboPayment";
            this.cboPayment.Size = new System.Drawing.Size(420, 23);
            this.cboPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPayment.FormattingEnabled = true;
            this.cboPayment.TabIndex = 7;
            this.cboPayment.SelectedIndexChanged += new EventHandler(this.cboPayment_SelectedIndexChanged);
            // 
            // grpCard
            // 
            this.grpCard.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.grpCard.Location = new System.Drawing.Point(20, 219);
            this.grpCard.Name = "grpCard";
            this.grpCard.Size = new System.Drawing.Size(420, 190);
            this.grpCard.TabIndex = 8;
            this.grpCard.Text = "Card details (sandbox - nothing is stored)";
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Location = new System.Drawing.Point(14, 22);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.TabIndex = 9;
            this.lblCardName.Text = "Name on card";
            // 
            // txtCardName
            // 
            this.txtCardName.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtCardName.Location = new System.Drawing.Point(14, 42);
            this.txtCardName.Name = "txtCardName";
            this.txtCardName.Size = new System.Drawing.Size(390, 23);
            this.txtCardName.TabIndex = 10;
            // 
            // lblCardNumber
            // 
            this.lblCardNumber.AutoSize = true;
            this.lblCardNumber.Location = new System.Drawing.Point(14, 73);
            this.lblCardNumber.Name = "lblCardNumber";
            this.lblCardNumber.TabIndex = 11;
            this.lblCardNumber.Text = "Card number";
            // 
            // txtCardNumber
            // 
            this.txtCardNumber.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtCardNumber.Location = new System.Drawing.Point(14, 93);
            this.txtCardNumber.Name = "txtCardNumber";
            this.txtCardNumber.Size = new System.Drawing.Size(390, 23);
            this.txtCardNumber.TabIndex = 12;
            // 
            // lblExpiry
            // 
            this.lblExpiry.AutoSize = true;
            this.lblExpiry.Location = new System.Drawing.Point(14, 128);
            this.lblExpiry.Name = "lblExpiry";
            this.lblExpiry.TabIndex = 13;
            this.lblExpiry.Text = "Expiry (MM/YY)";
            // 
            // txtExpiry
            // 
            this.txtExpiry.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.txtExpiry.Location = new System.Drawing.Point(14, 148);
            this.txtExpiry.Name = "txtExpiry";
            this.txtExpiry.Size = new System.Drawing.Size(150, 23);
            this.txtExpiry.TabIndex = 14;
            // 
            // lblCvv
            // 
            this.lblCvv.AutoSize = true;
            this.lblCvv.Location = new System.Drawing.Point(200, 128);
            this.lblCvv.Name = "lblCvv";
            this.lblCvv.TabIndex = 15;
            this.lblCvv.Text = "CVV";
            // 
            // txtCvv
            // 
            this.txtCvv.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left;
            this.txtCvv.Location = new System.Drawing.Point(200, 148);
            this.txtCvv.Name = "txtCvv";
            this.txtCvv.Size = new System.Drawing.Size(100, 23);
            this.txtCvv.UseSystemPasswordChar = true;
            this.txtCvv.TabIndex = 16;
            // 
            // lblSumSubtotal
            // 
            this.lblSumSubtotal.AutoSize = true;
            this.lblSumSubtotal.Location = new System.Drawing.Point(20, 419);
            this.lblSumSubtotal.Name = "lblSumSubtotal";
            this.lblSumSubtotal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSumSubtotal.TabIndex = 17;
            this.lblSumSubtotal.Text = "Subtotal: 0.00";
            // 
            // lblSumDiscount
            // 
            this.lblSumDiscount.AutoSize = true;
            this.lblSumDiscount.Location = new System.Drawing.Point(20, 441);
            this.lblSumDiscount.Name = "lblSumDiscount";
            this.lblSumDiscount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSumDiscount.TabIndex = 18;
            this.lblSumDiscount.Text = "Discount: 0.00";
            // 
            // lblSumTax
            // 
            this.lblSumTax.AutoSize = true;
            this.lblSumTax.Location = new System.Drawing.Point(20, 463);
            this.lblSumTax.Name = "lblSumTax";
            this.lblSumTax.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSumTax.TabIndex = 19;
            this.lblSumTax.Text = "Tax: 0.00";
            // 
            // lblSumShipping
            // 
            this.lblSumShipping.AutoSize = true;
            this.lblSumShipping.Location = new System.Drawing.Point(20, 485);
            this.lblSumShipping.Name = "lblSumShipping";
            this.lblSumShipping.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSumShipping.TabIndex = 20;
            this.lblSumShipping.Text = "Shipping: 0.00";
            // 
            // lblSumTotal
            // 
            this.lblSumTotal.AutoSize = true;
            this.lblSumTotal.Location = new System.Drawing.Point(20, 511);
            this.lblSumTotal.Name = "lblSumTotal";
            this.lblSumTotal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSumTotal.TabIndex = 21;
            this.lblSumTotal.Text = "Total: 0.00";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.btnPlaceOrder.Location = new System.Drawing.Point(20, 554);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(205, 38);
            this.btnPlaceOrder.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.FlatAppearance.BorderSize = 0;
            this.btnPlaceOrder.TabIndex = 22;
            this.btnPlaceOrder.Text = "Place order";
            this.btnPlaceOrder.Click += new EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnCancel.Location = new System.Drawing.Point(235, 554);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(205, 38);
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // grpCard (children)
            // 
            this.grpCard.Controls.Add(this.lblCardName);
            this.grpCard.Controls.Add(this.txtCardName);
            this.grpCard.Controls.Add(this.lblCardNumber);
            this.grpCard.Controls.Add(this.txtCardNumber);
            this.grpCard.Controls.Add(this.lblExpiry);
            this.grpCard.Controls.Add(this.txtExpiry);
            this.grpCard.Controls.Add(this.lblCvv);
            this.grpCard.Controls.Add(this.txtCvv);
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 609);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.cboAddress);
            this.Controls.Add(this.btnNewAddress);
            this.Controls.Add(this.lblShipping);
            this.Controls.Add(this.cboShipping);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.cboPayment);
            this.Controls.Add(this.grpCard);
            this.Controls.Add(this.lblSumSubtotal);
            this.Controls.Add(this.lblSumDiscount);
            this.Controls.Add(this.lblSumTax);
            this.Controls.Add(this.lblSumShipping);
            this.Controls.Add(this.lblSumTotal);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.btnCancel);
            this.Name = "CheckoutForm";
            this.Text = "Checkout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.MaximizeBox = false;
            this.CancelButton = this.btnCancel;
            this.Load += new EventHandler(this.CheckoutForm_Load);
            this.grpCard.ResumeLayout(false);
            this.grpCard.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox cboAddress;
        private System.Windows.Forms.Button btnNewAddress;
        private System.Windows.Forms.Label lblShipping;
        private System.Windows.Forms.ComboBox cboShipping;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.ComboBox cboPayment;
        private System.Windows.Forms.GroupBox grpCard;
        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.TextBox txtCardName;
        private System.Windows.Forms.Label lblCardNumber;
        private System.Windows.Forms.TextBox txtCardNumber;
        private System.Windows.Forms.Label lblExpiry;
        private System.Windows.Forms.TextBox txtExpiry;
        private System.Windows.Forms.Label lblCvv;
        private System.Windows.Forms.TextBox txtCvv;
        private System.Windows.Forms.Label lblSumSubtotal;
        private System.Windows.Forms.Label lblSumDiscount;
        private System.Windows.Forms.Label lblSumTax;
        private System.Windows.Forms.Label lblSumShipping;
        private System.Windows.Forms.Label lblSumTotal;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnCancel;
    }
}
