namespace UserInterfaceLibrary
{
    partial class AnswerCreatorControl
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
            this.statusIcon = new System.Windows.Forms.PictureBox();
            this.answerText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statusIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // statusIcon
            // 
            this.statusIcon.Location = new System.Drawing.Point(18, 9);
            this.statusIcon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.statusIcon.Name = "statusIcon";
            this.statusIcon.Size = new System.Drawing.Size(30, 25);
            this.statusIcon.TabIndex = 1;
            this.statusIcon.TabStop = false;
            // 
            // answerText
            // 
            this.answerText.AutoSize = true;
            this.answerText.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerText.Location = new System.Drawing.Point(56, 12);
            this.answerText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.answerText.MaximumSize = new System.Drawing.Size(320, 0);
            this.answerText.MinimumSize = new System.Drawing.Size(233, 0);
            this.answerText.Name = "answerText";
            this.answerText.Size = new System.Drawing.Size(233, 20);
            this.answerText.TabIndex = 2;
            // 
            // AnswerCreatorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.answerText);
            this.Controls.Add(this.statusIcon);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "AnswerCreatorControl";
            this.Size = new System.Drawing.Size(453, 44);
            ((System.ComponentModel.ISupportInitialize)(this.statusIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label answerText;
        internal System.Windows.Forms.PictureBox statusIcon;
    }
}
