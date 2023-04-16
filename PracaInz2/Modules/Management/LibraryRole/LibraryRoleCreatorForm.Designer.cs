namespace UserInterfaceLibrary
{
    partial class LibraryRoleCreatorForm
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
            this.inputRoleName = new System.Windows.Forms.TextBox();
            this.labelRoleName = new System.Windows.Forms.Label();
            this.checkBoxAdministrator = new System.Windows.Forms.CheckBox();
            this.checkBoxManager = new System.Windows.Forms.CheckBox();
            this.panelManager = new System.Windows.Forms.Panel();
            this.checkBoxExaminer = new System.Windows.Forms.CheckBox();
            this.panelExaminer = new System.Windows.Forms.Panel();
            this.checkBoxViewAllExamResults = new System.Windows.Forms.CheckBox();
            this.checkBoxCreateExam = new System.Windows.Forms.CheckBox();
            this.checkBoxLibrarian = new System.Windows.Forms.CheckBox();
            this.PanelLibrarian = new System.Windows.Forms.Panel();
            this.checkBoxRemovePatrons = new System.Windows.Forms.CheckBox();
            this.checkBoxEditPatrons = new System.Windows.Forms.CheckBox();
            this.checkBoxAddPatrons = new System.Windows.Forms.CheckBox();
            this.checkBoxRemoveBooks = new System.Windows.Forms.CheckBox();
            this.checkBoxEditBooks = new System.Windows.Forms.CheckBox();
            this.checkBoxAddBooks = new System.Windows.Forms.CheckBox();
            this.checkBoxPatron = new System.Windows.Forms.CheckBox();
            this.panelPatron = new System.Windows.Forms.Panel();
            this.checkBoxAttemptExam = new System.Windows.Forms.CheckBox();
            this.checkBoxBorrowEbookByself = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelExaminer.SuspendLayout();
            this.PanelLibrarian.SuspendLayout();
            this.panelPatron.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputRoleName
            // 
            this.inputRoleName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputRoleName.Location = new System.Drawing.Point(74, 14);
            this.inputRoleName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputRoleName.Name = "inputRoleName";
            this.inputRoleName.Size = new System.Drawing.Size(367, 23);
            this.inputRoleName.TabIndex = 21;
            this.inputRoleName.TextChanged += new System.EventHandler(this.inputRoleName_TextChanged);
            // 
            // labelRoleName
            // 
            this.labelRoleName.AutoSize = true;
            this.labelRoleName.Location = new System.Drawing.Point(16, 17);
            this.labelRoleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRoleName.Name = "labelRoleName";
            this.labelRoleName.Size = new System.Drawing.Size(45, 15);
            this.labelRoleName.TabIndex = 20;
            this.labelRoleName.Text = "Nazwa:";
            // 
            // checkBoxAdministrator
            // 
            this.checkBoxAdministrator.Location = new System.Drawing.Point(20, 386);
            this.checkBoxAdministrator.Name = "checkBoxAdministrator";
            this.checkBoxAdministrator.Size = new System.Drawing.Size(104, 24);
            this.checkBoxAdministrator.TabIndex = 25;
            this.checkBoxAdministrator.Text = "Administrator";
            this.checkBoxAdministrator.CheckedChanged += new System.EventHandler(this.checkBoxAdministrator_CheckedChanged);
            // 
            // checkBoxManager
            // 
            this.checkBoxManager.AutoSize = true;
            this.checkBoxManager.Location = new System.Drawing.Point(20, 361);
            this.checkBoxManager.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxManager.Name = "checkBoxManager";
            this.checkBoxManager.Size = new System.Drawing.Size(78, 19);
            this.checkBoxManager.TabIndex = 18;
            this.checkBoxManager.Text = "Menedżer";
            this.checkBoxManager.UseVisualStyleBackColor = true;
            this.checkBoxManager.CheckedChanged += new System.EventHandler(this.checkBoxManager_CheckedChanged);
            // 
            // panelManager
            // 
            this.panelManager.Enabled = false;
            this.panelManager.Location = new System.Drawing.Point(20, 388);
            this.panelManager.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelManager.Name = "panelManager";
            this.panelManager.Size = new System.Drawing.Size(428, 0);
            this.panelManager.TabIndex = 17;
            // 
            // checkBoxExaminer
            // 
            this.checkBoxExaminer.AutoSize = true;
            this.checkBoxExaminer.Location = new System.Drawing.Point(20, 271);
            this.checkBoxExaminer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxExaminer.Name = "checkBoxExaminer";
            this.checkBoxExaminer.Size = new System.Drawing.Size(92, 19);
            this.checkBoxExaminer.TabIndex = 16;
            this.checkBoxExaminer.Text = "Egzaminator";
            this.checkBoxExaminer.UseVisualStyleBackColor = true;
            this.checkBoxExaminer.CheckedChanged += new System.EventHandler(this.checkBoxExaminer_CheckedChanged);
            // 
            // panelExaminer
            // 
            this.panelExaminer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExaminer.Controls.Add(this.checkBoxViewAllExamResults);
            this.panelExaminer.Controls.Add(this.checkBoxCreateExam);
            this.panelExaminer.Enabled = false;
            this.panelExaminer.Location = new System.Drawing.Point(20, 298);
            this.panelExaminer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelExaminer.Name = "panelExaminer";
            this.panelExaminer.Size = new System.Drawing.Size(428, 57);
            this.panelExaminer.TabIndex = 15;
            // 
            // checkBoxViewAllExamResults
            // 
            this.checkBoxViewAllExamResults.AutoSize = true;
            this.checkBoxViewAllExamResults.Location = new System.Drawing.Point(7, 30);
            this.checkBoxViewAllExamResults.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxViewAllExamResults.Name = "checkBoxViewAllExamResults";
            this.checkBoxViewAllExamResults.Size = new System.Drawing.Size(268, 19);
            this.checkBoxViewAllExamResults.TabIndex = 1;
            this.checkBoxViewAllExamResults.Text = "Wyświetlanie wyników wszystkich egzaminów";
            this.checkBoxViewAllExamResults.UseVisualStyleBackColor = true;
            this.checkBoxViewAllExamResults.CheckedChanged += new System.EventHandler(this.checkBoxViewAllExamResults_CheckedChanged);
            // 
            // checkBoxCreateExam
            // 
            this.checkBoxCreateExam.AutoSize = true;
            this.checkBoxCreateExam.Location = new System.Drawing.Point(7, 3);
            this.checkBoxCreateExam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxCreateExam.Name = "checkBoxCreateExam";
            this.checkBoxCreateExam.Size = new System.Drawing.Size(142, 19);
            this.checkBoxCreateExam.TabIndex = 0;
            this.checkBoxCreateExam.Text = "Tworzenie egzaminów";
            this.checkBoxCreateExam.UseVisualStyleBackColor = true;
            this.checkBoxCreateExam.CheckedChanged += new System.EventHandler(this.checkBoxCreateExam_CheckedChanged);
            // 
            // checkBoxLibrarian
            // 
            this.checkBoxLibrarian.AutoSize = true;
            this.checkBoxLibrarian.Location = new System.Drawing.Point(20, 152);
            this.checkBoxLibrarian.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxLibrarian.Name = "checkBoxLibrarian";
            this.checkBoxLibrarian.Size = new System.Drawing.Size(87, 19);
            this.checkBoxLibrarian.TabIndex = 14;
            this.checkBoxLibrarian.Text = "Bibliotekarz";
            this.checkBoxLibrarian.UseVisualStyleBackColor = true;
            this.checkBoxLibrarian.CheckedChanged += new System.EventHandler(this.checkBoxLibrarian_CheckedChanged);
            // 
            // PanelLibrarian
            // 
            this.PanelLibrarian.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelLibrarian.Controls.Add(this.checkBoxRemovePatrons);
            this.PanelLibrarian.Controls.Add(this.checkBoxEditPatrons);
            this.PanelLibrarian.Controls.Add(this.checkBoxAddPatrons);
            this.PanelLibrarian.Controls.Add(this.checkBoxRemoveBooks);
            this.PanelLibrarian.Controls.Add(this.checkBoxEditBooks);
            this.PanelLibrarian.Controls.Add(this.checkBoxAddBooks);
            this.PanelLibrarian.Enabled = false;
            this.PanelLibrarian.Location = new System.Drawing.Point(20, 179);
            this.PanelLibrarian.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.PanelLibrarian.Name = "PanelLibrarian";
            this.PanelLibrarian.Size = new System.Drawing.Size(428, 85);
            this.PanelLibrarian.TabIndex = 13;
            // 
            // checkBoxRemovePatrons
            // 
            this.checkBoxRemovePatrons.AutoSize = true;
            this.checkBoxRemovePatrons.Location = new System.Drawing.Point(191, 57);
            this.checkBoxRemovePatrons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxRemovePatrons.Name = "checkBoxRemovePatrons";
            this.checkBoxRemovePatrons.Size = new System.Drawing.Size(142, 19);
            this.checkBoxRemovePatrons.TabIndex = 5;
            this.checkBoxRemovePatrons.Text = "Usuwanie czytelników";
            this.checkBoxRemovePatrons.UseVisualStyleBackColor = true;
            this.checkBoxRemovePatrons.CheckedChanged += new System.EventHandler(this.checkBoxRemovePatrons_CheckedChanged);
            // 
            // checkBoxEditPatrons
            // 
            this.checkBoxEditPatrons.AutoSize = true;
            this.checkBoxEditPatrons.Location = new System.Drawing.Point(191, 30);
            this.checkBoxEditPatrons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxEditPatrons.Name = "checkBoxEditPatrons";
            this.checkBoxEditPatrons.Size = new System.Drawing.Size(152, 19);
            this.checkBoxEditPatrons.TabIndex = 4;
            this.checkBoxEditPatrons.Text = "Edytowanie czytelników";
            this.checkBoxEditPatrons.UseVisualStyleBackColor = true;
            this.checkBoxEditPatrons.CheckedChanged += new System.EventHandler(this.checkBoxEditPatrons_CheckedChanged);
            // 
            // checkBoxAddPatrons
            // 
            this.checkBoxAddPatrons.AutoSize = true;
            this.checkBoxAddPatrons.Location = new System.Drawing.Point(191, 3);
            this.checkBoxAddPatrons.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxAddPatrons.Name = "checkBoxAddPatrons";
            this.checkBoxAddPatrons.Size = new System.Drawing.Size(150, 19);
            this.checkBoxAddPatrons.TabIndex = 3;
            this.checkBoxAddPatrons.Text = "Dodawanie czytelników";
            this.checkBoxAddPatrons.UseVisualStyleBackColor = true;
            this.checkBoxAddPatrons.CheckedChanged += new System.EventHandler(this.checkBoxAddPatrons_CheckedChanged);
            // 
            // checkBoxRemoveBooks
            // 
            this.checkBoxRemoveBooks.AutoSize = true;
            this.checkBoxRemoveBooks.Location = new System.Drawing.Point(7, 57);
            this.checkBoxRemoveBooks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxRemoveBooks.Name = "checkBoxRemoveBooks";
            this.checkBoxRemoveBooks.Size = new System.Drawing.Size(117, 19);
            this.checkBoxRemoveBooks.TabIndex = 2;
            this.checkBoxRemoveBooks.Text = "Usuwanie książek";
            this.checkBoxRemoveBooks.UseVisualStyleBackColor = true;
            this.checkBoxRemoveBooks.CheckedChanged += new System.EventHandler(this.checkBoxRemoveBooks_CheckedChanged);
            // 
            // checkBoxEditBooks
            // 
            this.checkBoxEditBooks.AutoSize = true;
            this.checkBoxEditBooks.Location = new System.Drawing.Point(7, 30);
            this.checkBoxEditBooks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxEditBooks.Name = "checkBoxEditBooks";
            this.checkBoxEditBooks.Size = new System.Drawing.Size(127, 19);
            this.checkBoxEditBooks.TabIndex = 1;
            this.checkBoxEditBooks.Text = "Edytowanie książek";
            this.checkBoxEditBooks.UseVisualStyleBackColor = true;
            this.checkBoxEditBooks.CheckedChanged += new System.EventHandler(this.checkBoxEditBooks_CheckedChanged);
            // 
            // checkBoxAddBooks
            // 
            this.checkBoxAddBooks.AutoSize = true;
            this.checkBoxAddBooks.Location = new System.Drawing.Point(7, 3);
            this.checkBoxAddBooks.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxAddBooks.Name = "checkBoxAddBooks";
            this.checkBoxAddBooks.Size = new System.Drawing.Size(125, 19);
            this.checkBoxAddBooks.TabIndex = 0;
            this.checkBoxAddBooks.Text = "Dodawanie książek";
            this.checkBoxAddBooks.UseVisualStyleBackColor = true;
            this.checkBoxAddBooks.CheckedChanged += new System.EventHandler(this.checkBoxAddBooks_CheckedChanged);
            // 
            // checkBoxPatron
            // 
            this.checkBoxPatron.AutoSize = true;
            this.checkBoxPatron.Location = new System.Drawing.Point(20, 62);
            this.checkBoxPatron.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxPatron.Name = "checkBoxPatron";
            this.checkBoxPatron.Size = new System.Drawing.Size(74, 19);
            this.checkBoxPatron.TabIndex = 12;
            this.checkBoxPatron.Text = "Czytelnik";
            this.checkBoxPatron.UseVisualStyleBackColor = true;
            this.checkBoxPatron.CheckedChanged += new System.EventHandler(this.checkBoxPatron_CheckedChanged);
            // 
            // panelPatron
            // 
            this.panelPatron.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPatron.Controls.Add(this.checkBoxAttemptExam);
            this.panelPatron.Controls.Add(this.checkBoxBorrowEbookByself);
            this.panelPatron.Enabled = false;
            this.panelPatron.Location = new System.Drawing.Point(20, 87);
            this.panelPatron.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelPatron.Name = "panelPatron";
            this.panelPatron.Size = new System.Drawing.Size(428, 59);
            this.panelPatron.TabIndex = 11;
            // 
            // checkBoxAttemptExam
            // 
            this.checkBoxAttemptExam.AutoSize = true;
            this.checkBoxAttemptExam.Location = new System.Drawing.Point(7, 30);
            this.checkBoxAttemptExam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxAttemptExam.Name = "checkBoxAttemptExam";
            this.checkBoxAttemptExam.Size = new System.Drawing.Size(169, 19);
            this.checkBoxAttemptExam.TabIndex = 1;
            this.checkBoxAttemptExam.Text = "Rozwiązywanie egzaminów";
            this.checkBoxAttemptExam.UseVisualStyleBackColor = true;
            this.checkBoxAttemptExam.CheckedChanged += new System.EventHandler(this.checkBoxAttemptExam_CheckedChanged);
            // 
            // checkBoxBorrowEbookByself
            // 
            this.checkBoxBorrowEbookByself.AutoSize = true;
            this.checkBoxBorrowEbookByself.Location = new System.Drawing.Point(7, 3);
            this.checkBoxBorrowEbookByself.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxBorrowEbookByself.Name = "checkBoxBorrowEbookByself";
            this.checkBoxBorrowEbookByself.Size = new System.Drawing.Size(226, 19);
            this.checkBoxBorrowEbookByself.TabIndex = 0;
            this.checkBoxBorrowEbookByself.Text = "Samodzielne wypożyczanie e-booków";
            this.checkBoxBorrowEbookByself.UseVisualStyleBackColor = true;
            this.checkBoxBorrowEbookByself.CheckedChanged += new System.EventHandler(this.checkBoxSearchCatalog_CheckedChanged);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSave.Location = new System.Drawing.Point(19, 483);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(88, 27);
            this.buttonSave.TabIndex = 22;
            this.buttonSave.Text = "Zapisz";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(360, 483);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(88, 27);
            this.buttonCancel.TabIndex = 24;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Visible = false;
            // 
            // LibraryRoleCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(461, 522);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.inputRoleName);
            this.Controls.Add(this.labelRoleName);
            this.Controls.Add(this.checkBoxAdministrator);
            this.Controls.Add(this.checkBoxManager);
            this.Controls.Add(this.panelManager);
            this.Controls.Add(this.checkBoxExaminer);
            this.Controls.Add(this.panelExaminer);
            this.Controls.Add(this.checkBoxLibrarian);
            this.Controls.Add(this.PanelLibrarian);
            this.Controls.Add(this.checkBoxPatron);
            this.Controls.Add(this.panelPatron);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "LibraryRoleCreatorForm";
            this.Text = "Nowa rola";
            this.panelExaminer.ResumeLayout(false);
            this.panelExaminer.PerformLayout();
            this.PanelLibrarian.ResumeLayout(false);
            this.PanelLibrarian.PerformLayout();
            this.panelPatron.ResumeLayout(false);
            this.panelPatron.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputRoleName;
        private System.Windows.Forms.Label labelRoleName;
        private System.Windows.Forms.CheckBox checkBoxAdministrator;
        private System.Windows.Forms.CheckBox checkBoxManager;
        private System.Windows.Forms.Panel panelManager;
        private System.Windows.Forms.CheckBox checkBoxExaminer;
        private System.Windows.Forms.Panel panelExaminer;
        private System.Windows.Forms.CheckBox checkBoxViewAllExamResults;
        private System.Windows.Forms.CheckBox checkBoxCreateExam;
        private System.Windows.Forms.CheckBox checkBoxLibrarian;
        private System.Windows.Forms.Panel PanelLibrarian;
        private System.Windows.Forms.CheckBox checkBoxRemovePatrons;
        private System.Windows.Forms.CheckBox checkBoxEditPatrons;
        private System.Windows.Forms.CheckBox checkBoxAddPatrons;
        private System.Windows.Forms.CheckBox checkBoxRemoveBooks;
        private System.Windows.Forms.CheckBox checkBoxEditBooks;
        private System.Windows.Forms.CheckBox checkBoxAddBooks;
        private System.Windows.Forms.CheckBox checkBoxPatron;
        private System.Windows.Forms.Panel panelPatron;
        private System.Windows.Forms.CheckBox checkBoxAttemptExam;
        private System.Windows.Forms.CheckBox checkBoxBorrowEbookByself;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}