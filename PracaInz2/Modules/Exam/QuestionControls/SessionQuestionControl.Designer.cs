namespace UserInterfaceLibrary
{
    partial class SessionQuestionControl
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
            this.outputDescription = new System.Windows.Forms.Label();
            this.outputQuestionNumber = new System.Windows.Forms.Label();
            this.answersPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // outputDescription
            // 
            this.outputDescription.AutoEllipsis = true;
            this.outputDescription.AutoSize = true;
            this.outputDescription.Location = new System.Drawing.Point(4, 38);
            this.outputDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputDescription.MaximumSize = new System.Drawing.Size(600, 30);
            this.outputDescription.MinimumSize = new System.Drawing.Size(117, 0);
            this.outputDescription.Name = "outputDescription";
            this.outputDescription.Size = new System.Drawing.Size(117, 15);
            this.outputDescription.TabIndex = 0;
            // 
            // outputQuestionNumber
            // 
            this.outputQuestionNumber.AutoEllipsis = true;
            this.outputQuestionNumber.AutoSize = true;
            this.outputQuestionNumber.Location = new System.Drawing.Point(4, 0);
            this.outputQuestionNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.outputQuestionNumber.MaximumSize = new System.Drawing.Size(600, 25);
            this.outputQuestionNumber.MinimumSize = new System.Drawing.Size(117, 0);
            this.outputQuestionNumber.Name = "outputQuestionNumber";
            this.outputQuestionNumber.Size = new System.Drawing.Size(117, 15);
            this.outputQuestionNumber.TabIndex = 1;
            // 
            // answersPanel
            // 
            this.answersPanel.AutoScroll = true;
            this.answersPanel.BackColor = System.Drawing.SystemColors.Control;
            this.answersPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.answersPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.answersPanel.Location = new System.Drawing.Point(0, 82);
            this.answersPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.answersPanel.Name = "answersPanel";
            this.answersPanel.Size = new System.Drawing.Size(640, 418);
            this.answersPanel.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.outputQuestionNumber, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.outputDescription, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(640, 76);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // SessionQuestionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.answersPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "SessionQuestionControl";
            this.Size = new System.Drawing.Size(640, 500);
            this.Resize += new System.EventHandler(this.SessionQuestionControl_Resize);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label outputDescription;
        private System.Windows.Forms.Label outputQuestionNumber;
        private System.Windows.Forms.FlowLayoutPanel answersPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
