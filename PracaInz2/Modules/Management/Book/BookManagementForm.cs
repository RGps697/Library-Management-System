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
    public partial class BookManagementForm : Form
    {
        BookManagementCatalog BookManagementCatalog { get; set; } = new BookManagementCatalog();

        public BookManagementForm()
        {
            if(!Session.CanOpenBookManagement) throw new UnauthorizedAccessException("Missing privilege to manage books");

            InitializeComponent();

            if (Session.CanAddBooks) buttonNewBook.Visible = true;
            if (Session.CanRemoveBooks) buttonDelete.Visible = true;
            if (Session.CanIssueBooks) buttonBorrow.Visible = true;

            columnSearch.DataSource = BookManagementCatalog.SearchableFields;
            columnSearch.DisplayMember = "key";

            comboBoxSortBy.DataSource = BookManagementCatalog.SortingFields;
            comboBoxSortBy.DisplayMember = "Name";
        }

        private void buttonNewBook_Click(object sender, EventArgs e)
        {
            BookCreatorForm creatorForm = new BookCreatorForm();
            creatorForm.ShowDialog();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            bookListPanel.SelectedItem = null;
            BookManagementCatalog.FindItems(
                    ((KeyValuePair<string, KeyValuePair<string, string>>)columnSearch.SelectedItem).Value.Value,
                    ((KeyValuePair<string, KeyValuePair<string, string>>)columnSearch.SelectedItem).Value.Key,
                    searchField.Text
                );
            bookListPanel.AddItems(BookManagementCatalog.ItemControls);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Book book = (Book)((ICatalogItem)bookListPanel.SelectedItem).ContainedItem;
            if (book != null)
            {
                DialogResult confirmation = MessageBox.Show("Czy na pewno usunąć książkę?", "", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    string result = BookCRUD.DeleteBook(book);
                    if (result == null)
                    {
                        BookManagementCatalog.DeleteFromList((ICatalogItem)bookListPanel.SelectedItem);
                        bookListPanel.DeleteSelectedItem();
                    }
                    else
                    {
                        MessageBox.Show(result, "Błąd");
                    }
                }
            }
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            if (bookListPanel.SelectedItem != null)
            {
                Book book = (Book)((BookItem)bookListPanel.SelectedItem).ContainedItem;
                if (!book.IsBorrowed)
                {
                    ItemSelectionForm selectionForm = new ItemSelectionForm(new UserCatalog());
                    selectionForm.ShowDialog();
                    if (selectionForm.DialogResult == DialogResult.OK)
                    {
                        User user = (User)((UserItem)selectionForm.SelectedItem).ContainedItem;
                        Console.WriteLine(user.FirstName);
                        Console.WriteLine(user.Id);
                        string result = BorrowingCRUD.BorrowBookToUser(book, user);
                        if (result == null)
                        {
                            MessageBox.Show("Książka została wypożyczona");
                        }
                        else
                        {
                            MessageBox.Show(result);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Książka jest już wypożyczona");
                }
            }
        }

        private void buttonIsbnApi_Click(object sender, EventArgs e)
        {
            BookApiForm bookApiForm = new BookApiForm();
            bookApiForm.Show();
        }

        private void comboBoxSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(BookManagementCatalog.ItemControls.Length > 0){
                BookManagementCatalog.Sort((SortingOrder)comboBoxSortBy.SelectedItem);
                bookListPanel.AddItems(BookManagementCatalog.ItemControls);
            }
        }

    }
}
