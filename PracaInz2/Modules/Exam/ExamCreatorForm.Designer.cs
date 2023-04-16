namespace UserInterfaceLibrary
{
    partial class ExamCreatorForm
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
            this.components = new System.ComponentModel.Container();
            this.questionCreatorPanel = new System.Windows.Forms.Panel();
            this.buttonSaveExam = new System.Windows.Forms.Button();
            this.buttonAddQuestion = new System.Windows.Forms.Button();
            this.buttonRemoveQuestion = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBoxQuestions = new System.Windows.Forms.ListBox();
            this.addQuestionDDMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.singleChoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multipleChoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.inputQuestionsPerSession = new System.Windows.Forms.NumericUpDown();
            this.labelQuestionAmount = new System.Windows.Forms.Label();
            this.inputDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.labelExamName = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonRemoveLink = new System.Windows.Forms.Button();
            this.buttonAddLink = new System.Windows.Forms.Button();
            this.linkedBooksList = new UserInterfaceLibrary.SelectableItemPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.addQuestionDDMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputQuestionsPerSession)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionCreatorPanel
            // 
            this.questionCreatorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.questionCreatorPanel.AutoScroll = true;
            this.questionCreatorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questionCreatorPanel.Location = new System.Drawing.Point(187, 204);
            this.questionCreatorPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.questionCreatorPanel.Name = "questionCreatorPanel";
            this.questionCreatorPanel.Size = new System.Drawing.Size(466, 372);
            this.questionCreatorPanel.TabIndex = 0;
            // 
            // buttonSaveExam
            // 
            this.buttonSaveExam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSaveExam.Location = new System.Drawing.Point(13, 582);
            this.buttonSaveExam.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSaveExam.Name = "buttonSaveExam";
            this.buttonSaveExam.Size = new System.Drawing.Size(166, 27);
            this.buttonSaveExam.TabIndex = 4;
            this.buttonSaveExam.Text = "Zapisz egzamin";
            this.buttonSaveExam.UseVisualStyleBackColor = true;
            this.buttonSaveExam.Click += new System.EventHandler(this.buttonSaveExam_Click);
            // 
            // buttonAddQuestion
            // 
            this.buttonAddQuestion.Location = new System.Drawing.Point(0, 15);
            this.buttonAddQuestion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonAddQuestion.Name = "buttonAddQuestion";
            this.buttonAddQuestion.Size = new System.Drawing.Size(164, 27);
            this.buttonAddQuestion.TabIndex = 8;
            this.buttonAddQuestion.Text = "Dodaj";
            this.buttonAddQuestion.UseVisualStyleBackColor = true;
            this.buttonAddQuestion.Click += new System.EventHandler(this.buttonAddQuestion_Click);
            // 
            // buttonRemoveQuestion
            // 
            this.buttonRemoveQuestion.Location = new System.Drawing.Point(560, 156);
            this.buttonRemoveQuestion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonRemoveQuestion.Name = "buttonRemoveQuestion";
            this.buttonRemoveQuestion.Size = new System.Drawing.Size(88, 42);
            this.buttonRemoveQuestion.TabIndex = 9;
            this.buttonRemoveQuestion.Text = "Usuń pytanie";
            this.buttonRemoveQuestion.UseVisualStyleBackColor = true;
            this.buttonRemoveQuestion.Click += new System.EventHandler(this.buttonRemoveQuestion_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.listBoxQuestions);
            this.panel1.Controls.Add(this.buttonAddQuestion);
            this.panel1.Location = new System.Drawing.Point(15, 155);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 421);
            this.panel1.TabIndex = 10;
            // 
            // listBoxQuestions
            // 
            this.listBoxQuestions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxQuestions.FormattingEnabled = true;
            this.listBoxQuestions.ItemHeight = 15;
            this.listBoxQuestions.Location = new System.Drawing.Point(0, 63);
            this.listBoxQuestions.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxQuestions.Name = "listBoxQuestions";
            this.listBoxQuestions.Size = new System.Drawing.Size(164, 349);
            this.listBoxQuestions.TabIndex = 9;
            this.listBoxQuestions.SelectedIndexChanged += new System.EventHandler(this.listBoxQuestions_SelectedIndexChanged);
            // 
            // addQuestionDDMenu
            // 
            this.addQuestionDDMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleChoiceToolStripMenuItem,
            this.multipleChoiceToolStripMenuItem});
            this.addQuestionDDMenu.Name = "contextMenuStrip1";
            this.addQuestionDDMenu.Size = new System.Drawing.Size(176, 48);
            // 
            // singleChoiceToolStripMenuItem
            // 
            this.singleChoiceToolStripMenuItem.Name = "singleChoiceToolStripMenuItem";
            this.singleChoiceToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.singleChoiceToolStripMenuItem.Text = "Jednokrotny wybór";
            this.singleChoiceToolStripMenuItem.Click += new System.EventHandler(this.singleChoiceToolStripMenuItem_Click);
            // 
            // multipleChoiceToolStripMenuItem
            // 
            this.multipleChoiceToolStripMenuItem.Name = "multipleChoiceToolStripMenuItem";
            this.multipleChoiceToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.multipleChoiceToolStripMenuItem.Text = "Wielokrotny wybór";
            this.multipleChoiceToolStripMenuItem.Click += new System.EventHandler(this.multipleChoiceToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.inputQuestionsPerSession);
            this.panel2.Controls.Add(this.labelQuestionAmount);
            this.panel2.Controls.Add(this.inputDescription);
            this.panel2.Controls.Add(this.labelDescription);
            this.panel2.Controls.Add(this.labelExamName);
            this.panel2.Controls.Add(this.inputName);
            this.panel2.Location = new System.Drawing.Point(15, 15);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 134);
            this.panel2.TabIndex = 11;
            // 
            // inputQuestionsPerSession
            // 
            this.inputQuestionsPerSession.Location = new System.Drawing.Point(134, 103);
            this.inputQuestionsPerSession.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputQuestionsPerSession.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.inputQuestionsPerSession.Name = "inputQuestionsPerSession";
            this.inputQuestionsPerSession.Size = new System.Drawing.Size(54, 23);
            this.inputQuestionsPerSession.TabIndex = 2;
            this.inputQuestionsPerSession.ValueChanged += new System.EventHandler(this.inputQuestionsPerSession_ValueChanged);
            // 
            // labelQuestionAmount
            // 
            this.labelQuestionAmount.AutoSize = true;
            this.labelQuestionAmount.Location = new System.Drawing.Point(4, 103);
            this.labelQuestionAmount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuestionAmount.Name = "labelQuestionAmount";
            this.labelQuestionAmount.Size = new System.Drawing.Size(126, 15);
            this.labelQuestionAmount.TabIndex = 4;
            this.labelQuestionAmount.Text = "Liczba pytań na próbe:";
            // 
            // inputDescription
            // 
            this.inputDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputDescription.Location = new System.Drawing.Point(134, 44);
            this.inputDescription.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputDescription.Multiline = true;
            this.inputDescription.Name = "inputDescription";
            this.inputDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputDescription.Size = new System.Drawing.Size(498, 51);
            this.inputDescription.TabIndex = 1;
            this.inputDescription.TextChanged += new System.EventHandler(this.inputDescription_TextChanged);
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(91, 44);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(34, 15);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Opis:";
            // 
            // labelExamName
            // 
            this.labelExamName.AutoSize = true;
            this.labelExamName.Location = new System.Drawing.Point(77, 7);
            this.labelExamName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExamName.Name = "labelExamName";
            this.labelExamName.Size = new System.Drawing.Size(45, 15);
            this.labelExamName.TabIndex = 1;
            this.labelExamName.Text = "Nazwa:";
            // 
            // inputName
            // 
            this.inputName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputName.Location = new System.Drawing.Point(134, 3);
            this.inputName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(498, 23);
            this.inputName.TabIndex = 0;
            this.inputName.TextChanged += new System.EventHandler(this.inputExamName_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.buttonRemoveLink);
            this.panel3.Controls.Add(this.buttonAddLink);
            this.panel3.Controls.Add(this.linkedBooksList);
            this.panel3.Location = new System.Drawing.Point(660, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(517, 535);
            this.panel3.TabIndex = 12;
            // 
            // buttonRemoveLink
            // 
            this.buttonRemoveLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoveLink.Location = new System.Drawing.Point(257, 0);
            this.buttonRemoveLink.Name = "buttonRemoveLink";
            this.buttonRemoveLink.Size = new System.Drawing.Size(260, 40);
            this.buttonRemoveLink.TabIndex = 11;
            this.buttonRemoveLink.Text = "Usuń";
            this.buttonRemoveLink.UseVisualStyleBackColor = true;
            this.buttonRemoveLink.Click += new System.EventHandler(this.buttonRemoveLink_Click);
            // 
            // buttonAddLink
            // 
            this.buttonAddLink.Location = new System.Drawing.Point(0, 0);
            this.buttonAddLink.Name = "buttonAddLink";
            this.buttonAddLink.Size = new System.Drawing.Size(255, 40);
            this.buttonAddLink.TabIndex = 10;
            this.buttonAddLink.Text = "Dodaj";
            this.buttonAddLink.UseVisualStyleBackColor = true;
            this.buttonAddLink.Click += new System.EventHandler(this.buttonAddLink_Click);
            // 
            // linkedBooksList
            // 
            this.linkedBooksList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkedBooksList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.linkedBooksList.BackColor = System.Drawing.SystemColors.Control;
            this.linkedBooksList.Location = new System.Drawing.Point(4, 39);
            this.linkedBooksList.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.linkedBooksList.Name = "linkedBooksList";
            this.linkedBooksList.SelectedItem = null;
            this.linkedBooksList.Size = new System.Drawing.Size(512, 496);
            this.linkedBooksList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(660, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Książki powiązane z tematyką egzaminu:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(1082, 586);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(95, 23);
            this.buttonCancel.TabIndex = 14;
            this.buttonCancel.Text = "Anuluj";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // ExamCreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(1189, 621);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRemoveQuestion);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonSaveExam);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.questionCreatorPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximumSize = new System.Drawing.Size(1500, 1000);
            this.MinimumSize = new System.Drawing.Size(1205, 600);
            this.Name = "ExamCreatorForm";
            this.Text = "Nowy egzamin";
            this.panel1.ResumeLayout(false);
            this.addQuestionDDMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputQuestionsPerSession)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel questionCreatorPanel;
        private System.Windows.Forms.Button buttonSaveExam;
        private System.Windows.Forms.Button buttonAddQuestion;
        private System.Windows.Forms.Button buttonRemoveQuestion;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBoxQuestions;
        private System.Windows.Forms.ContextMenuStrip addQuestionDDMenu;
        private System.Windows.Forms.ToolStripMenuItem singleChoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multipleChoiceToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelExamName;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.TextBox inputDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.NumericUpDown inputQuestionsPerSession;
        private System.Windows.Forms.Label labelQuestionAmount;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonRemoveLink;
        private System.Windows.Forms.Button buttonAddLink;
        private SelectableItemPanel linkedBooksList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancel;
    }
}