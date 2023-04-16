namespace UserInterfaceLibrary
{
    partial class ExamBrowserForm
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
            this.columnSearch = new System.Windows.Forms.ComboBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.searchField = new System.Windows.Forms.TextBox();
            this.examListPanel = new UserInterfaceLibrary.SelectableItemPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.columnSearch);
            this.panel1.Controls.Add(this.buttonFind);
            this.panel1.Controls.Add(this.searchField);
            this.panel1.Location = new System.Drawing.Point(0, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 57);
            this.panel1.TabIndex = 0;
            // 
            // columnSearch
            // 
            this.columnSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columnSearch.FormattingEnabled = true;
            this.columnSearch.Location = new System.Drawing.Point(6, 20);
            this.columnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.columnSearch.Name = "columnSearch";
            this.columnSearch.Size = new System.Drawing.Size(182, 23);
            this.columnSearch.TabIndex = 4;
            // 
            // buttonFind
            // 
            this.buttonFind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFind.Location = new System.Drawing.Point(831, 17);
            this.buttonFind.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(88, 27);
            this.buttonFind.TabIndex = 3;
            this.buttonFind.Text = "Szukaj";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // searchField
            // 
            this.searchField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchField.Location = new System.Drawing.Point(196, 20);
            this.searchField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(616, 23);
            this.searchField.TabIndex = 2;
            // 
            // examListPanel
            // 
            this.examListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.examListPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.examListPanel.BackColor = System.Drawing.SystemColors.Control;
            this.examListPanel.Location = new System.Drawing.Point(0, 75);
            this.examListPanel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.examListPanel.Name = "examListPanel";
            this.examListPanel.SelectedItem = null;
            this.examListPanel.Size = new System.Drawing.Size(933, 444);
            this.examListPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Wyszukaj po:";
            // 
            // ExamBrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.examListPanel);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ExamBrowserForm";
            this.Text = "ExamBrowserForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private SelectableItemPanel examListPanel;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox searchField;
        private System.Windows.Forms.ComboBox columnSearch;
        private System.Windows.Forms.Label label1;
    }
}