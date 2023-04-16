using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceLibrary
{
    [System.ComponentModel.ToolboxItem(false)]
    public partial class SessionQuestionControl : UserControl
    {
        IQuestion Question { get; set; }
        private SessionQuestionControl()
        {
            InitializeComponent();
        }

        public SessionQuestionControl(IQuestion question, int questionNumber) : this()
        {
            Question = question;
            outputQuestionNumber.Text = $"Pytanie numer: {questionNumber}";
            outputDescription.Text = question.Description;
            if (question is SingleChoiceQuestion)
            {
                answersPanel.Controls.Add(new SingleChoiceAnswersControl(question.Answers)
                {
                    Width = answersPanel.Width - 5,
                    Height = answersPanel.Height
                });
            }
            else if(question is MultiChoiceQuestion)
            {
                answersPanel.Controls.Add(new MultiChoiceAnswersControl(question.Answers)
                {
                    Width = answersPanel.Width - 5,
                    Height = answersPanel.Height
                });
            }
        }

        internal AnsweredChoiceQuestion GetQuestionAnswersChoice()
        {
            List<AnsweredQuestionAnswer> answersToEvaluate = ((IAnswersControl)answersPanel.Controls[0]).GetAnswersChoice();
            AnsweredChoiceQuestion questionToEvaluate = new AnsweredChoiceQuestion(Question, answersToEvaluate);
            return questionToEvaluate;
        }

        private void SessionQuestionControl_Resize(object sender, EventArgs e)
        {
            answersPanel.Width = Width;
            answersPanel.Height = Height - 80;
        }
    }
}