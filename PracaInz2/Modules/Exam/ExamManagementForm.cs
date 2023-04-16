using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceLibrary.Management
{
    public partial class ExamManagementForm : Form
    {
        ExamCatalog ExamCatalog { get; set; }

        public ExamManagementForm()
        {
            if (!Session.CanCreateExams)
            {
                throw new UnauthorizedAccessException("Missing privilege to create exams");
            }
            InitializeComponent();
            ExamCatalog = new ExamManagementCatalog();

            columnSearch.DataSource = ExamCatalog.SearchableFields;
            columnSearch.DisplayMember = "key";
        }

        private void buttonNewExam_Click(object sender, EventArgs e)
        {
            ExamCreatorForm creatorForm = new ExamCreatorForm();
            creatorForm.ShowDialog();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            ExamCatalog.FindItems(
                    ((KeyValuePair<string, KeyValuePair<string, string>>)columnSearch.SelectedItem).Value.Value,
                    ((KeyValuePair<string, KeyValuePair<string, string>>)columnSearch.SelectedItem).Value.Key,
                    searchField.Text
                    );
            examListPanel.AddItems(ExamCatalog.ItemControls);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Czy na pewno usunąć książkę?", "", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                ExamCRUD.DeleteExam((Exam)((ICatalogItem)examListPanel.SelectedItem).ContainedItem);
                ExamCatalog.DeleteFromList((ICatalogItem)examListPanel.SelectedItem);
                examListPanel.DeleteSelectedItem();
            }
        }
    }
}
