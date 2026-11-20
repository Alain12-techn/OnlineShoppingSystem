namespace OnlineShoppingSystem.Views
{
    partial class NotificationsControl
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
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.gridNotes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMessage
            // 
            this.txtMessage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(300, 140);
            this.txtMessage.Multiline = true;
            this.txtMessage.ReadOnly = true;
            this.txtMessage.BackColor = System.Drawing.Color.White;
            this.txtMessage.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMessage.TabIndex = 0;
            // 
            // gridNotes
            // 
            this.gridNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridNotes.Name = "gridNotes";
            this.gridNotes.Size = new System.Drawing.Size(300, 200);
            this.gridNotes.AllowUserToAddRows = false;
            this.gridNotes.AllowUserToDeleteRows = false;
            this.gridNotes.AllowUserToResizeRows = false;
            this.gridNotes.ReadOnly = true;
            this.gridNotes.MultiSelect = false;
            this.gridNotes.RowHeadersVisible = false;
            this.gridNotes.BackgroundColor = System.Drawing.Color.White;
            this.gridNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridNotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridNotes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridNotes.TabIndex = 1;
            this.gridNotes.SelectionChanged += new EventHandler(this.gridNotes_SelectionChanged);
            // 
            // NotificationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Size = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.gridNotes);
            this.Controls.Add(this.txtMessage);
            this.Name = "NotificationsControl";
            this.Load += new EventHandler(this.NotificationsControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.DataGridView gridNotes;
    }
}
