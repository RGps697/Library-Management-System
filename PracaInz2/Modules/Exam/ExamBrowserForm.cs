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
    public partial class ExamBrowserForm : Form
    {
        ExamCatalog ExamCatalog;

        public ExamBrowserForm()
        {
            if (!Session.CanBrowseExams)
            {
                throw new UnauthorizedAccessException("Missing privilege to browse exams");
            }

            InitializeComponent();
            ExamCatalog = new ExamCatalog();

            columnSearch.DataSource = ExamCatalog.SearchableFields;
            columnSearch.DisplayMember = "key";
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            ExamCatalog.FindItems(nameof(Exam.Name), searchField.Text);
            examListPanel.AddItems(ExamCatalog.ItemControls);
        }
    }
}
