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
    public partial class ExamViewerForm : Form
    {
        Exam Exam { get; set; }

        private ExamViewerForm()
        {
            InitializeComponent();
        }

        public ExamViewerForm(Exam exam) : this()
        {
            Exam = exam;
            outputName.Text = exam.Name;
            outputAuthor.Text = $"{exam.AuthorFirstName} {exam.AuthorSurname}";
            outputDescription.Text = exam.Description;

            if (Exam.LinkedBooks != null)
            {
                BookCatalog catalog = new BookCatalog();
                catalog.FindItemsByIds("_id", Exam.LinkedBooks);
                linkedBooksList.AddItems(catalog.ItemControls);
            }
        }

        private void buttonSolve_Click(object sender, EventArgs e)
        {
            ExamSessionForm examSessionForm = new ExamSessionForm(Exam);
            examSessionForm.ShowDialog();
        }
    }
}
