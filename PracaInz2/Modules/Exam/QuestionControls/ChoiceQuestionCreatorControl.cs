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
    public partial class ChoiceQuestionCreatorControl : UserControl, IQuestionCreatorControl
    {
        public IQuestion Question { get; set; }
        private ExamProcessor.QuestionProcessor QuestionProcessor { get; set; }

        private ChoiceQuestionCreatorControl()
        {
            InitializeComponent();
        }

        public ChoiceQuestionCreatorControl(ExamProcessor.QuestionProcessor processor, IQuestion question) : this()
        {
            QuestionProcessor = processor;
            this.Question = question;
            questionDescription.Text = question.Description;
            inputPoints.Value = question.Points;
            for (int i = 0; i < question.Answers.Count; i++)
            {
                answersList.AddItem(new AnswerCreatorControl(question.Answers[i]));
                Console.WriteLine($"punkty pytania: {question.Points}, input: {(byte)inputPoints.Value}");
            }
        }

        private void inputPoints_ValueChanged(object sender, EventArgs e)
        {
            QuestionProcessor.SetPoints(Question, (byte)inputPoints.Value);
            Console.WriteLine($"punkty pytania: {Question.Points}, input: {(byte)inputPoints.Value}");
        }

        private void questionDescription_TextChanged(object sender, EventArgs e)
        {
            QuestionProcessor.SetDescription(Question, questionDescription.Text);
        }

        private void buttonAddAnswer_Click(object sender, EventArgs e)
        {
            QuestionAnswer newAnswer = QuestionProcessor.AddAnswer(Question, answerInput.Text);
            if (newAnswer != null)
            {
                answersList.AddItem(new AnswerCreatorControl(Question.Answers.Last()));
                answerInput.Text = "";
            }
            else
            {
                MessageBox.Show("Istnieje już taka odpowiedź lub osiągnięto maksymalną ilość odpowiedzi");
            }
        }

        protected void buttonMarkCorrect_Click(object sender, EventArgs e)
        {
            AnswerCreatorControl ctrl = answersList.GetSelectedItem<AnswerCreatorControl>();
            if (ctrl != null)
            {
                QuestionAnswer answer = ctrl.Answer;
                Console.WriteLine($"zmiana: {answer.AnswerText}");
                if(QuestionProcessor.MarkCorrectAnswer(Question, answer))
                {
                    if (answer.IsCorrectAnswer)
                    {
                        ctrl.statusIcon.Image = Icons.correct;
                    }
                    else
                    {
                        ctrl.statusIcon.Image = null;
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            QuestionAnswer answer = ((AnswerCreatorControl)answersList.SelectedItem).Answer;
            QuestionProcessor.DeleteAnswer(Question, answer);
            answersList.DeleteSelectedItem();
        }

    }
}
