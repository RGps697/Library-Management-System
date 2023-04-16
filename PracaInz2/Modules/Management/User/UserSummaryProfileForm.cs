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
    public partial class UserSummaryProfileForm : Form
    {
        public User User { get; private set; }
        BorrowingCatalog BorrowingCatalog { get; set; } = new BorrowingCatalog();

        internal UserSummaryProfileForm(User user)
        {
            InitializeComponent();
            if (Session.CanIssueBooks) buttonBorrow.Visible = true;
            if (Session.CanReturnBooks) buttonReturn.Visible = true;
            if (Session.CanEditUsers && Session.CheckUserPrivilege(user)) buttonEdit.Visible = true;
            if (Session.CanRemoveUsers && Session.CheckUserPrivilege(user)) buttonDeleteUser.Visible = true;

            User = user;
            FillData(User);
            LoadUserBorrowings();
        }

        private void FillData(User user)
        {
            labelFirstName.Text = user.FirstName;
            labelSurname.Text = user.Surname;
            labelEmail.Text = user.Email;
            labelPhoneNumber.Text = user.PhoneNumber;
            labelRole.Text = user.Role.Name;
        }

        private void LoadUserBorrowings(bool reload = false)
        {
            BorrowingCatalog.FindItemsById("UserId", User.Id);
            userBorrowingsPanel.AddItems(BorrowingCatalog.ItemControls, reload);
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Czy na pewno usunąć użytkownika?", "", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                string result = UserCRUD.DeleteUser(User);
                if (result == null)
                {
                    Close();
                }
                else
                {
                    MessageBox.Show(result, "Błąd");
                }
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            UserCreationForm userCreationForm = new UserCreationForm(User);
            userCreationForm.ShowDialog();
            if(userCreationForm.DialogResult== DialogResult.OK) 
            {
                User = userCreationForm.User;
                FillData(User);
            }
        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            if (userBorrowingsPanel.SelectedItem != null)
            {
                string result = BorrowingCRUD.ReturnBook((Borrowing)((BorrowingItem)userBorrowingsPanel.SelectedItem).ContainedItem);
                if (result == null)
                {
                    BorrowingCatalog.DeleteFromList((BorrowingItem)userBorrowingsPanel.SelectedItem);
                    userBorrowingsPanel.DeleteSelectedItem();
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
        }

        private void buttonBorrow_Click(object sender, EventArgs e)
        {
            ItemSelectionForm borrowSelectionForm = new ItemSelectionForm(new BookCatalog());
            var result = borrowSelectionForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                string borrowResult = BorrowingCRUD.BorrowBookToUser((Book)((ICatalogItem)borrowSelectionForm.SelectedItem).ContainedItem, User);
                if (borrowResult == null)
                {
                    LoadUserBorrowings(true);
                }
                else
                {
                    MessageBox.Show(borrowResult);
                }
            }

        }
    }
}
