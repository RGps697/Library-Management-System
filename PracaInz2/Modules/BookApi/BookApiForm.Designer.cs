namespace UserInterfaceLibrary
{
    partial class BookApiForm
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
            this.fieldSearchOptions = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.isbnInput = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.itemList = new UserInterfaceLibrary.SelectableItemPanel();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.fieldSearchOptions);
            this.panel1.Controls.Add(this.buttonSearch);
            this.panel1.Controls.Add(this.isbnInput);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 63);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Wyszukaj po:";
            // 
            // fieldSearchOptions
            // 
            this.fieldSearchOptions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fieldSearchOptions.FormattingEnabled = true;
            this.fieldSearchOptions.Location = new System.Drawing.Point(13, 31);
            this.fieldSearchOptions.Name = "fieldSearchOptions";
            this.fieldSearchOptions.Size = new System.Drawing.Size(121, 23);
            this.fieldSearchOptions.TabIndex = 2;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Location = new System.Drawing.Point(618, 30);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(88, 27);
            this.buttonSearch.TabIndex = 1;
            this.buttonSearch.Text = "Szukaj";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // isbnInput
            // 
            this.isbnInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.isbnInput.Location = new System.Drawing.Point(141, 31);
            this.isbnInput.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.isbnInput.Name = "isbnInput";
            this.isbnInput.Size = new System.Drawing.Size(469, 23);
            this.isbnInput.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.itemList);
            this.panel2.Controls.Add(this.buttonAddBook);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 63);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(719, 398);
            this.panel2.TabIndex = 1;
            // 
            // itemList
            // 
            this.itemList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.itemList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.itemList.BackColor = System.Drawing.SystemColors.Control;
            this.itemList.Location = new System.Drawing.Point(0, 0);
            this.itemList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.itemList.Name = "itemList";
            this.itemList.SelectedItem = null;
            this.itemList.Size = new System.Drawing.Size(719, 368);
            this.itemList.TabIndex = 2;
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddBook.Location = new System.Drawing.Point(4, 368);
            this.buttonAddBook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(88, 27);
            this.buttonAddBook.TabIndex = 1;
            this.buttonAddBook.Text = "Dodaj";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Visible = false;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // BookApiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(719, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 1000);
            this.MinimumSize = new System.Drawing.Size(600, 500);
            this.Name = "BookApiForm";
            this.Text = "Wyszukaj w Google Books";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox isbnInput;
        private System.Windows.Forms.Button buttonAddBook;
        private SelectableItemPanel itemList;
        private System.Windows.Forms.ComboBox fieldSearchOptions;
        private System.Windows.Forms.Label label2;
    }
}