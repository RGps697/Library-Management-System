using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UserInterfaceLibrary
{
    public partial class BookCatalogForm : Form
    {
        BookCatalog BookCatalog { get; set; }

        public BookCatalogForm()
        {
            if (!Session.CanBrowseBookCatalog)
            {
                throw new UnauthorizedAccessException("Missing privilege to browse book catalog");
            }

            InitializeComponent();
            BookCatalog = new BookCatalog();

            columnSearch.DataSource = BookCatalog.SearchableFields;
            columnSearch.DisplayMember = "key";

            comboBoxSortBy.DataSource = BookCatalog.SortingFields;
            comboBoxSortBy.DisplayMember = "Name";
            comboBoxSortBy.SelectedIndex = -1;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchField.Text))
            {
                MessageBox.Show("Pole wyszukiwania nie może być puste");
            }
            else
            {
                BookCatalog.FindItems(
                    ((KeyValuePair<string, KeyValuePair<string, string>>)columnSearch.SelectedItem).Value.Value,
                    ((KeyValuePair<string, KeyValuePair<string, string>>)columnSearch.SelectedItem).Value.Key,
                    searchField.Text
                    );
                bookListPanel.AddItems(BookCatalog.ItemControls);
                comboBoxSortBy.SelectedIndex = -1;
            }
        }

        private void searchField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonSearch_Click(this, null);
                e.Handled = true;
            }
        }

        private void comboBoxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BookCatalog.ItemControls.Length > 0 && comboBoxSortBy.SelectedIndex >= 0)
            {
                BookCatalog.Sort((SortingOrder)comboBoxSortBy.SelectedItem);
                bookListPanel.AddItems(BookCatalog.ItemControls);
            }
        }
    }
    

}
