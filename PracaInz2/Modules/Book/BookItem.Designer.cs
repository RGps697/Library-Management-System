namespace UserInterfaceLibrary
{
    partial class BookItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookItem));
            this.outputCategory = new System.Windows.Forms.Label();
            this.outputAuthor = new System.Windows.Forms.Label();
            this.outputTitle = new System.Windows.Forms.Label();
            this.bookDataPanel = new System.Windows.Forms.TableLayoutPanel();
            this.labelPages = new System.Windows.Forms.Label();
            this.labelAuthors = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.outputPublicationYear = new System.Windows.Forms.Label();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.labelPublicationYear = new System.Windows.Forms.Label();
            this.outputPublisher = new System.Windows.Forms.Label();
            this.outputNumberOfPages = new System.Windows.Forms.Label();
            this.labelCategories = new System.Windows.Forms.Label();
            this.icon = new System.Windows.Forms.PictureBox();
            this.bookDataPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // outputCategory
            // 
            this.outputCategory.AutoEllipsis = true;
            this.outputCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.outputCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputCategory.Location = new System.Drawing.Point(96, 75);
            this.outputCategory.Margin = new System.Windows.Forms.Padding(0);
            this.outputCategory.MaximumSize = new System.Drawing.Size(333, 30);
            this.outputCategory.MinimumSize = new System.Drawing.Size(117, 26);
            this.outputCategory.Name = "outputCategory";
            this.outputCategory.Padding = new System.Windows.Forms.Padding(3);
            this.outputCategory.Size = new System.Drawing.Size(333, 26);
            this.outputCategory.TabIndex = 5;
            this.outputCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outputAuthor
            // 
            this.outputAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputAuthor.AutoEllipsis = true;
            this.outputAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputAuthor.Location = new System.Drawing.Point(96, 42);
            this.outputAuthor.Margin = new System.Windows.Forms.Padding(0);
            this.outputAuthor.MaximumSize = new System.Drawing.Size(333, 32);
            this.outputAuthor.MinimumSize = new System.Drawing.Size(117, 32);
            this.outputAuthor.Name = "outputAuthor";
            this.outputAuthor.Padding = new System.Windows.Forms.Padding(3);
            this.outputAuthor.Size = new System.Drawing.Size(333, 32);
            this.outputAuthor.TabIndex = 7;
            this.outputAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outputTitle
            // 
            this.outputTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputTitle.AutoEllipsis = true;
            this.outputTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.outputTitle.Location = new System.Drawing.Point(96, 1);
            this.outputTitle.Margin = new System.Windows.Forms.Padding(0);
            this.outputTitle.MaximumSize = new System.Drawing.Size(333, 40);
            this.outputTitle.MinimumSize = new System.Drawing.Size(117, 40);
            this.outputTitle.Name = "outputTitle";
            this.outputTitle.Padding = new System.Windows.Forms.Padding(3);
            this.outputTitle.Size = new System.Drawing.Size(333, 40);
            this.outputTitle.TabIndex = 6;
            this.outputTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bookDataPanel
            // 
            this.bookDataPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.bookDataPanel.ColumnCount = 2;
            this.bookDataPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.09026F));
            this.bookDataPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.90974F));
            this.bookDataPanel.Controls.Add(this.labelPages, 0, 3);
            this.bookDataPanel.Controls.Add(this.labelAuthors, 0, 1);
            this.bookDataPanel.Controls.Add(this.outputTitle, 1, 0);
            this.bookDataPanel.Controls.Add(this.outputAuthor, 1, 1);
            this.bookDataPanel.Controls.Add(this.labelTitle, 0, 0);
            this.bookDataPanel.Controls.Add(this.outputCategory, 1, 2);
            this.bookDataPanel.Controls.Add(this.outputPublicationYear, 1, 5);
            this.bookDataPanel.Controls.Add(this.labelPublisher, 0, 4);
            this.bookDataPanel.Controls.Add(this.labelPublicationYear, 0, 5);
            this.bookDataPanel.Controls.Add(this.outputPublisher, 1, 4);
            this.bookDataPanel.Controls.Add(this.outputNumberOfPages, 1, 3);
            this.bookDataPanel.Controls.Add(this.labelCategories, 0, 2);
            this.bookDataPanel.Location = new System.Drawing.Point(148, 0);
            this.bookDataPanel.Margin = new System.Windows.Forms.Padding(0);
            this.bookDataPanel.MinimumSize = new System.Drawing.Size(430, 140);
            this.bookDataPanel.Name = "bookDataPanel";
            this.bookDataPanel.RowCount = 6;
            this.bookDataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bookDataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bookDataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bookDataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.bookDataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bookDataPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.bookDataPanel.Size = new System.Drawing.Size(430, 216);
            this.bookDataPanel.TabIndex = 10;
            // 
            // labelPages
            // 
            this.labelPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPages.AutoSize = true;
            this.labelPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPages.Location = new System.Drawing.Point(4, 102);
            this.labelPages.Name = "labelPages";
            this.labelPages.Size = new System.Drawing.Size(88, 30);
            this.labelPages.TabIndex = 12;
            this.labelPages.Text = "Ilość stron:";
            this.labelPages.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelAuthors
            // 
            this.labelAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAuthors.AutoSize = true;
            this.labelAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAuthors.Location = new System.Drawing.Point(4, 42);
            this.labelAuthors.Name = "labelAuthors";
            this.labelAuthors.Size = new System.Drawing.Size(88, 32);
            this.labelAuthors.TabIndex = 9;
            this.labelAuthors.Text = "Autorzy:";
            this.labelAuthors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(4, 1);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(88, 40);
            this.labelTitle.TabIndex = 8;
            this.labelTitle.Text = "Tytuł:";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputPublicationYear
            // 
            this.outputPublicationYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputPublicationYear.AutoEllipsis = true;
            this.outputPublicationYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputPublicationYear.Location = new System.Drawing.Point(96, 174);
            this.outputPublicationYear.Margin = new System.Windows.Forms.Padding(0);
            this.outputPublicationYear.MaximumSize = new System.Drawing.Size(333, 0);
            this.outputPublicationYear.MinimumSize = new System.Drawing.Size(50, 0);
            this.outputPublicationYear.Name = "outputPublicationYear";
            this.outputPublicationYear.Padding = new System.Windows.Forms.Padding(3);
            this.outputPublicationYear.Size = new System.Drawing.Size(333, 41);
            this.outputPublicationYear.TabIndex = 16;
            this.outputPublicationYear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelPublisher
            // 
            this.labelPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPublisher.Location = new System.Drawing.Point(4, 133);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(88, 40);
            this.labelPublisher.TabIndex = 13;
            this.labelPublisher.Text = "Wydawnictwo:";
            this.labelPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelPublicationYear
            // 
            this.labelPublicationYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPublicationYear.AutoSize = true;
            this.labelPublicationYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPublicationYear.Location = new System.Drawing.Point(4, 174);
            this.labelPublicationYear.Name = "labelPublicationYear";
            this.labelPublicationYear.Size = new System.Drawing.Size(88, 41);
            this.labelPublicationYear.TabIndex = 15;
            this.labelPublicationYear.Text = "Rok wydania:";
            this.labelPublicationYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // outputPublisher
            // 
            this.outputPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputPublisher.AutoEllipsis = true;
            this.outputPublisher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputPublisher.Location = new System.Drawing.Point(96, 133);
            this.outputPublisher.Margin = new System.Windows.Forms.Padding(0);
            this.outputPublisher.MaximumSize = new System.Drawing.Size(333, 0);
            this.outputPublisher.MinimumSize = new System.Drawing.Size(50, 0);
            this.outputPublisher.Name = "outputPublisher";
            this.outputPublisher.Padding = new System.Windows.Forms.Padding(3);
            this.outputPublisher.Size = new System.Drawing.Size(333, 40);
            this.outputPublisher.TabIndex = 14;
            this.outputPublisher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // outputNumberOfPages
            // 
            this.outputNumberOfPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outputNumberOfPages.AutoEllipsis = true;
            this.outputNumberOfPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.outputNumberOfPages.Location = new System.Drawing.Point(96, 102);
            this.outputNumberOfPages.Margin = new System.Windows.Forms.Padding(0);
            this.outputNumberOfPages.MaximumSize = new System.Drawing.Size(333, 0);
            this.outputNumberOfPages.MinimumSize = new System.Drawing.Size(117, 26);
            this.outputNumberOfPages.Name = "outputNumberOfPages";
            this.outputNumberOfPages.Padding = new System.Windows.Forms.Padding(3);
            this.outputNumberOfPages.Size = new System.Drawing.Size(333, 30);
            this.outputNumberOfPages.TabIndex = 11;
            this.outputNumberOfPages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelCategories
            // 
            this.labelCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCategories.AutoSize = true;
            this.labelCategories.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCategories.Location = new System.Drawing.Point(4, 75);
            this.labelCategories.Name = "labelCategories";
            this.labelCategories.Size = new System.Drawing.Size(88, 26);
            this.labelCategories.TabIndex = 10;
            this.labelCategories.Text = "Kategorie:";
            this.labelCategories.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.White;
            this.icon.ErrorImage = null;
            this.icon.InitialImage = ((System.Drawing.Image)(resources.GetObject("icon.InitialImage")));
            this.icon.Location = new System.Drawing.Point(0, 0);
            this.icon.Margin = new System.Windows.Forms.Padding(0);
            this.icon.MinimumSize = new System.Drawing.Size(139, 140);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(139, 140);
            this.icon.TabIndex = 9;
            this.icon.TabStop = false;
            // 
            // BookItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.bookDataPanel);
            this.Controls.Add(this.icon);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(580, 140);
            this.Name = "BookItem";
            this.Size = new System.Drawing.Size(578, 216);
            this.bookDataPanel.ResumeLayout(false);
            this.bookDataPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label outputCategory;
        public System.Windows.Forms.Label outputAuthor;
        public System.Windows.Forms.Label outputTitle;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label labelPages;
        public System.Windows.Forms.Label outputNumberOfPages;
        private System.Windows.Forms.Label labelCategories;
        private System.Windows.Forms.Label labelAuthors;
        private System.Windows.Forms.Label labelTitle;
        public System.Windows.Forms.TableLayoutPanel bookDataPanel;
        private System.Windows.Forms.Label outputPublisher;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.Label outputPublicationYear;
        private System.Windows.Forms.Label labelPublicationYear;
    }
}
