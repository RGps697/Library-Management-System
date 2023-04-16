using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceLibrary
{
    public partial class FormMainWindow : Form
    {
        Form ActiveModule { get; set; }
        MainMenuButton ActiveModuleButton { get; set; }

        public FormMainWindow()
        {
            InitializeComponent();
            if (!System.IO.File.Exists("appdbconfig.json"))
            {
                DBConnectionForm connectionForm = new DBConnectionForm();
                connectionForm.ShowDialog();
            }
            
            if (!DatabaseGateway.ConnectToDatabase())
            {
                MessageBox.Show("Nie udało połączyć się z bazą danych");
            }
            else
            {
                if (Session.CheckIfDatabaseEmpty())
                {
                    AdminCreationForm adminCreationForm = new AdminCreationForm();
                    adminCreationForm.ShowDialog();
                    if (adminCreationForm.DialogResult == DialogResult.OK)
                    {
                        OpenModule(new LoginForm(OnLogin), buttonAccount);
                    }
                }
                else
                {
                    OpenModule(new LoginForm(OnLogin), buttonAccount);
                }
            }
        }

        private void OpenModule(Form chosenModule, MainMenuButton clickedButton)
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
            desktopPanel.Controls.Add(chosenModule);
            desktopPanel.Tag = chosenModule;
            chosenModule.BringToFront();
            chosenModule.Show();

        }

        private void OnLogin()
        {
            OpenModule(new UserDashboardForm(OnLogout), buttonAccount);
            ShowActiveUserModules();
        }

        private void OnLogout()
        {
            OpenModule(new LoginForm(OnLogin), buttonAccount);
            HideModules();
        }

        public void ShowActiveUserModules()
        {
            buttonSettings.Visible = true;
            if (Session.CanAccessExamModule)
            {
                buttonExam.Visible = true;
            }
            if (Session.CanAccessManagementModule)
            {
                buttonManagement.Visible = true;
            }
            if (Session.CanBrowseBookCatalog)
            {
                buttonCatalog.Visible = true;
            }
        }

        private void HideModules()
        {
            buttonSettings.Visible = false;
            buttonCatalog.Visible = false;
            buttonManagement.Visible = false;
            buttonExam.Visible = false;
        }

        private void buttonAccount_Click(object sender, EventArgs e)
        {
            if (Session.ActiveUser != null)
            {
                OpenModule(new UserDashboardForm(OnLogout), buttonAccount);
            }
            else
            {
                OpenModule(new LoginForm(OnLogin), buttonAccount);
            }
        }

        private void buttonCatalog_Click(object sender, EventArgs e)
        {
            BookCatalogForm formCatalog = new BookCatalogForm();
            OpenModule(formCatalog, buttonCatalog);
        }

        private void buttonManagement_Click(object sender, EventArgs e)
        {
            OpenModule(new ManagementWindowForm(), buttonManagement);
        }

        private void buttonExams_Click(object sender, EventArgs e)
        {
            OpenModule(new ExamModuleWindowForm(), buttonExam);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.ShowDialog();
        }
    }
}
