namespace OnlineShoppingSystem.Views
{
    partial class ReviewsControl
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
            this.pnlTop = new System.Windows.Forms.FlowLayoutPanel();
            this.lblFilter = new System.Windows.Forms.Label();
            this.cboFilter = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnApprove = new System.Windows.Forms.Button();
            this.btnUnapprove = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtFull = new System.Windows.Forms.TextBox();
            this.gridReviews = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridReviews)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(300, 40);
            this.pnlTop.AutoSize = true;
            this.pnlTop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlTop.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.pnlTop.TabIndex = 0;
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Margin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Show";
            // 
            // cboFilter
            // 
            this.cboFilter.Name = "cboFilter";
            this.cboFilter.Size = new System.Drawing.Size(120, 23);
            this.cboFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFilter.FormattingEnabled = true;
            this.cboFilter.TabIndex = 2;
            this.cboFilter.SelectedIndexChanged += new EventHandler(this.cboFilter_SelectedIndexChanged);
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
            // btnApprove
            // 
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(90, 30);
            this.btnApprove.BackColor = System.Drawing.Color.FromArgb(0, 120, 212);
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApprove.FlatAppearance.BorderSize = 0;
            this.btnApprove.TabIndex = 4;
            this.btnApprove.Text = "Approve";
            this.btnApprove.Click += new EventHandler(this.btnApprove_Click);
            // 
            // btnUnapprove
            // 
            this.btnUnapprove.Name = "btnUnapprove";
            this.btnUnapprove.Size = new System.Drawing.Size(90, 30);
            this.btnUnapprove.TabIndex = 5;
            this.btnUnapprove.Text = "Unapprove";
            this.btnUnapprove.UseVisualStyleBackColor = true;
            this.btnUnapprove.Click += new EventHandler(this.btnUnapprove_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 30);
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(198, 40, 40);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new EventHandler(this.btnDelete_Click);
            // 
            // txtFull
            // 
            this.txtFull.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtFull.Name = "txtFull";
            this.txtFull.Size = new System.Drawing.Size(300, 90);
            this.txtFull.Multiline = true;
            this.txtFull.ReadOnly = true;
            this.txtFull.BackColor = System.Drawing.Color.White;
            this.txtFull.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtFull.TabIndex = 7;
            // 
            // gridReviews
            // 
            this.gridReviews.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridReviews.Name = "gridReviews";
            this.gridReviews.Size = new System.Drawing.Size(300, 200);
            this.gridReviews.AllowUserToAddRows = false;
            this.gridReviews.AllowUserToDeleteRows = false;
            this.gridReviews.AllowUserToResizeRows = false;
            this.gridReviews.ReadOnly = true;
            this.gridReviews.MultiSelect = false;
            this.gridReviews.RowHeadersVisible = false;
            this.gridReviews.BackgroundColor = System.Drawing.Color.White;
            this.gridReviews.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridReviews.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridReviews.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridReviews.TabIndex = 8;
            this.gridReviews.SelectionChanged += new EventHandler(this.gridReviews_SelectionChanged);
            // 
            // pnlTop (children)
            // 
            this.pnlTop.Controls.Add(this.lblFilter);
            this.pnlTop.Controls.Add(this.cboFilter);
            this.pnlTop.Controls.Add(this.btnRefresh);
            this.pnlTop.Controls.Add(this.btnApprove);
            this.pnlTop.Controls.Add(this.btnUnapprove);
            this.pnlTop.Controls.Add(this.btnDelete);
            // 
            // ReviewsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.gridReviews);
            this.Controls.Add(this.txtFull);
            this.Controls.Add(this.pnlTop);
            this.Name = "ReviewsControl";
            this.Load += new EventHandler(this.ReviewsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridReviews)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel pnlTop;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.ComboBox cboFilter;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnApprove;
        private System.Windows.Forms.Button btnUnapprove;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtFull;
        private System.Windows.Forms.DataGridView gridReviews;
    }
}
