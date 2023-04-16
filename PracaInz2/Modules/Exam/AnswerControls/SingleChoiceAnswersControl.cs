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
    public partial class SingleChoiceAnswersControl : UserControl, IAnswersControl
    {
        List<QuestionAnswer> Answers { get; set; }
        private SingleChoiceAnswersControl()
        {
            InitializeComponent();
        }

        internal SingleChoiceAnswersControl(List<QuestionAnswer> answers) : this()
        {
            Answers = answers;
            int answersCount = answers.Count;
            RadioButton radioButtonToAdd;
            for (int i = 0; i < answersCount; i++)
            {
                radioButtonToAdd = new RadioButton() { Text = answers[i].AnswerText, AutoSize = false, Width = 550, Height = 50, AutoEllipsis = true };
                answersPanel.Controls.Add(radioButtonToAdd);
                answersPanel.SetFlowBreak(radioButtonToAdd, true);
            }
        }

        public List<AnsweredQuestionAnswer> GetAnswersChoice()
        {
            List<AnsweredQuestionAnswer> answersToEvaluate = new List<AnsweredQuestionAnswer>();
            int answersCount = answersPanel.Controls.Count;
            for (byte i = 0; i < answersCount; i++)
            {
                answersToEvaluate.Add(new AnsweredQuestionAnswer(Answers[i]));
                if (((RadioButton)answersPanel.Controls[i]).Checked)
                {
                    answersToEvaluate[i].IsSelected = true;
                    break;
                }

            }

            return answersToEvaluate;
        }
    }
}
