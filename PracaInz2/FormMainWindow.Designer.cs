namespace UserInterfaceLibrary
{
    partial class FormMainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSettings = new UserInterfaceLibrary.MainMenuButton();
            this.buttonExam = new UserInterfaceLibrary.MainMenuButton();
            this.buttonManagement = new UserInterfaceLibrary.MainMenuButton();
            this.buttonCatalog = new UserInterfaceLibrary.MainMenuButton();
            this.buttonAccount = new UserInterfaceLibrary.MainMenuButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.desktopPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(137)))));
            this.panel1.Controls.Add(this.buttonSettings);
            this.panel1.Controls.Add(this.buttonExam);
            this.panel1.Controls.Add(this.buttonManagement);
            this.panel1.Controls.Add(this.buttonCatalog);
            this.panel1.Controls.Add(this.buttonAccount);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 138);
            this.panel1.TabIndex = 0;
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(137)))));
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSettings.ForeColor = System.Drawing.Color.White;
            this.buttonSettings.Image = global::UserInterfaceLibrary.Icons.SettingsIcon;
            this.buttonSettings.Location = new System.Drawing.Point(951, 0);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Size = new System.Drawing.Size(108, 138);
            this.buttonSettings.TabIndex = 4;
            this.buttonSettings.Text = "Ustawienia";
            this.buttonSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonSettings.UseVisualStyleBackColor = false;
            this.buttonSettings.Visible = false;
            this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
            // 
            // buttonExam
            // 
            this.buttonExam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(137)))));
            this.buttonExam.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonExam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonExam.ForeColor = System.Drawing.Color.White;
            this.buttonExam.Image = global::UserInterfaceLibrary.Icons.ExamModuleIcon;
            this.buttonExam.Location = new System.Drawing.Point(704, 0);
            this.buttonExam.Name = "buttonExam";
            this.buttonExam.Size = new System.Drawing.Size(157, 138);
            this.buttonExam.TabIndex = 3;
            this.buttonExam.Text = "Egzaminy";
            this.buttonExam.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonExam.UseVisualStyleBackColor = false;
            this.buttonExam.Visible = false;
            this.buttonExam.Click += new System.EventHandler(this.buttonExams_Click);
            // 
            // buttonManagement
            // 
            this.buttonManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(137)))));
            this.buttonManagement.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonManagement.ForeColor = System.Drawing.Color.White;
            this.buttonManagement.Image = global::UserInterfaceLibrary.Icons.ManagementModuleIcon;
            this.buttonManagement.Location = new System.Drawing.Point(547, 0);
            this.buttonManagement.Name = "buttonManagement";
            this.buttonManagement.Size = new System.Drawing.Size(157, 138);
            this.buttonManagement.TabIndex = 2;
            this.buttonManagement.Text = "Zarządzanie";
            this.buttonManagement.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonManagement.UseVisualStyleBackColor = false;
            this.buttonManagement.Visible = false;
            this.buttonManagement.Click += new System.EventHandler(this.buttonManagement_Click);
            // 
            // buttonCatalog
            // 
            this.buttonCatalog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(137)))));
            this.buttonCatalog.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCatalog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCatalog.ForeColor = System.Drawing.Color.White;
            this.buttonCatalog.Image = global::UserInterfaceLibrary.Icons.CatalogModuleIcon;
            this.buttonCatalog.Location = new System.Drawing.Point(390, 0);
            this.buttonCatalog.Name = "buttonCatalog";
            this.buttonCatalog.Size = new System.Drawing.Size(157, 138);
            this.buttonCatalog.TabIndex = 1;
            this.buttonCatalog.Text = "Katalog";
            this.buttonCatalog.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonCatalog.UseVisualStyleBackColor = false;
            this.buttonCatalog.Visible = false;
            this.buttonCatalog.Click += new System.EventHandler(this.buttonCatalog_Click);
            // 
            // buttonAccount
            // 
            this.buttonAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(137)))));
            this.buttonAccount.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonAccount.ForeColor = System.Drawing.Color.White;
            this.buttonAccount.Image = global::UserInterfaceLibrary.Icons.UserAccountIcon;
            this.buttonAccount.Location = new System.Drawing.Point(233, 0);
            this.buttonAccount.Name = "buttonAccount";
            this.buttonAccount.Size = new System.Drawing.Size(157, 138);
            this.buttonAccount.TabIndex = 0;
            this.buttonAccount.Text = "Konto";
            this.buttonAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAccount.UseVisualStyleBackColor = false;
            this.buttonAccount.Click += new System.EventHandler(this.buttonAccount_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(1)))), ((int)(((byte)(93)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 138);
            this.panel3.TabIndex = 0;
            // 
            // desktopPanel
            // 
            this.desktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.desktopPanel.Location = new System.Drawing.Point(0, 138);
            this.desktopPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.desktopPanel.Name = "desktopPanel";
            this.desktopPanel.Size = new System.Drawing.Size(1059, 523);
            this.desktopPanel.TabIndex = 1;
            // 
            // FormMainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 661);
            this.Controls.Add(this.desktopPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1075, 700);
            this.Name = "FormMainWindow";
            this.Text = "System Biblioteczny";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel desktopPanel;
        //private MainMenuButton buttonAccount2;
        //private MainMenuButton buttonExam2;
        //private MainMenuButton buttonManagement2;
        //private MainMenuButton buttonCatalog2;
        private MainMenuButton buttonAccount;
        private MainMenuButton buttonExam;
        private MainMenuButton buttonManagement;
        private MainMenuButton buttonCatalog;
        private MainMenuButton buttonSettings;
    }
}

