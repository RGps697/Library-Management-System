namespace UserInterfaceLibrary
{
    partial class ExamViewerForm
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
            this.outputName = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.outputDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkedBooksList = new UserInterfaceLibrary.SelectableItemPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.outputAuthor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputName
            // 
            this.outputName.AutoSize = true;
            this.outputName.Location = new System.Drawing.Point(4, 15);
            this.outputName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputName.MinimumSize = new System.Drawing.Size(50, 0);
            this.outputName.Name = "outputName";
            this.outputName.Size = new System.Drawing.Size(50, 15);
            this.outputName.TabIndex = 0;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(4, 180);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(34, 15);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Opis:";
            // 
            // buttonSolve
            // 
            this.buttonSolve.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSolve.Location = new System.Drawing.Point(18, 521);
            this.buttonSolve.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(88, 27);
            this.buttonSolve.TabIndex = 3;
            this.buttonSolve.Text = "Rozwiąż";
            this.buttonSolve.UseVisualStyleBackColor = true;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // outputDescription
            // 
            this.outputDescription.AutoSize = true;
            this.outputDescription.Location = new System.Drawing.Point(4, 195);
            this.outputDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputDescription.MaximumSize = new System.Drawing.Size(400, 0);
            this.outputDescription.MinimumSize = new System.Drawing.Size(58, 0);
            this.outputDescription.Name = "outputDescription";
            this.outputDescription.Size = new System.Drawing.Size(58, 15);
            this.outputDescription.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nazwa:";
            // 
            // linkedBooksList
            // 
            this.linkedBooksList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkedBooksList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.linkedBooksList.BackColor = System.Drawing.SystemColors.Control;
            this.linkedBooksList.Location = new System.Drawing.Point(12, 305);
            this.linkedBooksList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.linkedBooksList.Name = "linkedBooksList";
            this.linkedBooksList.SelectedItem = null;
            this.linkedBooksList.Size = new System.Drawing.Size(636, 210);
            this.linkedBooksList.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.outputName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelDescription, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.outputDescription, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.outputAuthor, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(636, 272);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Autor:";
            // 
            // outputAuthor
            // 
            this.outputAuthor.AutoSize = true;
            this.outputAuthor.Location = new System.Drawing.Point(3, 105);
            this.outputAuthor.MinimumSize = new System.Drawing.Size(50, 0);
            this.outputAuthor.Name = "outputAuthor";
            this.outputAuthor.Size = new System.Drawing.Size(50, 15);
            this.outputAuthor.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Powiązane książki:";
            // 
            // ExamViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkedBooksList);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 800);
            this.MinimumSize = new System.Drawing.Size(660, 600);
            this.Name = "ExamViewerForm";
            this.Text = "Szczegóły egzaminu";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label outputName;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Label outputDescription;
        private System.Windows.Forms.Label label1;
        private SelectableItemPanel linkedBooksList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label outputAuthor;
        private System.Windows.Forms.Label label3;
    }
}