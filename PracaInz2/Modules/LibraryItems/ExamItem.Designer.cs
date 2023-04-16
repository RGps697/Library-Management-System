namespace UserInterfaceLibrary
{
    partial class ExamItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.outputName = new System.Windows.Forms.Label();
            this.outputQuestionsToAnswer = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.outputAuthor = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputName
            // 
            this.outputName.AutoSize = true;
            this.outputName.Location = new System.Drawing.Point(109, 0);
            this.outputName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputName.MinimumSize = new System.Drawing.Size(117, 0);
            this.outputName.Name = "outputName";
            this.outputName.Size = new System.Drawing.Size(117, 15);
            this.outputName.TabIndex = 0;
            // 
            // outputQuestionsToAnswer
            // 
            this.outputQuestionsToAnswer.AutoSize = true;
            this.outputQuestionsToAnswer.Location = new System.Drawing.Point(109, 70);
            this.outputQuestionsToAnswer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputQuestionsToAnswer.MinimumSize = new System.Drawing.Size(117, 0);
            this.outputQuestionsToAnswer.Name = "outputQuestionsToAnswer";
            this.outputQuestionsToAnswer.Size = new System.Drawing.Size(117, 15);
            this.outputQuestionsToAnswer.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.70862F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.29137F));
            this.tableLayoutPanel1.Controls.Add(this.outputName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.outputQuestionsToAnswer, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.outputAuthor, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(427, 121);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nazwa egzaminu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ilość pytań:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Autor:";
            // 
            // outputAuthor
            // 
            this.outputAuthor.AutoSize = true;
            this.outputAuthor.Location = new System.Drawing.Point(108, 50);
            this.outputAuthor.MinimumSize = new System.Drawing.Size(50, 0);
            this.outputAuthor.Name = "outputAuthor";
            this.outputAuthor.Size = new System.Drawing.Size(50, 15);
            this.outputAuthor.TabIndex = 5;
            // 
            // ExamItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "ExamItem";
            this.Size = new System.Drawing.Size(433, 125);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputName;
        private System.Windows.Forms.Label outputQuestionsToAnswer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label outputAuthor;
    }
}
