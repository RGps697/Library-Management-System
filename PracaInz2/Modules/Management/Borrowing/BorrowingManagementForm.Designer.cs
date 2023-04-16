namespace UserInterfaceLibrary.Management
{
    partial class BorrowingManagementForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.columnSearch = new System.Windows.Forms.ComboBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.searchField = new System.Windows.Forms.TextBox();
            this.buttonExtend = new System.Windows.Forms.Button();
            this.buttonReturnBook = new System.Windows.Forms.Button();
            this.borrowingListPanel = new UserInterfaceLibrary.SelectableItemPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.columnSearch);
            this.panel1.Controls.Add(this.buttonFind);
            this.panel1.Controls.Add(this.searchField);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 62);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Wyszukaj po:";
            // 
            // columnSearch
            // 
            this.columnSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columnSearch.FormattingEnabled = true;
            this.columnSearch.Location = new System.Drawing.Point(3, 25);
            this.columnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.columnSearch.Name = "columnSearch";
            this.columnSearch.Size = new System.Drawing.Size(182, 23);
            this.columnSearch.TabIndex = 4;
            // 
            // buttonFind
            // 
            this.buttonFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFind.Location = new System.Drawing.Point(825, 22);
            this.buttonFind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(88, 27);
            this.buttonFind.TabIndex = 2;
            this.buttonFind.Text = "Szukaj";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // searchField
            // 
            this.searchField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchField.Location = new System.Drawing.Point(193, 25);
            this.searchField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(624, 23);
            this.searchField.TabIndex = 1;
            // 
            // buttonExtend
            // 
            this.buttonExtend.Location = new System.Drawing.Point(108, 5);
            this.buttonExtend.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonExtend.Name = "buttonExtend";
            this.buttonExtend.Size = new System.Drawing.Size(89, 42);
            this.buttonExtend.TabIndex = 5;
            this.buttonExtend.Text = "Przedłuż";
            this.buttonExtend.UseVisualStyleBackColor = true;
            this.buttonExtend.Click += new System.EventHandler(this.buttonExtend_Click);
            // 
            // buttonReturnBook
            // 
            this.buttonReturnBook.Location = new System.Drawing.Point(204, 5);
            this.buttonReturnBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonReturnBook.Name = "buttonReturnBook";
            this.buttonReturnBook.Size = new System.Drawing.Size(89, 42);
            this.buttonReturnBook.TabIndex = 3;
            this.buttonReturnBook.Text = "Zwróć";
            this.buttonReturnBook.UseVisualStyleBackColor = true;
            this.buttonReturnBook.Click += new System.EventHandler(this.buttonReturnBook_Click);
            // 
            // borrowingListPanel
            // 
            this.borrowingListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.borrowingListPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.borrowingListPanel.BackColor = System.Drawing.SystemColors.Control;
            this.borrowingListPanel.Location = new System.Drawing.Point(0, 141);
            this.borrowingListPanel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.borrowingListPanel.Name = "borrowingListPanel";
            this.borrowingListPanel.SelectedItem = null;
            this.borrowingListPanel.Size = new System.Drawing.Size(920, 378);
            this.borrowingListPanel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.buttonExtend);
            this.panel2.Controls.Add(this.buttonReturnBook);
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(920, 55);
            this.panel2.TabIndex = 6;
            // 
            // BorrowingManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.borrowingListPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BorrowingManagementForm";
            this.Text = "BorrowManagement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox searchField;
        private SelectableItemPanel borrowingListPanel;
        private System.Windows.Forms.Button buttonReturnBook;
        private System.Windows.Forms.ComboBox columnSearch;
        private System.Windows.Forms.Button buttonExtend;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
    }
}