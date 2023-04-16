namespace UserInterfaceLibrary
{
    partial class SettingsForm
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
            this.buttonChangeSettings = new System.Windows.Forms.Button();
            this.buttonChangePassword = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.buttonChangeSettings);
            this.panel1.Controls.Add(this.buttonChangePassword);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 94);
            this.panel1.TabIndex = 0;
            // 
            // buttonChangeSettings
            // 
            this.buttonChangeSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonChangeSettings.Location = new System.Drawing.Point(0, 46);
            this.buttonChangeSettings.Name = "buttonChangeSettings";
            this.buttonChangeSettings.Size = new System.Drawing.Size(223, 46);
            this.buttonChangeSettings.TabIndex = 1;
            this.buttonChangeSettings.Text = "Zmień ustawienia połączenia";
            this.buttonChangeSettings.UseVisualStyleBackColor = true;
            this.buttonChangeSettings.Visible = false;
            this.buttonChangeSettings.Click += new System.EventHandler(this.buttonChangeSettings_Click);
            // 
            // buttonChangePassword
            // 
            this.buttonChangePassword.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonChangePassword.Location = new System.Drawing.Point(0, 0);
            this.buttonChangePassword.Name = "buttonChangePassword";
            this.buttonChangePassword.Size = new System.Drawing.Size(223, 46);
            this.buttonChangePassword.TabIndex = 0;
            this.buttonChangePassword.Text = "Zmień hasło";
            this.buttonChangePassword.UseVisualStyleBackColor = true;
            this.buttonChangePassword.Click += new System.EventHandler(this.buttonChangePassword_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 117);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingsForm";
            this.Text = "Ustawienia";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonChangeSettings;
        private System.Windows.Forms.Button buttonChangePassword;
    }
}