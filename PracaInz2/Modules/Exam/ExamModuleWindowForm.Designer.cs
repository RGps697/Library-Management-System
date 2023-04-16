namespace UserInterfaceLibrary
{
    partial class ExamModuleWindowForm
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
            this.buttonResults = new UserInterfaceLibrary.ToolMenuButton();
            this.buttonManagement = new UserInterfaceLibrary.ToolMenuButton();
            this.buttonBrowse = new UserInterfaceLibrary.ToolMenuButton();
            this.ModuleDisplayPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonResults);
            this.panel1.Controls.Add(this.buttonManagement);
            this.panel1.Controls.Add(this.buttonBrowse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(204, 519);
            this.panel1.TabIndex = 1;
            // 
            // buttonResults
            // 
            this.buttonResults.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(219)))));
            this.buttonResults.BorderColor = System.Drawing.Color.Empty;
            this.buttonResults.BorderRadius = 10;
            this.buttonResults.BorderSize = 0;
            this.buttonResults.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(137)))));
            this.buttonResults.FlatAppearance.BorderSize = 0;
            this.buttonResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonResults.ForeColor = System.Drawing.Color.White;
            this.buttonResults.Location = new System.Drawing.Point(12, 108);
            this.buttonResults.Name = "buttonResults";
            this.buttonResults.Size = new System.Drawing.Size(185, 42);
            this.buttonResults.TabIndex = 2;
            this.buttonResults.Text = "Wyniki";
            this.buttonResults.TextColor = System.Drawing.Color.White;
            this.buttonResults.UseVisualStyleBackColor = false;
            this.buttonResults.Visible = false;
            this.buttonResults.Click += new System.EventHandler(this.buttonResults_Click);
            // 
            // buttonManagement
            // 
            this.buttonManagement.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonManagement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(219)))));
            this.buttonManagement.BorderColor = System.Drawing.Color.Empty;
            this.buttonManagement.BorderRadius = 10;
            this.buttonManagement.BorderSize = 0;
            this.buttonManagement.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(137)))));
            this.buttonManagement.FlatAppearance.BorderSize = 0;
            this.buttonManagement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonManagement.ForeColor = System.Drawing.Color.White;
            this.buttonManagement.Location = new System.Drawing.Point(12, 60);
            this.buttonManagement.Name = "buttonManagement";
            this.buttonManagement.Size = new System.Drawing.Size(185, 42);
            this.buttonManagement.TabIndex = 1;
            this.buttonManagement.Text = "Zarządzanie";
            this.buttonManagement.TextColor = System.Drawing.Color.White;
            this.buttonManagement.UseVisualStyleBackColor = false;
            this.buttonManagement.Visible = false;
            this.buttonManagement.Click += new System.EventHandler(this.buttonManagement_Click);
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBrowse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(117)))), ((int)(((byte)(219)))));
            this.buttonBrowse.BorderColor = System.Drawing.Color.Empty;
            this.buttonBrowse.BorderRadius = 10;
            this.buttonBrowse.BorderSize = 0;
            this.buttonBrowse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(0)))), ((int)(((byte)(137)))));
            this.buttonBrowse.FlatAppearance.BorderSize = 0;
            this.buttonBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonBrowse.ForeColor = System.Drawing.Color.White;
            this.buttonBrowse.Location = new System.Drawing.Point(12, 12);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(185, 42);
            this.buttonBrowse.TabIndex = 0;
            this.buttonBrowse.Text = "Baza egzaminów";
            this.buttonBrowse.TextColor = System.Drawing.Color.White;
            this.buttonBrowse.UseVisualStyleBackColor = false;
            this.buttonBrowse.Visible = false;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // ModuleDisplayPanel
            // 
            this.ModuleDisplayPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ModuleDisplayPanel.Location = new System.Drawing.Point(204, 0);
            this.ModuleDisplayPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ModuleDisplayPanel.Name = "ModuleDisplayPanel";
            this.ModuleDisplayPanel.Size = new System.Drawing.Size(729, 519);
            this.ModuleDisplayPanel.TabIndex = 2;
            // 
            // ExamModuleWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.ModuleDisplayPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ExamModuleWindowForm";
            this.Text = "ExamModuleWindow";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ModuleDisplayPanel;
        private ToolMenuButton buttonResults;
        private ToolMenuButton buttonManagement;
        private ToolMenuButton buttonBrowse;
        //private ToolMenuButton buttonBrowse;
        //private ToolMenuButton buttonManagement;
        //private ToolMenuButton buttonResults;
        //private ToolMenuButton buttonResults2;
        //private ToolMenuButton buttonManagement2;
        //private ToolMenuButton buttonBrowse2;
        //private ToolMenuButton buttonBrowse;
    }
}