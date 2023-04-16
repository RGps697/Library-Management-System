namespace UserInterfaceLibrary
{
    partial class BookViewerForm
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
            this.OutputAvailable = new System.Windows.Forms.Label();
            this.OutputEbook = new System.Windows.Forms.Label();
            this.outputInventoryNumber = new System.Windows.Forms.Label();
            this.outputPages = new System.Windows.Forms.Label();
            this.outputLanguage = new System.Windows.Forms.Label();
            this.outputISBN = new System.Windows.Forms.Label();
            this.outputPublicationYear = new System.Windows.Forms.Label();
            this.outputPublisher = new System.Windows.Forms.Label();
            this.outputCategory = new System.Windows.Forms.Label();
            this.o = new System.Windows.Forms.Label();
            this.outputTitle = new System.Windows.Forms.Label();
            this.buttonView = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.outputField = new System.Windows.Forms.Label();
            this.similarBooksList = new UserInterfaceLibrary.SelectableItemPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonBorrowByself = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDescription = new System.Windows.Forms.Label();
            this.outputDescription = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.OutputAvailable);
            this.panel1.Controls.Add(this.OutputEbook);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1144, 32);
            this.panel1.TabIndex = 27;
            // 
            // OutputAvailable
            // 
            this.OutputAvailable.AutoSize = true;
            this.OutputAvailable.Dock = System.Windows.Forms.DockStyle.Right;
            this.OutputAvailable.Location = new System.Drawing.Point(1027, 0);
            this.OutputAvailable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputAvailable.MaximumSize = new System.Drawing.Size(233, 0);
            this.OutputAvailable.MinimumSize = new System.Drawing.Size(117, 0);
            this.OutputAvailable.Name = "OutputAvailable";
            this.OutputAvailable.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.OutputAvailable.Size = new System.Drawing.Size(117, 27);
            this.OutputAvailable.TabIndex = 19;
            // 
            // OutputEbook
            // 
            this.OutputEbook.AutoSize = true;
            this.OutputEbook.Dock = System.Windows.Forms.DockStyle.Left;
            this.OutputEbook.Location = new System.Drawing.Point(0, 0);
            this.OutputEbook.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.OutputEbook.MaximumSize = new System.Drawing.Size(233, 0);
            this.OutputEbook.MinimumSize = new System.Drawing.Size(117, 0);
            this.OutputEbook.Name = "OutputEbook";
            this.OutputEbook.Padding = new System.Windows.Forms.Padding(0, 6, 0, 6);
            this.OutputEbook.Size = new System.Drawing.Size(117, 27);
            this.OutputEbook.TabIndex = 18;
            // 
            // outputInventoryNumber
            // 
            this.outputInventoryNumber.AutoEllipsis = true;
            this.outputInventoryNumber.AutoSize = true;
            this.outputInventoryNumber.Location = new System.Drawing.Point(119, 307);
            this.outputInventoryNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputInventoryNumber.MaximumSize = new System.Drawing.Size(0, 30);
            this.outputInventoryNumber.MinimumSize = new System.Drawing.Size(117, 20);
            this.outputInventoryNumber.Name = "outputInventoryNumber";
            this.outputInventoryNumber.Size = new System.Drawing.Size(117, 20);
            this.outputInventoryNumber.TabIndex = 36;
            // 
            // outputPages
            // 
            this.outputPages.AutoEllipsis = true;
            this.outputPages.AutoSize = true;
            this.outputPages.Location = new System.Drawing.Point(119, 273);
            this.outputPages.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputPages.MaximumSize = new System.Drawing.Size(0, 30);
            this.outputPages.MinimumSize = new System.Drawing.Size(117, 20);
            this.outputPages.Name = "outputPages";
            this.outputPages.Size = new System.Drawing.Size(117, 20);
            this.outputPages.TabIndex = 35;
            // 
            // outputLanguage
            // 
            this.outputLanguage.AutoEllipsis = true;
            this.outputLanguage.AutoSize = true;
            this.outputLanguage.Location = new System.Drawing.Point(119, 239);
            this.outputLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputLanguage.MaximumSize = new System.Drawing.Size(0, 30);
            this.outputLanguage.MinimumSize = new System.Drawing.Size(117, 20);
            this.outputLanguage.Name = "outputLanguage";
            this.outputLanguage.Size = new System.Drawing.Size(117, 20);
            this.outputLanguage.TabIndex = 34;
            // 
            // outputISBN
            // 
            this.outputISBN.AutoEllipsis = true;
            this.outputISBN.AutoSize = true;
            this.outputISBN.Location = new System.Drawing.Point(119, 205);
            this.outputISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputISBN.MaximumSize = new System.Drawing.Size(0, 30);
            this.outputISBN.MinimumSize = new System.Drawing.Size(117, 20);
            this.outputISBN.Name = "outputISBN";
            this.outputISBN.Size = new System.Drawing.Size(117, 20);
            this.outputISBN.TabIndex = 33;
            // 
            // outputPublicationYear
            // 
            this.outputPublicationYear.AutoEllipsis = true;
            this.outputPublicationYear.AutoSize = true;
            this.outputPublicationYear.Location = new System.Drawing.Point(119, 171);
            this.outputPublicationYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputPublicationYear.MaximumSize = new System.Drawing.Size(0, 30);
            this.outputPublicationYear.MinimumSize = new System.Drawing.Size(117, 20);
            this.outputPublicationYear.Name = "outputPublicationYear";
            this.outputPublicationYear.Size = new System.Drawing.Size(117, 20);
            this.outputPublicationYear.TabIndex = 32;
            // 
            // outputPublisher
            // 
            this.outputPublisher.AutoEllipsis = true;
            this.outputPublisher.AutoSize = true;
            this.outputPublisher.Location = new System.Drawing.Point(119, 137);
            this.outputPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputPublisher.MaximumSize = new System.Drawing.Size(0, 30);
            this.outputPublisher.MinimumSize = new System.Drawing.Size(117, 20);
            this.outputPublisher.Name = "outputPublisher";
            this.outputPublisher.Size = new System.Drawing.Size(117, 20);
            this.outputPublisher.TabIndex = 31;
            // 
            // outputCategory
            // 
            this.outputCategory.AutoEllipsis = true;
            this.outputCategory.AutoSize = true;
            this.outputCategory.Location = new System.Drawing.Point(119, 103);
            this.outputCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputCategory.MaximumSize = new System.Drawing.Size(0, 30);
            this.outputCategory.MinimumSize = new System.Drawing.Size(117, 20);
            this.outputCategory.Name = "outputCategory";
            this.outputCategory.Size = new System.Drawing.Size(117, 20);
            this.outputCategory.TabIndex = 30;
            // 
            // o
            // 
            this.o.AutoEllipsis = true;
            this.o.AutoSize = true;
            this.o.Location = new System.Drawing.Point(119, 35);
            this.o.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.o.MaximumSize = new System.Drawing.Size(0, 30);
            this.o.MinimumSize = new System.Drawing.Size(117, 20);
            this.o.Name = "o";
            this.o.Size = new System.Drawing.Size(117, 20);
            this.o.TabIndex = 29;
            // 
            // outputTitle
            // 
            this.outputTitle.AutoEllipsis = true;
            this.outputTitle.AutoSize = true;
            this.outputTitle.Location = new System.Drawing.Point(119, 1);
            this.outputTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputTitle.MaximumSize = new System.Drawing.Size(0, 30);
            this.outputTitle.MinimumSize = new System.Drawing.Size(117, 20);
            this.outputTitle.Name = "outputTitle";
            this.outputTitle.Size = new System.Drawing.Size(117, 20);
            this.outputTitle.TabIndex = 28;
            // 
            // buttonView
            // 
            this.buttonView.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonView.Location = new System.Drawing.Point(4, 8);
            this.buttonView.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonView.Name = "buttonView";
            this.buttonView.Size = new System.Drawing.Size(88, 27);
            this.buttonView.TabIndex = 37;
            this.buttonView.Text = "Wyświetl";
            this.buttonView.UseVisualStyleBackColor = true;
            this.buttonView.Visible = false;
            this.buttonView.Click += new System.EventHandler(this.buttonView_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.outputTitle, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.o, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.outputInventoryNumber, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.outputCategory, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.outputPages, 1, 8);
            this.tableLayoutPanel1.Controls.Add(this.outputPublisher, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.outputLanguage, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.outputPublicationYear, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.outputISBN, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.label8, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.label9, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.outputField, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 38);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 10;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(516, 349);
            this.tableLayoutPanel1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 37;
            this.label1.Text = "Tytuł:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 38;
            this.label2.Text = "Autorzy:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 39;
            this.label3.Text = "Kategorie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 40;
            this.label4.Text = "Wydawnictwo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 171);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 41;
            this.label5.Text = "Rok publikacji:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 15);
            this.label6.TabIndex = 42;
            this.label6.Text = "ISBN:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 43;
            this.label7.Text = "Język tekstu:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 15);
            this.label8.TabIndex = 44;
            this.label8.Text = "Liczba stron:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 15);
            this.label9.TabIndex = 45;
            this.label9.Text = "Numer inwentarza:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 15);
            this.label11.TabIndex = 46;
            this.label11.Text = "Dziedzina:";
            // 
            // outputField
            // 
            this.outputField.AutoEllipsis = true;
            this.outputField.AutoSize = true;
            this.outputField.Location = new System.Drawing.Point(118, 69);
            this.outputField.MaximumSize = new System.Drawing.Size(0, 30);
            this.outputField.MinimumSize = new System.Drawing.Size(117, 20);
            this.outputField.Name = "outputField";
            this.outputField.Size = new System.Drawing.Size(117, 20);
            this.outputField.TabIndex = 47;
            // 
            // similarBooksList
            // 
            this.similarBooksList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.similarBooksList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.similarBooksList.BackColor = System.Drawing.SystemColors.Control;
            this.similarBooksList.Location = new System.Drawing.Point(529, 62);
            this.similarBooksList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.similarBooksList.MinimumSize = new System.Drawing.Size(600, 300);
            this.similarBooksList.Name = "similarBooksList";
            this.similarBooksList.SelectedItem = null;
            this.similarBooksList.Size = new System.Drawing.Size(619, 325);
            this.similarBooksList.TabIndex = 39;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(529, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(163, 15);
            this.label10.TabIndex = 40;
            this.label10.Text = "Sugerowane podobne książki:";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.buttonBorrowByself);
            this.panel2.Controls.Add(this.buttonView);
            this.panel2.Location = new System.Drawing.Point(6, 506);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1142, 38);
            this.panel2.TabIndex = 41;
            // 
            // buttonBorrowByself
            // 
            this.buttonBorrowByself.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBorrowByself.Location = new System.Drawing.Point(1052, 12);
            this.buttonBorrowByself.Name = "buttonBorrowByself";
            this.buttonBorrowByself.Size = new System.Drawing.Size(87, 23);
            this.buttonBorrowByself.TabIndex = 38;
            this.buttonBorrowByself.Text = "Wypożycz";
            this.buttonBorrowByself.UseVisualStyleBackColor = true;
            this.buttonBorrowByself.Visible = false;
            this.buttonBorrowByself.Click += new System.EventHandler(this.buttonBorrowByself_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Outset;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.labelDescription, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.outputDescription, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(6, 400);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1141, 100);
            this.tableLayoutPanel2.TabIndex = 42;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(5, 2);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(34, 15);
            this.labelDescription.TabIndex = 0;
            this.labelDescription.Text = "Opis:";
            // 
            // outputDescription
            // 
            this.outputDescription.AutoEllipsis = true;
            this.outputDescription.AutoSize = true;
            this.outputDescription.Location = new System.Drawing.Point(5, 19);
            this.outputDescription.MinimumSize = new System.Drawing.Size(100, 0);
            this.outputDescription.Name = "outputDescription";
            this.outputDescription.Size = new System.Drawing.Size(100, 15);
            this.outputDescription.TabIndex = 1;
            // 
            // BookViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1156, 553);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.similarBooksList);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1400, 700);
            this.MinimumSize = new System.Drawing.Size(950, 592);
            this.Name = "BookViewerForm";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Text = "Szczegóły książki";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label OutputAvailable;
        private System.Windows.Forms.Label OutputEbook;
        private System.Windows.Forms.Label outputInventoryNumber;
        private System.Windows.Forms.Label outputPages;
        private System.Windows.Forms.Label outputLanguage;
        private System.Windows.Forms.Label outputISBN;
        private System.Windows.Forms.Label outputPublicationYear;
        private System.Windows.Forms.Label outputPublisher;
        private System.Windows.Forms.Label outputCategory;
        private System.Windows.Forms.Label o;
        private System.Windows.Forms.Label outputTitle;
        private System.Windows.Forms.Button buttonView;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private SelectableItemPanel similarBooksList;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label outputField;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Label outputDescription;
        private System.Windows.Forms.Button buttonBorrowByself;
    }
}