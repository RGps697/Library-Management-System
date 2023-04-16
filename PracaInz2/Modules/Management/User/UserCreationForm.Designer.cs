namespace UserInterfaceLibrary
{
    partial class UserCreationForm
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
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCancel = new System.Windows.Forms.Button();
            this.ButtonCreate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbRole = new System.Windows.Forms.ComboBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.inputFirstName = new System.Windows.Forms.TextBox();
            this.labelSurname = new System.Windows.Forms.Label();
            this.inputSurname = new System.Windows.Forms.TextBox();
            this.labelPhoneNumber = new System.Windows.Forms.Label();
            this.inputPhoneNumber = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.inputEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(246, 281);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(88, 27);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // ButtonCreate
            // 
            this.ButtonCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ButtonCreate.Location = new System.Drawing.Point(14, 281);
            this.ButtonCreate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ButtonCreate.Name = "ButtonCreate";
            this.ButtonCreate.Size = new System.Drawing.Size(88, 27);
            this.ButtonCreate.TabIndex = 0;
            this.ButtonCreate.Text = "Zapisz";
            this.ButtonCreate.UseVisualStyleBackColor = true;
            this.ButtonCreate.Click += new System.EventHandler(this.ButtonCreate_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.cbRole);
            this.panel1.Controls.Add(this.labelFirstName);
            this.panel1.Controls.Add(this.labelRole);
            this.panel1.Controls.Add(this.inputFirstName);
            this.panel1.Controls.Add(this.labelSurname);
            this.panel1.Controls.Add(this.inputSurname);
            this.panel1.Controls.Add(this.labelPhoneNumber);
            this.panel1.Controls.Add(this.inputPhoneNumber);
            this.panel1.Controls.Add(this.labelEmail);
            this.panel1.Controls.Add(this.inputEmail);
            this.panel1.Location = new System.Drawing.Point(14, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(320, 251);
            this.panel1.TabIndex = 9;
            // 
            // cbRole
            // 
            this.cbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRole.FormattingEnabled = true;
            this.cbRole.Location = new System.Drawing.Point(22, 211);
            this.cbRole.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cbRole.Name = "cbRole";
            this.cbRole.Size = new System.Drawing.Size(140, 23);
            this.cbRole.TabIndex = 26;
            // 
            // labelFirstName
            // 
            this.labelFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(22, 14);
            this.labelFirstName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(35, 15);
            this.labelFirstName.TabIndex = 13;
            this.labelFirstName.Text = "Imię*";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(22, 193);
            this.labelRole.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(33, 15);
            this.labelRole.TabIndex = 10;
            this.labelRole.Text = "Rola:";
            // 
            // inputFirstName
            // 
            this.inputFirstName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFirstName.Location = new System.Drawing.Point(22, 32);
            this.inputFirstName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputFirstName.Name = "inputFirstName";
            this.inputFirstName.Size = new System.Drawing.Size(274, 23);
            this.inputFirstName.TabIndex = 14;
            // 
            // labelSurname
            // 
            this.labelSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSurname.AutoSize = true;
            this.labelSurname.Location = new System.Drawing.Point(22, 59);
            this.labelSurname.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(62, 15);
            this.labelSurname.TabIndex = 15;
            this.labelSurname.Text = "Nazwisko*";
            // 
            // inputSurname
            // 
            this.inputSurname.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputSurname.Location = new System.Drawing.Point(22, 77);
            this.inputSurname.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputSurname.Name = "inputSurname";
            this.inputSurname.Size = new System.Drawing.Size(274, 23);
            this.inputSurname.TabIndex = 16;
            // 
            // labelPhoneNumber
            // 
            this.labelPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPhoneNumber.AutoSize = true;
            this.labelPhoneNumber.Location = new System.Drawing.Point(22, 104);
            this.labelPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhoneNumber.Name = "labelPhoneNumber";
            this.labelPhoneNumber.Size = new System.Drawing.Size(91, 15);
            this.labelPhoneNumber.TabIndex = 17;
            this.labelPhoneNumber.Text = "Numer telefonu";
            // 
            // inputPhoneNumber
            // 
            this.inputPhoneNumber.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputPhoneNumber.Location = new System.Drawing.Point(22, 122);
            this.inputPhoneNumber.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputPhoneNumber.Name = "inputPhoneNumber";
            this.inputPhoneNumber.Size = new System.Drawing.Size(274, 23);
            this.inputPhoneNumber.TabIndex = 18;
            // 
            // labelEmail
            // 
            this.labelEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(22, 149);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(46, 15);
            this.labelEmail.TabIndex = 19;
            this.labelEmail.Text = "E-mail*";
            // 
            // inputEmail
            // 
            this.inputEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputEmail.Location = new System.Drawing.Point(22, 167);
            this.inputEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputEmail.Name = "inputEmail";
            this.inputEmail.Size = new System.Drawing.Size(274, 23);
            this.inputEmail.TabIndex = 20;
            // 
            // UserCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(350, 320);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonCreate);
            this.Controls.Add(this.buttonCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "UserCreationForm";
            this.Text = "Nowy użytkownik";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button ButtonCreate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox inputFirstName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.TextBox inputSurname;
        private System.Windows.Forms.Label labelPhoneNumber;
        private System.Windows.Forms.TextBox inputPhoneNumber;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox inputEmail;
        private System.Windows.Forms.ComboBox cbRole;
        private System.Windows.Forms.Label labelRole;
    }
}