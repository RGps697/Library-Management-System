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
    public partial class ExamCreatorForm : Form
    {
        ExamProcessor ExamProcessor { get; set; }
        public Exam Exam 
        { 
            get
            {
                return ExamProcessor.Exam;
            } 
        }
        public ExamCreatorForm()
        {
            InitializeComponent();
            ExamProcessor = new ExamProcessor();
            AddNewQuestion(new SingleChoiceQuestion());
            ViewQuestion(0);
        }

        public ExamCreatorForm(Exam exam)
        {
            InitializeComponent();
            ExamProcessor = new ExamProcessor(exam);
            inputName.Text = exam.Name;
            inputDescription.Text = exam.Description;
            inputQuestionsPerSession.Value = exam.QuestionAmountPerSession;
            if (exam.Questions.Count > 0)
            {
                listBoxQuestions.Items.AddRange(ExamProcessor.GetAllQuestionNames());
            }
            else
            {
                AddNewQuestion(new SingleChoiceQuestion());
            }

            if (ExamProcessor.Exam.LinkedBooks != null)
            {
                BookCatalog catalog = new BookCatalog();
                catalog.FindItemsByIds("_id", ExamProcessor.Exam.LinkedBooks);
                linkedBooksList.AddItems(catalog.ItemControls);
            }

            ViewQuestion(0);
        }

        private void AddNewQuestion(IQuestion question)
        {
            if (ExamProcessor.AddQuestion(question))
            {
                string text = ExamProcessor.GetQuestionName(question);
                AddQuestionMenuItem(text);
            }
            else
            {
                MessageBox.Show("Osiągnięto limit pytań");
            }
        }

        private void AddQuestionMenuItem(string text)
        {
            listBoxQuestions.Items.Add($"{text}");
        }

        private void ViewQuestion(int index)
        {
            questionCreatorPanel.Controls.Clear();
            if (index >= 0)
            {
                IQuestion question = ExamProcessor.GetQuestion(index);
                IQuestionCreatorControl questionControl;
                if (question is SingleChoiceQuestion)
                {
                    SingleChoiceQuestion singleChoiceQuestion = (SingleChoiceQuestion)question;
                    questionControl = new SingleChoiceQuestionCreatorControl(ExamProcessor.questionProcessor, singleChoiceQuestion); //ref
                }
                else if (question is MultiChoiceQuestion)
                {
                    MultiChoiceQuestion multiChoiceQuestion = (MultiChoiceQuestion)question;
                    questionControl = new MultiChoiceQuestionCreatorControl(ExamProcessor.questionProcessor, multiChoiceQuestion);
                }
                else
                {
                    throw new MissingMemberException();
                }
                Console.WriteLine($"adding {questionControl.Question.Id}");
                questionCreatorPanel.Controls.Add((Control)questionControl);

                int i = questionCreatorPanel.Controls.GetChildIndex((Control)questionControl);
                ((Control)questionControl).Left = (questionCreatorPanel.Width - ((Control)questionControl).Width) / 2;
                ((Control)questionControl).Top = (questionCreatorPanel.Height - ((Control)questionControl).Height) / 2;
                questionCreatorPanel.Controls[i].Anchor = (AnchorStyles.Bottom | AnchorStyles.Top);
            }
        }

        private void inputExamName_TextChanged(object sender, EventArgs e)
        {
            ExamProcessor.SetName = inputName.Text;
        }

        private void inputDescription_TextChanged(object sender, EventArgs e)
        {
            ExamProcessor.SetDescription = inputDescription.Text;
        }

        private void buttonAddQuestion_Click(object sender, EventArgs e)
        {
            addQuestionDDMenu.Show(buttonAddQuestion, new Point(0, buttonAddQuestion.Height));
        }

        private void singleChoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewQuestion(new SingleChoiceQuestion());
        }

        private void multipleChoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewQuestion(new MultiChoiceQuestion());
        }

        private void listBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewQuestion(listBoxQuestions.SelectedIndex);
        }

        private void buttonRemoveQuestion_Click(object sender, EventArgs e)
        {
            ExamProcessor.DeleteQuestion(listBoxQuestions.SelectedIndex);
            listBoxQuestions.Items.RemoveAt(listBoxQuestions.SelectedIndex);
        }

        private void buttonSaveExam_Click(object sender, EventArgs e)
        {
            string result = ExamProcessor.ValidateExam();
            if (result == null)
            {
                string saveResult = ExamProcessor.SaveExam();
                if (saveResult == null)
                {
                    MessageBox.Show("Egzamin został zapisany");
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(saveResult);
                }
                Close();
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void inputQuestionsPerSession_ValueChanged(object sender, EventArgs e)
        {
            decimal amount = inputQuestionsPerSession.Value;
            int result = ExamProcessor.SetQuestionAmountPerSession(amount);
            if (result > 0)
            {
                inputQuestionsPerSession.Value = result;
            }


        }

        private void buttonAddLink_Click(object sender, EventArgs e)
        {
            ItemSelectionForm itemSelectionForm = new ItemSelectionForm(new BookCatalog());
            itemSelectionForm.ShowDialog();
            if (itemSelectionForm.SelectedItem != null)
            {
                if (ExamProcessor.Exam.LinkedBooks.Count < 10)
                {
                    bool addResult = ExamProcessor.AddBookLink(((BookItem)(ICatalogItem)itemSelectionForm.SelectedItem).ContainedItem.Id);
                    if (addResult)
                    {
                        linkedBooksList.AddItem(itemSelectionForm.SelectedItem);
                    }
                    else
                    {
                        MessageBox.Show("Książka jest już dodana");
                    }
                }
                else
                {
                    MessageBox.Show("Osiągnięto limit książek");
                }
            }
        }

        private void buttonRemoveLink_Click(object sender, EventArgs e)
        {
            if (linkedBooksList.SelectedItem != null)
            {
                linkedBooksList.DeleteSelectedItem();
                ExamProcessor.DeleteBookLink(((BookItem)(ICatalogItem)linkedBooksList.SelectedItem).ContainedItem.Id);
            }
        }
    }
}
