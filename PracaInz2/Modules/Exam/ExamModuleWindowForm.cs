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
    public partial class ExamModuleWindowForm : Form
    {
        Form ActiveModule { get; set; }
        ToolMenuButton ActiveModuleButton { get; set; }

        public ExamModuleWindowForm()
        {
            if (!Session.CanAccessExamModule)
            {
                throw new UnauthorizedAccessException("Missing privilege to access exam module");
            }

            InitializeComponent();

            if (Session.CanBrowseExams)
            {
                buttonBrowse.Visible = true;
            }
            if (Session.CanCreateExams)
            {
                buttonManagement.Visible = true;
            }
            if (Session.CanViewExamResults)
            {
                buttonResults.Visible = true;
            }
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
            ModuleDisplayPanel.Controls.Add(chosenModule);
            ModuleDisplayPanel.Tag = chosenModule;
            chosenModule.BringToFront();
            chosenModule.Show();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenModule(new ExamBrowserForm(), buttonBrowse);
        }

        private void buttonManagement_Click(object sender, EventArgs e)
        {
            OpenModule(new ExamManagementForm(), buttonManagement);
        }

        private void buttonResults_Click(object sender, EventArgs e)
        {
            OpenModule(new ExamResultCatalogForm(), buttonResults);
        }
    }
}
