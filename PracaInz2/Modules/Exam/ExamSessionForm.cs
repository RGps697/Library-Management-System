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
    public partial class ExamSessionForm : Form
    {
        private List<SessionQuestionControl> QuestionControls { get; set; }
        internal List<IQuestion> Questions { get; set; } = new List<IQuestion>();
        ExamSession ExamSession { get; set; }

        private ExamSessionForm()
        {
            InitializeComponent();
            QuestionControls = new List<SessionQuestionControl>();
        }

        public ExamSessionForm(Exam exam) : this()
        {
            ExamSession = new ExamSession(exam);
            List<IQuestion> questions = ExamSession.SelectRandomQuestions();

            for (int i = 0; i < questions.Count; i++)
            {
                questionsList.Items.Add(i + 1);
                QuestionControls.Add(new SessionQuestionControl(questions[i], i + 1)
                {
                    Width = questionPanel.Width,
                    Height = questionPanel.Height
                });
            }
        }

        private void questionsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            questionPanel.Controls.Clear();
            int index = questionsList.SelectedIndex;
            if (index >= 0)
            {
                questionPanel.Controls.Add(QuestionControls[index]);
            }
        }

        private bool FinishExam()
        {
            DialogResult dialogResult = MessageBox.Show("Czy chcesz zakończyć podejście?", "", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int count = QuestionControls.Count;
                List<AnsweredChoiceQuestion> questionsToEvaluate = new List<AnsweredChoiceQuestion>();
                for (int i = 0; i < count; i++)
                {
                    questionsToEvaluate.Add(QuestionControls[i].GetQuestionAnswersChoice());
                }
                decimal score = ExamSession.EvaluateExam(questionsToEvaluate);
                MessageBox.Show($"Osiągnięty wynik:\n{score}%");
                return true;
            }
            return false;
        }

        private void buttonFinish_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ExamSessionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!FinishExam())
            {
                e.Cancel = true;
            }
        }
    }
}
