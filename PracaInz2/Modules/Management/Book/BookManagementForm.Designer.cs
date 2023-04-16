namespace UserInterfaceLibrary.Management
{
    partial class BookManagementForm
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
            this.ButtonIsbnApi = new System.Windows.Forms.Button();
            this.buttonBorrow = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonNewBook = new System.Windows.Forms.Button();
            this.bookListPanel = new UserInterfaceLibrary.SelectableItemPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(911, 62);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Wyszukaj po:";
            // 
            // columnSearch
            // 
            this.columnSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columnSearch.FormattingEnabled = true;
            this.columnSearch.Location = new System.Drawing.Point(5, 24);
            this.columnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.columnSearch.Name = "columnSearch";
            this.columnSearch.Size = new System.Drawing.Size(182, 23);
            this.columnSearch.TabIndex = 6;
            // 
            // buttonFind
            // 
            this.buttonFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFind.Location = new System.Drawing.Point(818, 21);
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
            this.searchField.Location = new System.Drawing.Point(195, 24);
            this.searchField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(615, 23);
            this.searchField.TabIndex = 1;
            // 
            // ButtonIsbnApi
            // 
            this.ButtonIsbnApi.Location = new System.Drawing.Point(98, 7);
            this.ButtonIsbnApi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonIsbnApi.Name = "ButtonIsbnApi";
            this.ButtonIsbnApi.Size = new System.Drawing.Size(89, 42);
            this.ButtonIsbnApi.TabIndex = 5;
            this.ButtonIsbnApi.Text = "Wyszukaj w Google Books";
            this.ButtonIsbnApi.UseVisualStyleBackColor = true;
            this.ButtonIsbnApi.Click += new System.EventHandler(this.buttonIsbnApi_Click);
            // 
            // buttonBorrow
            // 
            this.buttonBorrow.Location = new System.Drawing.Point(321, 7);
            this.buttonBorrow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonBorrow.Name = "buttonBorrow";
            this.buttonBorrow.Size = new System.Drawing.Size(89, 42);
            this.buttonBorrow.TabIndex = 4;
            this.buttonBorrow.Text = "Wypożycz";
            this.buttonBorrow.UseVisualStyleBackColor = true;
            this.buttonBorrow.Visible = false;
            this.buttonBorrow.Click += new System.EventHandler(this.buttonBorrow_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.Location = new System.Drawing.Point(816, 7);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(89, 42);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonNewBook
            // 
            this.buttonNewBook.Location = new System.Drawing.Point(4, 7);
            this.buttonNewBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonNewBook.Name = "buttonNewBook";
            this.buttonNewBook.Size = new System.Drawing.Size(89, 42);
            this.buttonNewBook.TabIndex = 0;
            this.buttonNewBook.Text = "Nowa książka";
            this.buttonNewBook.UseVisualStyleBackColor = true;
            this.buttonNewBook.Visible = false;
            this.buttonNewBook.Click += new System.EventHandler(this.buttonNewBook_Click);
            // 
            // bookListPanel
            // 
            this.bookListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bookListPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bookListPanel.BackColor = System.Drawing.SystemColors.Control;
            this.bookListPanel.Location = new System.Drawing.Point(0, 32);
            this.bookListPanel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.bookListPanel.Name = "bookListPanel";
            this.bookListPanel.SelectedItem = null;
            this.bookListPanel.Size = new System.Drawing.Size(911, 366);
            this.bookListPanel.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ButtonIsbnApi);
            this.panel2.Controls.Add(this.buttonBorrow);
            this.panel2.Controls.Add(this.buttonDelete);
            this.panel2.Controls.Add(this.buttonNewBook);
            this.panel2.Location = new System.Drawing.Point(0, 80);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(911, 55);
            this.panel2.TabIndex = 4;
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortBy.FormattingEnabled = true;
            this.comboBoxSortBy.Location = new System.Drawing.Point(631, 3);
            this.comboBoxSortBy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(276, 23);
            this.comboBoxSortBy.TabIndex = 6;
            this.comboBoxSortBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortBy_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.bookListPanel);
            this.panel3.Controls.Add(this.comboBoxSortBy);
            this.panel3.Location = new System.Drawing.Point(0, 136);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(911, 398);
            this.panel3.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sortowanie:";
            // 
            // BookManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 534);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "BookManagementForm";
            this.Text = "BookManagement";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.Button buttonNewBook;
        private System.Windows.Forms.Button buttonDelete;
        private SelectableItemPanel bookListPanel;
        private System.Windows.Forms.Button buttonBorrow;
        private System.Windows.Forms.Button ButtonIsbnApi;
        private System.Windows.Forms.ComboBox columnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}