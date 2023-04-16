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
    public partial class UserManagementForm : Form
    {
        UserManagementCatalog UserCatalog { get; set; }
        List<KeyValuePair<string, string>> DropdownList { get; set; }

        public UserManagementForm()
        {
            if (!Session.CanOpenUserManagement) throw new UnauthorizedAccessException("Missing privilege to manage users");

            InitializeComponent();

            if (Session.CanAddUsers)
                buttonNewUser.Visible = true;
            if (Session.CanRemoveUsers)
                buttonDelete.Visible = true;
            if (Session.CanIssueBooks)
                buttonBorrow.Visible = true;


            if (Session.CanIssueBooks) buttonBorrow.Visible = true;
            UserCatalog = new UserManagementCatalog();

            columnSearch.DataSource = UserCatalog.SearchableFields;
            columnSearch.DisplayMember = "key";
        }

        private void buttonNewUser_Click(object sender, EventArgs e)
        {
            UserCreationForm userCreationForm = new UserCreationForm();
            userCreationForm.ShowDialog();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            UserCatalog.FindItems(
                    ((KeyValuePair<string, KeyValuePair<string, string>>)columnSearch.SelectedItem).Value.Value,
                    ((KeyValuePair<string, KeyValuePair<string, string>>)columnSearch.SelectedItem).Value.Key,
                    searchField.Text
                );
            userListPanel.AddItems(UserCatalog.ItemControls);
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            if (userListPanel.SelectedItem != null)
            {
                User user = (User)((UserItem)userListPanel.SelectedItem).ContainedItem;
                ItemSelectionForm selectionForm = new ItemSelectionForm(new BookCatalog());
                selectionForm.ShowDialog();
                if (selectionForm.DialogResult == DialogResult.OK)
                {
                    Book book = (Book)((BookItem)selectionForm.SelectedItem).ContainedItem;
                    if (!book.IsBorrowed)
                    {
                        string result = BorrowingCRUD.BorrowBookToUser(book, user);
                        if(result == null)
                        {
                            MessageBox.Show("Książka została wypożyczona.");
                        }
                        else
                        {
                            MessageBox.Show(result, "Błąd");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Książka jest już wypożyczona", "Błąd");
                    }
                }
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            User user = (User)((ICatalogItem)userListPanel.SelectedItem).ContainedItem;
            if(user!=null)
            {
                DialogResult confirmation = MessageBox.Show("Czy na pewno usunąć użytkownika?", "", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    string result = UserCRUD.DeleteUser(user);
                    if (result == null)
                    {
                        UserCatalog.DeleteFromList((ICatalogItem)userListPanel.SelectedItem);
                        userListPanel.DeleteSelectedItem();
                    }
                    else
                    {
                        MessageBox.Show(result, "Błąd");
                    }
                }
            }
        }
    }
}
