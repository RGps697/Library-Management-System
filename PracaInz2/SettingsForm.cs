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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            if(Session.CanEditClientSettings)
            {
                buttonChangeSettings.Visible = true;
            }
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {
            ChangePasswordForm changePasswordForm = new ChangePasswordForm();
            changePasswordForm.ShowDialog();
        }

        private void buttonChangeSettings_Click(object sender, EventArgs e)
        {
            DBConnectionForm dbConnection = new DBConnectionForm();
            dbConnection.Show();
        }
    }
}
