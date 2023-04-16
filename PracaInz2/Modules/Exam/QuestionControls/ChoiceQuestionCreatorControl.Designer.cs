namespace UserInterfaceLibrary
{
    partial class ChoiceQuestionCreatorControl
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
            this.buttonAddAnswer = new System.Windows.Forms.Button();
            this.questionDescription = new System.Windows.Forms.TextBox();
            this.answerInput = new System.Windows.Forms.TextBox();
            this.buttonChangeCorrectness = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.inputPoints = new System.Windows.Forms.NumericUpDown();
            this.labelPoints = new System.Windows.Forms.Label();
            this.answersList = new UserInterfaceLibrary.SelectableItemPanel();
            ((System.ComponentModel.ISupportInitialize)(this.inputPoints)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddAnswer
            // 
            this.buttonAddAnswer.Location = new System.Drawing.Point(373, 148);
            this.buttonAddAnswer.MinimumSize = new System.Drawing.Size(60, 0);
            this.buttonAddAnswer.Name = "buttonAddAnswer";
            this.buttonAddAnswer.Size = new System.Drawing.Size(60, 21);
            this.buttonAddAnswer.TabIndex = 2;
            this.buttonAddAnswer.Text = "Dodaj";
            this.buttonAddAnswer.UseVisualStyleBackColor = true;
            this.buttonAddAnswer.Click += new System.EventHandler(this.buttonAddAnswer_Click);
            // 
            // questionDescription
            // 
            this.questionDescription.Location = new System.Drawing.Point(14, 40);
            this.questionDescription.Multiline = true;
            this.questionDescription.Name = "questionDescription";
            this.questionDescription.Size = new System.Drawing.Size(419, 102);
            this.questionDescription.TabIndex = 3;
            this.questionDescription.TextChanged += new System.EventHandler(this.questionDescription_TextChanged);
            // 
            // answerInput
            // 
            this.answerInput.Location = new System.Drawing.Point(14, 149);
            this.answerInput.Name = "answerInput";
            this.answerInput.Size = new System.Drawing.Size(353, 23);
            this.answerInput.TabIndex = 6;
            // 
            // buttonChangeCorrectness
            // 
            this.buttonChangeCorrectness.Location = new System.Drawing.Point(14, 172);
            this.buttonChangeCorrectness.Name = "buttonChangeCorrectness";
            this.buttonChangeCorrectness.Size = new System.Drawing.Size(157, 44);
            this.buttonChangeCorrectness.TabIndex = 10;
            this.buttonChangeCorrectness.Text = "Zmień prawidłową odpowiedź";
            this.buttonChangeCorrectness.UseVisualStyleBackColor = true;
            this.buttonChangeCorrectness.Click += new System.EventHandler(this.buttonMarkCorrect_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(292, 172);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 44);
            this.buttonDelete.TabIndex = 11;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // inputPoints
            // 
            this.inputPoints.Location = new System.Drawing.Point(117, 14);
            this.inputPoints.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.inputPoints.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputPoints.Name = "inputPoints";
            this.inputPoints.Size = new System.Drawing.Size(40, 23);
            this.inputPoints.TabIndex = 15;
            this.inputPoints.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputPoints.ValueChanged += new System.EventHandler(this.inputPoints_ValueChanged);
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Location = new System.Drawing.Point(11, 16);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(109, 15);
            this.labelPoints.TabIndex = 14;
            this.labelPoints.Text = "Wartość punktowa:";
            // 
            // answersList
            // 
            this.answersList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.answersList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.answersList.Location = new System.Drawing.Point(11, 222);
            this.answersList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.answersList.Name = "answersList";
            this.answersList.SelectedItem = null;
            this.answersList.Size = new System.Drawing.Size(422, 139);
            this.answersList.TabIndex = 16;
            // 
            // ChoiceQuestionCreatorControl
            // 
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.answersList);
            this.Controls.Add(this.inputPoints);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonChangeCorrectness);
            this.Controls.Add(this.answerInput);
            this.Controls.Add(this.buttonAddAnswer);
            this.Controls.Add(this.questionDescription);
            this.Name = "ChoiceQuestionCreatorControl";
            this.Size = new System.Drawing.Size(450, 372);
            ((System.ComponentModel.ISupportInitialize)(this.inputPoints)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAddAnswer;
        private System.Windows.Forms.TextBox questionDescription;
        private System.Windows.Forms.TextBox answerInput;
        private System.Windows.Forms.Button buttonChangeCorrectness;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.NumericUpDown inputPoints;
        private System.Windows.Forms.Label labelPoints;
        private SelectableItemPanel answersList;
    }
}
