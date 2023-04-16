using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserInterfaceLibrary.Management;

namespace UserInterfaceLibrary
{
    public partial class ManagementWindowForm : Form
    {
        Form ActiveModule { get; set; }
        ToolMenuButton ActiveModuleButton { get; set; }

        public ManagementWindowForm()
        {
            if (!Session.CanAccessManagementModule) throw new UnauthorizedAccessException("Missing privilege to manage library resources");
            InitializeComponent();

            if (Session.CanOpenUserManagement) buttonUsers.Visible = true;
            if (Session.CanOpenBookManagement) buttonBooks.Visible = true;
            if (Session.CanOpenBorrowingsManagement) buttonBorrowings.Visible = true;
            if (Session.CanOpenRoleManagement) buttonRoles.Visible = true;
        }

        private void OpenModule(Form chosenModule, ToolMenuButton clickedButton)
        {
            if (ActiveModule != null)
            {
                ActiveModule.Close();
            }

            if (ActiveModuleButton != null)
            {
                ActiveModuleButton.Deselected();
            }
            ActiveModuleButton = clickedButton;
            ActiveModuleButton.Selected();

            ActiveModule = chosenModule;
            chosenModule.TopLevel = false;
            chosenModule.FormBorderStyle = FormBorderStyle.None;
            chosenModule.Dock = DockStyle.Fill;
            managementPanel.Controls.Add(chosenModule);
            managementPanel.Tag = chosenModule;
            chosenModule.BringToFront();
            chosenModule.Show();

        }

        private void buttonUsersForm_Click(object sender, EventArgs e)
        {
            OpenModule(new UserManagementForm(), buttonUsers);
        }

        private void buttonBooks_Click(object sender, EventArgs e)
        {
            OpenModule(new BookManagementForm(), buttonBooks);
        }

        private void buttonBorrowings_Click(object sender, EventArgs e)
        {
            OpenModule(new BorrowingManagementForm(), buttonBorrowings);
        }

        private void buttonRoles_Click(object sender, EventArgs e)
        {
            OpenModule(new LibraryRoleManagementForm(), buttonRoles);
        }
    }
}
