namespace UserInterfaceLibrary
{
    partial class ExamSessionForm
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
            this.questionsList = new System.Windows.Forms.ListBox();
            this.questionPanel = new System.Windows.Forms.Panel();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonFinish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // questionsList
            // 
            this.questionsList.FormattingEnabled = true;
            this.questionsList.ItemHeight = 15;
            this.questionsList.Location = new System.Drawing.Point(19, 12);
            this.questionsList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.questionsList.Name = "questionsList";
            this.questionsList.Size = new System.Drawing.Size(67, 529);
            this.questionsList.TabIndex = 0;
            this.questionsList.SelectedIndexChanged += new System.EventHandler(this.questionsList_SelectedIndexChanged);
            // 
            // questionPanel
            // 
            this.questionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questionPanel.Location = new System.Drawing.Point(94, 12);
            this.questionPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.questionPanel.Name = "questionPanel";
            this.questionPanel.Size = new System.Drawing.Size(669, 530);
            this.questionPanel.TabIndex = 1;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(94, 548);
            this.buttonPrevious.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(342, 72);
            this.buttonPrevious.TabIndex = 2;
            this.buttonPrevious.Text = "Poprzednie";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(444, 548);
            this.buttonNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(319, 72);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = "Następne";
            this.buttonNext.UseVisualStyleBackColor = true;
            // 
            // buttonFinish
            // 
            this.buttonFinish.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFinish.Location = new System.Drawing.Point(94, 642);
            this.buttonFinish.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonFinish.Name = "buttonFinish";
            this.buttonFinish.Size = new System.Drawing.Size(669, 39);
            this.buttonFinish.TabIndex = 4;
            this.buttonFinish.Text = "Zakończ podejście";
            this.buttonFinish.UseVisualStyleBackColor = true;
            this.buttonFinish.Click += new System.EventHandler(this.buttonFinish_Click);
            // 
            // ExamSessionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 693);
            this.Controls.Add(this.buttonFinish);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.questionPanel);
            this.Controls.Add(this.questionsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "ExamSessionForm";
            this.Text = "Rozwiązywanie egzaminu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExamSessionForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox questionsList;
        private System.Windows.Forms.Panel questionPanel;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonFinish;
    }
}