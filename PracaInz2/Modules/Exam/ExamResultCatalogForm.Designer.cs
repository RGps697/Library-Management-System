namespace UserInterfaceLibrary
{
    partial class ExamResultCatalogForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.columnSearch = new System.Windows.Forms.ComboBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.searchField = new System.Windows.Forms.TextBox();
            this.examResultPanel = new UserInterfaceLibrary.SelectableItemPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSortBy = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.columnSearch);
            this.panel3.Controls.Add(this.buttonSearch);
            this.panel3.Controls.Add(this.searchField);
            this.panel3.Location = new System.Drawing.Point(0, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(920, 62);
            this.panel3.TabIndex = 2;
            // 
            // columnSearch
            // 
            this.columnSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columnSearch.FormattingEnabled = true;
            this.columnSearch.Location = new System.Drawing.Point(4, 24);
            this.columnSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.columnSearch.Name = "columnSearch";
            this.columnSearch.Size = new System.Drawing.Size(182, 23);
            this.columnSearch.TabIndex = 6;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.Location = new System.Drawing.Point(805, 21);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(88, 27);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Szukaj";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // searchField
            // 
            this.searchField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchField.Location = new System.Drawing.Point(194, 24);
            this.searchField.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.searchField.MinimumSize = new System.Drawing.Size(4, 20);
            this.searchField.Name = "searchField";
            this.searchField.Size = new System.Drawing.Size(603, 23);
            this.searchField.TabIndex = 3;
            // 
            // examResultPanel
            // 
            this.examResultPanel.AutoScroll = true;
            this.examResultPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.examResultPanel.BackColor = System.Drawing.SystemColors.Control;
            this.examResultPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.examResultPanel.Location = new System.Drawing.Point(0, 38);
            this.examResultPanel.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.examResultPanel.Name = "examResultPanel";
            this.examResultPanel.SelectedItem = null;
            this.examResultPanel.Size = new System.Drawing.Size(921, 389);
            this.examResultPanel.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxSortBy);
            this.panel1.Controls.Add(this.examResultPanel);
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 427);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(640, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sortowanie:";
            // 
            // comboBoxSortBy
            // 
            this.comboBoxSortBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxSortBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSortBy.Location = new System.Drawing.Point(716, 3);
            this.comboBoxSortBy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxSortBy.Name = "comboBoxSortBy";
            this.comboBoxSortBy.Size = new System.Drawing.Size(201, 23);
            this.comboBoxSortBy.TabIndex = 4;
            this.comboBoxSortBy.SelectedIndexChanged += new System.EventHandler(this.comboBoxSortBy_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Wyszukaj po:";
            // 
            // ExamResultCatalogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 519);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ExamResultCatalogForm";
            this.Text = "ExamResultCatalogForm";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox columnSearch;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox searchField;
        private SelectableItemPanel examResultPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSortBy;
        private System.Windows.Forms.Label label2;
    }
}