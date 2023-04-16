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
    public partial class ExamResultCatalogForm : Form
    {
        ExamResultCatalog ExamResultCatalog { get; set; } = new ExamResultCatalog();

        public ExamResultCatalogForm()
        {
            if (!Session.CanViewExamResults)
            {
                throw new UnauthorizedAccessException("Missing privilege to view exam results");
            }

            InitializeComponent();

            columnSearch.DataSource = ExamResultCatalog.SearchableFields;
            columnSearch.DisplayMember = "key";

            comboBoxSortBy.DataSource = ExamResultCatalog.SortingFields;
            comboBoxSortBy.DisplayMember = "Name";
            comboBoxSortBy.SelectedIndex = -1;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            ExamResultCatalog.FindItems(
                    ((KeyValuePair<string, KeyValuePair<string, string>>)columnSearch.SelectedItem).Value.Value,
                    ((KeyValuePair<string, KeyValuePair<string, string>>)columnSearch.SelectedItem).Value.Key,
                    searchField.Text
                    );
            examResultPanel.AddItems(ExamResultCatalog.ItemControls);
            comboBoxSortBy.SelectedIndex = -1;
        }

        private void comboBoxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ExamResultCatalog.ItemControls.Length > 0)
            {
                ExamResultCatalog.Sort((SortingOrder)comboBoxSortBy.SelectedItem);
                examResultPanel.AddItems(ExamResultCatalog.ItemControls);
            }
        }

    }
}
