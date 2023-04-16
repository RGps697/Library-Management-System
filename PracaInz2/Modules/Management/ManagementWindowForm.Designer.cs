namespace UserInterfaceLibrary
{
    partial class ManagementWindowForm
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
            this.buttonRoles = new UserInterfaceLibrary.ToolMenuButton();
            this.buttonUsers = new UserInterfaceLibrary.ToolMenuButton();
            this.buttonBooks = new UserInterfaceLibrary.ToolMenuButton();
            this.buttonBorrowings = new UserInterfaceLibrary.ToolMenuButton();
            this.managementPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonRoles);
            this.panel1.Controls.Add(this.buttonUsers);
            this.panel1.Controls.Add(this.buttonBooks);
            this.panel1.Controls.Add(this.buttonBorrowings);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 519);
            this.panel1.TabIndex = 0;
            // 
            // buttonRoles
            // 
            this.buttonRoles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRoles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(219)))));
            this.buttonRoles.BorderColor = System.Drawing.Color.Empty;
            this.buttonRoles.BorderRadius = 10;
            this.buttonRoles.BorderSize = 0;
            this.buttonRoles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(137)))));
            this.buttonRoles.FlatAppearance.BorderSize = 0;
            this.buttonRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRoles.ForeColor = System.Drawing.Color.White;
            this.buttonRoles.Location = new System.Drawing.Point(12, 153);
            this.buttonRoles.Name = "buttonRoles";
            this.buttonRoles.Size = new System.Drawing.Size(185, 42);
            this.buttonRoles.TabIndex = 3;
            this.buttonRoles.Text = "Role";
            this.buttonRoles.TextColor = System.Drawing.Color.White;
            this.buttonRoles.UseVisualStyleBackColor = false;
            this.buttonRoles.Visible = false;
            this.buttonRoles.Click += new System.EventHandler(this.buttonRoles_Click);
            // 
            // buttonUsers
            // 
            this.buttonUsers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(219)))));
            this.buttonUsers.BorderColor = System.Drawing.Color.Empty;
            this.buttonUsers.BorderRadius = 10;
            this.buttonUsers.BorderSize = 0;
            this.buttonUsers.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(137)))));
            this.buttonUsers.FlatAppearance.BorderSize = 0;
            this.buttonUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonUsers.ForeColor = System.Drawing.Color.White;
            this.buttonUsers.Location = new System.Drawing.Point(12, 12);
            this.buttonUsers.Name = "buttonUsers";
            this.buttonUsers.Size = new System.Drawing.Size(185, 42);
            this.buttonUsers.TabIndex = 0;
            this.buttonUsers.Text = "Użytkownicy";
            this.buttonUsers.TextColor = System.Drawing.Color.White;
            this.buttonUsers.UseVisualStyleBackColor = false;
            this.buttonUsers.Visible = false;
            this.buttonUsers.Click += new System.EventHandler(this.buttonUsersForm_Click);
            // 
            // buttonBooks
            // 
            this.buttonBooks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(219)))));
            this.buttonBooks.BorderColor = System.Drawing.Color.Empty;
            this.buttonBooks.BorderRadius = 10;
            this.buttonBooks.BorderSize = 0;
            this.buttonBooks.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(137)))));
            this.buttonBooks.FlatAppearance.BorderSize = 0;
            this.buttonBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBooks.ForeColor = System.Drawing.Color.White;
            this.buttonBooks.Location = new System.Drawing.Point(12, 59);
            this.buttonBooks.Name = "buttonBooks";
            this.buttonBooks.Size = new System.Drawing.Size(185, 42);
            this.buttonBooks.TabIndex = 1;
            this.buttonBooks.Text = "Książki";
            this.buttonBooks.TextColor = System.Drawing.Color.White;
            this.buttonBooks.UseVisualStyleBackColor = false;
            this.buttonBooks.Visible = false;
            this.buttonBooks.Click += new System.EventHandler(this.buttonBooks_Click);
            // 
            // buttonBorrowings
            // 
            this.buttonBorrowings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBorrowings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(219)))));
            this.buttonBorrowings.BorderColor = System.Drawing.Color.Empty;
            this.buttonBorrowings.BorderRadius = 10;
            this.buttonBorrowings.BorderSize = 0;
            this.buttonBorrowings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(137)))));
            this.buttonBorrowings.FlatAppearance.BorderSize = 0;
            this.buttonBorrowings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrowings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBorrowings.ForeColor = System.Drawing.Color.White;
            this.buttonBorrowings.Location = new System.Drawing.Point(12, 106);
            this.buttonBorrowings.Name = "buttonBorrowings";
            this.buttonBorrowings.Size = new System.Drawing.Size(185, 42);
            this.buttonBorrowings.TabIndex = 2;
            this.buttonBorrowings.Text = "Wypożyczenia";
            this.buttonBorrowings.TextColor = System.Drawing.Color.White;
            this.buttonBorrowings.UseVisualStyleBackColor = false;
            this.buttonBorrowings.Visible = false;
            this.buttonBorrowings.Click += new System.EventHandler(this.buttonBorrowings_Click);
            // 
            // managementPanel
            // 
            this.managementPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.managementPanel.Location = new System.Drawing.Point(204, 0);
            this.managementPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.managementPanel.Name = "managementPanel";
            this.managementPanel.Size = new System.Drawing.Size(729, 519);
            this.managementPanel.TabIndex = 1;
            // 
            // ManagementWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.managementPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ManagementWindowForm";
            this.Text = "FormManagement";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel managementPanel;
        private ToolMenuButton buttonRoles;
        private ToolMenuButton buttonBorrowings;
        private ToolMenuButton buttonBooks;
        private ToolMenuButton buttonUsers;
    }
}