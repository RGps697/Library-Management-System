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
    public partial class AdminCreationForm : Form
    {
        LibraryRole RootRole { get; set; }

        public AdminCreationForm()
        {
            InitializeComponent();
            List<LibraryRole> role = LibraryRoleCRUD.FindRoles("Name", "Root Administrator");
            if(role.Count == 0)
            {
                CreateRootRole();
            }
            else
            {
                RootRole = role[0];
            }
        }

        private void CreateRootRole()
        {
            RootRole = new LibraryRole
            {
                Name = "Root Administrator",
                IsPatron = true,
                IsLibrarian = true,
                IsExaminer = true,
                IsManager = true,
                IsAdministrator = true
            };
            RootRole.Rights.CanBorrowEbooksByself = true;
            RootRole.Rights.CanAttemptExams = true;
            RootRole.Rights.CanAddBook = true;
            RootRole.Rights.CanEditBook = true;
            RootRole.Rights.CanRemoveBook = true;
            RootRole.Rights.CanAddPatron = true;
            RootRole.Rights.CanEditPatron = true;
            RootRole.Rights.CanRemovePatron = true;
            RootRole.Rights.CanCreateExam = true;
            RootRole.Rights.CanViewAllExamResults = true;
            RootRole.Rights.CanAddAdministrator = true;
            LibraryRoleCRUD.CreateRole(RootRole);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (inputPassword.Text == inputPasswordRepeat.Text)
            {
                User user = new User();
                user.Email = inputEmail.Text;
                user.FirstName = "rootadmin";
                user.Surname = "rootadmin";
                user.Password = inputPassword.Text;
                user.RoleId = RootRole.Id;
                string result = Session.CreateRootAdmin(user);//UserCRUD.CreateUser(user);
                if (result != null)
                {
                    MessageBox.Show(result);
                }
                else
                {
                    MessageBox.Show("Użytkownik został dodany.");
                    DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("Wprowadzone hasła nie są zgodne.");
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
