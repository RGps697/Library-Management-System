namespace UserInterfaceLibrary
{
    partial class UserDashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonExamAttempts = new System.Windows.Forms.Button();
            this.buttonBorrowedBooks = new System.Windows.Forms.Button();
            this.itemsPanel = new UserInterfaceLibrary.SelectableItemPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogout
            // 
            this.buttonLogout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLogout.Location = new System.Drawing.Point(832, 14);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(88, 27);
            this.buttonLogout.TabIndex = 0;
            this.buttonLogout.Text = "Wyloguj";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonExamAttempts);
            this.panel1.Controls.Add(this.buttonBorrowedBooks);
            this.panel1.Location = new System.Drawing.Point(14, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 61);
            this.panel1.TabIndex = 2;
            // 
            // buttonExamAttempts
            // 
            this.buttonExamAttempts.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonExamAttempts.Location = new System.Drawing.Point(108, 0);
            this.buttonExamAttempts.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonExamAttempts.Name = "buttonExamAttempts";
            this.buttonExamAttempts.Size = new System.Drawing.Size(98, 59);
            this.buttonExamAttempts.TabIndex = 5;
            this.buttonExamAttempts.Text = "Rozwiązane egzaminy";
            this.buttonExamAttempts.UseVisualStyleBackColor = true;
            this.buttonExamAttempts.Click += new System.EventHandler(this.buttonExamAttempts_Click);
            // 
            // buttonBorrowedBooks
            // 
            this.buttonBorrowedBooks.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonBorrowedBooks.Location = new System.Drawing.Point(0, 0);
            this.buttonBorrowedBooks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonBorrowedBooks.Name = "buttonBorrowedBooks";
            this.buttonBorrowedBooks.Size = new System.Drawing.Size(108, 59);
            this.buttonBorrowedBooks.TabIndex = 4;
            this.buttonBorrowedBooks.Text = "Wypożyczone książki";
            this.buttonBorrowedBooks.UseVisualStyleBackColor = true;
            this.buttonBorrowedBooks.Click += new System.EventHandler(this.buttonBorrowedBooks_Click);
            // 
            // itemsPanel
            // 
            this.itemsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemsPanel.AutoScroll = true;
            this.itemsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.itemsPanel.BackColor = System.Drawing.SystemColors.Control;
            this.itemsPanel.Location = new System.Drawing.Point(14, 115);
            this.itemsPanel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.itemsPanel.Name = "itemsPanel";
            this.itemsPanel.SelectedItem = null;
            this.itemsPanel.Size = new System.Drawing.Size(905, 390);
            this.itemsPanel.TabIndex = 1;
            // 
            // UserDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.itemsPanel);
            this.Controls.Add(this.buttonLogout);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "UserDashboardForm";
            this.Text = "UserDashboard";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLogout;
        private SelectableItemPanel itemsPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonExamAttempts;
        private System.Windows.Forms.Button buttonBorrowedBooks;
    }
}