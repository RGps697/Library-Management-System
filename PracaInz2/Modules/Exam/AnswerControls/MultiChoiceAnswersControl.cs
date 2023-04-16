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
    [ToolboxItem(false)]
    public partial class MultiChoiceAnswersControl : UserControl, IAnswersControl
    {
        List<QuestionAnswer> Answers { get; set; }
        private MultiChoiceAnswersControl()
        {
            InitializeComponent();
        }

        public MultiChoiceAnswersControl(List<QuestionAnswer> answers) : this()
        {
            Answers = answers;
            int answersCount = answers.Count;
            CheckBox checkBoxToAdd;
            for (int i = 0; i < answersCount; i++)
            {
                checkBoxToAdd = new CheckBox() { Text = answers[i].AnswerText, AutoSize = false, Width = 500, Height = 50 };
                answersPanel.Controls.Add(checkBoxToAdd);
                answersPanel.SetFlowBreak(checkBoxToAdd, true);
            }
        }

        public List<AnsweredQuestionAnswer> GetAnswersChoice()
        {
            List<AnsweredQuestionAnswer> answersToEvaluate = new List<AnsweredQuestionAnswer>();
            int answersCount = answersPanel.Controls.Count;
            for (byte i = 0; i < answersCount; i++)
            {
                answersToEvaluate.Add(new AnsweredQuestionAnswer(Answers[i]));
                if (((CheckBox)answersPanel.Controls[i]).Checked)
                {
                    answersToEvaluate[i].IsSelected = true;
                }

            }

            return answersToEvaluate;
        }
    }
}
