using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterfaceLibrary.Logic.Validators;

namespace UserInterfaceLibrary
{
    public partial class LibraryRoleCreatorForm : Form
    {
        public LibraryRole Role { get; set; }
        bool UpdateRole { get; set; } = false;

        public LibraryRoleCreatorForm()
        {
            InitializeComponent();

            if (!Session.CanCreateRole) throw new UnauthorizedAccessException("Missing privilege to create roles");

            Role = new LibraryRole();
        }

        internal LibraryRoleCreatorForm(LibraryRole role)
        {
            InitializeComponent();
            if (!Session.CanEditRole) throw new UnauthorizedAccessException("Missing privilege to edit roles");
            UpdateRole = true;
            Role = new LibraryRole(role);
            inputRoleName.Text = role.Name;
            InitializeEdit();
            

        }

        private void InitializeEdit()
        {
            buttonCancel.Visible = true;
            if (Role.IsPatron)
            {
                checkBoxPatron.Checked = true;
                checkBoxBorrowEbookByself.Checked = Role.Rights.CanBorrowEbooksByself;
                checkBoxAttemptExam.Checked = Role.Rights.CanAttemptExams;
            }

            if (Role.IsLibrarian)
            {
                checkBoxLibrarian.Checked = true;
                checkBoxAddBooks.Checked = Role.Rights.CanAddBook;
                checkBoxEditBooks.Checked = Role.Rights.CanEditBook;
                checkBoxRemoveBooks.Checked = Role.Rights.CanRemoveBook;
                checkBoxAddPatrons.Checked = Role.Rights.CanAddPatron;
                checkBoxEditPatrons.Checked = Role.Rights.CanEditPatron;
                checkBoxRemovePatrons.Checked = Role.Rights.CanRemovePatron;
            }

            if (Role.IsExaminer)
            {
                checkBoxExaminer.Checked = true;
                checkBoxCreateExam.Checked = Role.Rights.CanCreateExam;
                checkBoxViewAllExamResults.Checked = Role.Rights.CanViewAllExamResults;
            }

            if (Role.IsManager)
            {
                checkBoxManager.Checked = true;
            }

            if (Role.IsAdministrator)
            {
                checkBoxAdministrator.Checked = true;
            }
        }

        private void AllRightsWithdraw(Control container)
        {
            if (!container.Enabled)
            {
                for (int i = 0; i < container.Controls.Count; i++)
                {
                    ((CheckBox)container.Controls[i]).Checked = false;
                }
            }
        }


        private void inputRoleName_TextChanged(object sender, EventArgs e)
        {
            Role.Name = inputRoleName.Text;
        }

        //PATRON
        private void checkBoxPatron_CheckedChanged(object sender, EventArgs e)
        {
            panelPatron.Enabled = checkBoxPatron.Checked;
            AllRightsWithdraw(panelPatron);
            Role.IsPatron = checkBoxPatron.Checked;
        }

        private void checkBoxSearchCatalog_CheckedChanged(object sender, EventArgs e)
        {
            Role.Rights.CanBorrowEbooksByself = checkBoxBorrowEbookByself.Checked;
        }

        private void checkBoxAttemptExam_CheckedChanged(object sender, EventArgs e)
        {
            Role.Rights.CanAttemptExams = checkBoxAttemptExam.Checked;
        }

        //LIBRARIAN
        private void checkBoxLibrarian_CheckedChanged(object sender, EventArgs e)
        {
            PanelLibrarian.Enabled = checkBoxLibrarian.Checked;
            if (!checkBoxCreateExam.Checked)
            {
                checkBoxPatron.Checked = checkBoxLibrarian.Checked;
                checkBoxPatron.Enabled = !checkBoxLibrarian.Checked;
            }
            AllRightsWithdraw(PanelLibrarian);

            Role.IsLibrarian = checkBoxLibrarian.Checked;
        }

        private void checkBoxAddBooks_CheckedChanged(object sender, EventArgs e)
        {
            Role.Rights.CanAddBook = checkBoxAddBooks.Checked;
        }

        private void checkBoxEditBooks_CheckedChanged(object sender, EventArgs e)
        {
            Role.Rights.CanEditBook = checkBoxEditBooks.Checked;
        }

        private void checkBoxRemoveBooks_CheckedChanged(object sender, EventArgs e)
        {
            Role.Rights.CanRemoveBook = checkBoxRemoveBooks.Checked;
        }

        private void checkBoxAddPatrons_CheckedChanged(object sender, EventArgs e)
        {
            Role.Rights.CanAddPatron = checkBoxAddPatrons.Checked;
        }

        private void checkBoxEditPatrons_CheckedChanged(object sender, EventArgs e)
        {
            Role.Rights.CanEditPatron = checkBoxEditPatrons.Checked;
        }

        private void checkBoxRemovePatrons_CheckedChanged(object sender, EventArgs e)
        {
            Role.Rights.CanRemovePatron = checkBoxRemovePatrons.Checked;
        }

        //EXAMINER
        private void checkBoxExaminer_CheckedChanged(object sender, EventArgs e)
        {
            panelExaminer.Enabled = checkBoxExaminer.Checked;
            AllRightsWithdraw(panelExaminer);

            Role.IsExaminer = checkBoxExaminer.Checked;
        }

        private void checkBoxCreateExam_CheckedChanged(object sender, EventArgs e)
        {
            Role.Rights.CanCreateExam = checkBoxCreateExam.Checked;
            if (!checkBoxLibrarian.Checked)
            {
                checkBoxPatron.Checked = checkBoxCreateExam.Checked;
                checkBoxPatron.Enabled = !checkBoxCreateExam.Checked;
            }
        }

        private void checkBoxViewAllExamResults_CheckedChanged(object sender, EventArgs e)
        {
            Role.Rights.CanViewAllExamResults = checkBoxViewAllExamResults.Checked;
        }

        //Manager
        private void checkBoxManager_CheckedChanged(object sender, EventArgs e)
        {
            panelManager.Enabled = checkBoxManager.Checked;
            AllRightsWithdraw(panelManager);

            Role.IsManager = checkBoxManager.Checked;
        }

        //ADMIN
        private void checkBoxAdministrator_CheckedChanged(object sender, EventArgs e)
        {

            Role.IsAdministrator = checkBoxAdministrator.Checked;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            LibraryRoleValidator validator = new LibraryRoleValidator();
            var results = validator.Validate(Role);
            if (results.IsValid == false)
            {
                string errorMessage = "";
                foreach (var error in results.Errors)
                {
                    errorMessage += error.ErrorMessage + "\n";
                }
                MessageBox.Show(errorMessage);
            }
            else
            {
                string result;
                if (UpdateRole)
                {
                    result = LibraryRoleCRUD.UpdateRole(Role);
                    DialogResult= DialogResult.OK;
                }
                else
                {
                    result = LibraryRoleCRUD.CreateRole(Role);
                }

                if (result == null)
                {
                    MessageBox.Show("Rola została zapisana");
                }
                else
                {
                    MessageBox.Show(result);
                }
                Close();
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            string result = LibraryRoleCRUD.DeleteLibraryRole(Role);
            if (result == null) { 
                Close();
            }
            else{
                MessageBox.Show(result, "Błąd");
            }
        }
    }
}
