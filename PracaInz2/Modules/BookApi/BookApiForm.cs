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
    public partial class BookApiForm : Form
    {
        public BookApiForm()
        {
            InitializeComponent();
            if (Session.CanAddBooks) buttonAddBook.Visible = true;

            fieldSearchOptions.Items.Insert(0, "Tytuł");
            fieldSearchOptions.Items.Insert(1, "ISBN");
            fieldSearchOptions.SelectedIndex = 0;
            BookApiClient.initializeConnection();
        }

        private async void SearchForBooks()
        {
            if (string.IsNullOrEmpty(isbnInput.Text))
            {
                MessageBox.Show("Pole wyszukiwania nie może być puste");
            }
            else
            {
                try
                {
                    itemList.ClearList();
                    string searchField = "";
                    if (fieldSearchOptions.SelectedIndex == 0)
                    {
                        searchField = "intitle";
                    }
                    else if (fieldSearchOptions.SelectedIndex == 1)
                    {
                        searchField = "isbn";
                    }
                    string input = isbnInput.Text;
                    Console.WriteLine(input);
                    var books = await BookApiClient.GetBooks(input, searchField);
                    foreach (Book book in books)
                    {
                        itemList.AddItem(new BookItem(book));
                    }
                }
                catch
                {
                    Console.WriteLine("Unexpected error");
                }
            }
        }
        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            SearchForBooks();
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            Book book = (Book)((ICatalogItem)itemList.SelectedItem).ContainedItem;
            BookCreatorForm bookCreatorForm = new BookCreatorForm(book, false);
            bookCreatorForm.ShowDialog();
        }
    }
}
