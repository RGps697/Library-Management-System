namespace UserInterfaceLibrary
{
    partial class BookCreatorForm
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputDetails = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelInventoryNumber = new System.Windows.Forms.Label();
            this.inputInventoryNumber = new System.Windows.Forms.TextBox();
            this.inputCategories = new System.Windows.Forms.TextBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.labelPageAmount = new System.Windows.Forms.Label();
            this.inputPageAmount = new System.Windows.Forms.TextBox();
            this.inputPubYear = new System.Windows.Forms.TextBox();
            this.labelPublicationYear = new System.Windows.Forms.Label();
            this.labelLanguage = new System.Windows.Forms.Label();
            this.inputLanguage = new System.Windows.Forms.TextBox();
            this.inputISBN = new System.Windows.Forms.TextBox();
            this.labelISBN = new System.Windows.Forms.Label();
            this.inputPublisher = new System.Windows.Forms.TextBox();
            this.labelPublisher = new System.Windows.Forms.Label();
            this.inputAuthors = new System.Windows.Forms.TextBox();
            this.labelAuthor = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.inputTitle = new System.Windows.Forms.TextBox();
            this.buttonDeleteEbook = new System.Windows.Forms.Button();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.buttonAddEbookFile = new System.Windows.Forms.Button();
            this.cbEbook = new System.Windows.Forms.CheckBox();
            this.openFileDialogEbook = new System.Windows.Forms.OpenFileDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonRestoreDefault = new System.Windows.Forms.Button();
            this.buttonAddCover = new System.Windows.Forms.Button();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.openFileDialogCover = new System.Windows.Forms.OpenFileDialog();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonAdd);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(467, 746);
            this.panel1.TabIndex = 0;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(363, 706);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(88, 27);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAdd.Location = new System.Drawing.Point(14, 706);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(88, 27);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Zapisz";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.inputDetails);
            this.groupBox2.Location = new System.Drawing.Point(14, 507);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(439, 164);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Uwagi";
            // 
            // inputDetails
            // 
            this.inputDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputDetails.Location = new System.Drawing.Point(9, 35);
            this.inputDetails.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputDetails.Name = "inputDetails";
            this.inputDetails.Size = new System.Drawing.Size(424, 117);
            this.inputDetails.TabIndex = 10;
            this.inputDetails.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.inputField);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelInventoryNumber);
            this.groupBox1.Controls.Add(this.inputInventoryNumber);
            this.groupBox1.Controls.Add(this.inputCategories);
            this.groupBox1.Controls.Add(this.labelCategory);
            this.groupBox1.Controls.Add(this.labelPageAmount);
            this.groupBox1.Controls.Add(this.inputPageAmount);
            this.groupBox1.Controls.Add(this.inputPubYear);
            this.groupBox1.Controls.Add(this.labelPublicationYear);
            this.groupBox1.Controls.Add(this.labelLanguage);
            this.groupBox1.Controls.Add(this.inputLanguage);
            this.groupBox1.Controls.Add(this.inputISBN);
            this.groupBox1.Controls.Add(this.labelISBN);
            this.groupBox1.Controls.Add(this.inputPublisher);
            this.groupBox1.Controls.Add(this.labelPublisher);
            this.groupBox1.Controls.Add(this.inputAuthors);
            this.groupBox1.Controls.Add(this.labelAuthor);
            this.groupBox1.Controls.Add(this.labelTitle);
            this.groupBox1.Controls.Add(this.inputTitle);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(439, 487);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // inputField
            // 
            this.inputField.Location = new System.Drawing.Point(7, 127);
            this.inputField.Name = "inputField";
            this.inputField.Size = new System.Drawing.Size(424, 23);
            this.inputField.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Dziedzina*";
            // 
            // labelInventoryNumber
            // 
            this.labelInventoryNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelInventoryNumber.AutoSize = true;
            this.labelInventoryNumber.Location = new System.Drawing.Point(4, 428);
            this.labelInventoryNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInventoryNumber.Name = "labelInventoryNumber";
            this.labelInventoryNumber.Size = new System.Drawing.Size(109, 15);
            this.labelInventoryNumber.TabIndex = 28;
            this.labelInventoryNumber.Text = "Numer inwentarza*";
            // 
            // inputInventoryNumber
            // 
            this.inputInventoryNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputInventoryNumber.Location = new System.Drawing.Point(7, 446);
            this.inputInventoryNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputInventoryNumber.Name = "inputInventoryNumber";
            this.inputInventoryNumber.Size = new System.Drawing.Size(424, 23);
            this.inputInventoryNumber.TabIndex = 10;
            // 
            // inputCategories
            // 
            this.inputCategories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputCategories.Location = new System.Drawing.Point(7, 171);
            this.inputCategories.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputCategories.Name = "inputCategories";
            this.inputCategories.Size = new System.Drawing.Size(424, 23);
            this.inputCategories.TabIndex = 4;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(4, 153);
            this.labelCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(57, 15);
            this.labelCategory.TabIndex = 20;
            this.labelCategory.Text = "Kategorie";
            // 
            // labelPageAmount
            // 
            this.labelPageAmount.AutoSize = true;
            this.labelPageAmount.Location = new System.Drawing.Point(4, 379);
            this.labelPageAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPageAmount.Name = "labelPageAmount";
            this.labelPageAmount.Size = new System.Drawing.Size(70, 15);
            this.labelPageAmount.TabIndex = 18;
            this.labelPageAmount.Text = "Liczba stron";
            // 
            // inputPageAmount
            // 
            this.inputPageAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPageAmount.Location = new System.Drawing.Point(7, 397);
            this.inputPageAmount.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputPageAmount.Name = "inputPageAmount";
            this.inputPageAmount.Size = new System.Drawing.Size(424, 23);
            this.inputPageAmount.TabIndex = 9;
            // 
            // inputPubYear
            // 
            this.inputPubYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPubYear.Location = new System.Drawing.Point(7, 262);
            this.inputPubYear.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputPubYear.Name = "inputPubYear";
            this.inputPubYear.Size = new System.Drawing.Size(424, 23);
            this.inputPubYear.TabIndex = 6;
            // 
            // labelPublicationYear
            // 
            this.labelPublicationYear.AutoSize = true;
            this.labelPublicationYear.Location = new System.Drawing.Point(4, 244);
            this.labelPublicationYear.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPublicationYear.Name = "labelPublicationYear";
            this.labelPublicationYear.Size = new System.Drawing.Size(81, 15);
            this.labelPublicationYear.TabIndex = 16;
            this.labelPublicationYear.Text = "Rok publikacji";
            // 
            // labelLanguage
            // 
            this.labelLanguage.AutoSize = true;
            this.labelLanguage.Location = new System.Drawing.Point(4, 334);
            this.labelLanguage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLanguage.Name = "labelLanguage";
            this.labelLanguage.Size = new System.Drawing.Size(69, 15);
            this.labelLanguage.TabIndex = 14;
            this.labelLanguage.Text = "Język tekstu";
            // 
            // inputLanguage
            // 
            this.inputLanguage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputLanguage.Location = new System.Drawing.Point(7, 352);
            this.inputLanguage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputLanguage.Name = "inputLanguage";
            this.inputLanguage.Size = new System.Drawing.Size(424, 23);
            this.inputLanguage.TabIndex = 8;
            // 
            // inputISBN
            // 
            this.inputISBN.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputISBN.Location = new System.Drawing.Point(7, 307);
            this.inputISBN.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputISBN.Name = "inputISBN";
            this.inputISBN.Size = new System.Drawing.Size(424, 23);
            this.inputISBN.TabIndex = 7;
            // 
            // labelISBN
            // 
            this.labelISBN.AutoSize = true;
            this.labelISBN.Location = new System.Drawing.Point(4, 289);
            this.labelISBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelISBN.Name = "labelISBN";
            this.labelISBN.Size = new System.Drawing.Size(32, 15);
            this.labelISBN.TabIndex = 12;
            this.labelISBN.Text = "ISBN";
            // 
            // inputPublisher
            // 
            this.inputPublisher.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPublisher.Location = new System.Drawing.Point(7, 217);
            this.inputPublisher.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputPublisher.Name = "inputPublisher";
            this.inputPublisher.Size = new System.Drawing.Size(424, 23);
            this.inputPublisher.TabIndex = 5;
            // 
            // labelPublisher
            // 
            this.labelPublisher.AutoSize = true;
            this.labelPublisher.Location = new System.Drawing.Point(4, 199);
            this.labelPublisher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPublisher.Name = "labelPublisher";
            this.labelPublisher.Size = new System.Drawing.Size(87, 15);
            this.labelPublisher.TabIndex = 10;
            this.labelPublisher.Text = "Wydawnictwo*";
            // 
            // inputAuthors
            // 
            this.inputAuthors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputAuthors.Location = new System.Drawing.Point(7, 83);
            this.inputAuthors.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputAuthors.Name = "inputAuthors";
            this.inputAuthors.Size = new System.Drawing.Size(424, 23);
            this.inputAuthors.TabIndex = 2;
            // 
            // labelAuthor
            // 
            this.labelAuthor.AutoSize = true;
            this.labelAuthor.Location = new System.Drawing.Point(4, 63);
            this.labelAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAuthor.Name = "labelAuthor";
            this.labelAuthor.Size = new System.Drawing.Size(53, 15);
            this.labelAuthor.TabIndex = 2;
            this.labelAuthor.Text = "Autorzy*";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(4, 18);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(37, 15);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Tytuł*";
            // 
            // inputTitle
            // 
            this.inputTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputTitle.Location = new System.Drawing.Point(7, 37);
            this.inputTitle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputTitle.Name = "inputTitle";
            this.inputTitle.Size = new System.Drawing.Size(424, 23);
            this.inputTitle.TabIndex = 1;
            // 
            // buttonDeleteEbook
            // 
            this.buttonDeleteEbook.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteEbook.Location = new System.Drawing.Point(214, 17);
            this.buttonDeleteEbook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDeleteEbook.Name = "buttonDeleteEbook";
            this.buttonDeleteEbook.Size = new System.Drawing.Size(104, 27);
            this.buttonDeleteEbook.TabIndex = 15;
            this.buttonDeleteEbook.Text = "Usuń plik z bazy";
            this.buttonDeleteEbook.UseVisualStyleBackColor = true;
            this.buttonDeleteEbook.Visible = false;
            this.buttonDeleteEbook.Click += new System.EventHandler(this.removeEbook_Click);
            // 
            // labelFilePath
            // 
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Location = new System.Drawing.Point(9, 50);
            this.labelFilePath.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFilePath.MaximumSize = new System.Drawing.Size(408, 0);
            this.labelFilePath.MinimumSize = new System.Drawing.Size(117, 0);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(117, 15);
            this.labelFilePath.TabIndex = 24;
            // 
            // buttonAddEbookFile
            // 
            this.buttonAddEbookFile.Enabled = false;
            this.buttonAddEbookFile.Location = new System.Drawing.Point(81, 17);
            this.buttonAddEbookFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddEbookFile.Name = "buttonAddEbookFile";
            this.buttonAddEbookFile.Size = new System.Drawing.Size(88, 27);
            this.buttonAddEbookFile.TabIndex = 14;
            this.buttonAddEbookFile.Text = "Dodaj plik";
            this.buttonAddEbookFile.UseVisualStyleBackColor = true;
            this.buttonAddEbookFile.Click += new System.EventHandler(this.buttonAddEbookFile_Click);
            // 
            // cbEbook
            // 
            this.cbEbook.AutoSize = true;
            this.cbEbook.Location = new System.Drawing.Point(9, 22);
            this.cbEbook.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbEbook.Name = "cbEbook";
            this.cbEbook.Size = new System.Drawing.Size(64, 19);
            this.cbEbook.TabIndex = 13;
            this.cbEbook.Text = "E-book";
            this.cbEbook.UseVisualStyleBackColor = true;
            this.cbEbook.CheckedChanged += new System.EventHandler(this.cbEbook_CheckedChanged);
            // 
            // openFileDialogEbook
            // 
            this.openFileDialogEbook.FileName = "openFileDialog1";
            this.openFileDialogEbook.Filter = "PDF|*.pdf";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox4);
            this.panel2.Controls.Add(this.groupBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(467, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(343, 746);
            this.panel2.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.buttonRestoreDefault);
            this.groupBox4.Controls.Add(this.buttonAddCover);
            this.groupBox4.Controls.Add(this.pictureBoxCover);
            this.groupBox4.Location = new System.Drawing.Point(8, 14);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(325, 487);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            // 
            // buttonRestoreDefault
            // 
            this.buttonRestoreDefault.Location = new System.Drawing.Point(6, 406);
            this.buttonRestoreDefault.Name = "buttonRestoreDefault";
            this.buttonRestoreDefault.Size = new System.Drawing.Size(312, 23);
            this.buttonRestoreDefault.TabIndex = 12;
            this.buttonRestoreDefault.Text = "Przywróć domyślną";
            this.buttonRestoreDefault.UseVisualStyleBackColor = true;
            this.buttonRestoreDefault.Click += new System.EventHandler(this.buttonRestoreDefault_Click);
            // 
            // buttonAddCover
            // 
            this.buttonAddCover.Location = new System.Drawing.Point(6, 377);
            this.buttonAddCover.Name = "buttonAddCover";
            this.buttonAddCover.Size = new System.Drawing.Size(312, 23);
            this.buttonAddCover.TabIndex = 11;
            this.buttonAddCover.Text = "Dodaj okładke";
            this.buttonAddCover.UseVisualStyleBackColor = true;
            this.buttonAddCover.Click += new System.EventHandler(this.buttonAddCover_Click);
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.Location = new System.Drawing.Point(6, 18);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(312, 353);
            this.pictureBoxCover.TabIndex = 0;
            this.pictureBoxCover.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbEbook);
            this.groupBox3.Controls.Add(this.buttonDeleteEbook);
            this.groupBox3.Controls.Add(this.labelFilePath);
            this.groupBox3.Controls.Add(this.buttonAddEbookFile);
            this.groupBox3.Location = new System.Drawing.Point(8, 507);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 164);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            // 
            // openFileDialogCover
            // 
            this.openFileDialogCover.FileName = "openFileDialog1";
            this.openFileDialogCover.Filter = "JPG|*.jpg|PNG|*.png";
            // 
            // BookCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(812, 746);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "BookCreatorForm";
            this.Text = "Nowa książka";
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox inputDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelPageAmount;
        private System.Windows.Forms.TextBox inputPageAmount;
        private System.Windows.Forms.TextBox inputPubYear;
        private System.Windows.Forms.Label labelPublicationYear;
        private System.Windows.Forms.Label labelLanguage;
        private System.Windows.Forms.TextBox inputLanguage;
        private System.Windows.Forms.TextBox inputISBN;
        private System.Windows.Forms.Label labelISBN;
        private System.Windows.Forms.TextBox inputPublisher;
        private System.Windows.Forms.Label labelPublisher;
        private System.Windows.Forms.TextBox inputAuthors;
        private System.Windows.Forms.Label labelAuthor;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox inputTitle;
        private System.Windows.Forms.TextBox inputCategories;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.CheckBox cbEbook;
        private System.Windows.Forms.Button buttonAddEbookFile;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.Label labelInventoryNumber;
        private System.Windows.Forms.TextBox inputInventoryNumber;
        private System.Windows.Forms.Button buttonDeleteEbook;
        private System.Windows.Forms.OpenFileDialog openFileDialogEbook;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button buttonRestoreDefault;
        private System.Windows.Forms.Button buttonAddCover;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialogCover;
        private System.Windows.Forms.TextBox inputField;
        private System.Windows.Forms.Label label2;
    }
}