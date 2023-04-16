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
    public partial class ChangePasswordForm : Form
    {
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(inputPassword.Text == inputRepeatPassword.Text)
            {
                if (UserCRUD.ChangePassword(inputPassword.Text))
                {
                    MessageBox.Show("Hasło zostało zmienione");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Wprowadzone hasła nie są zgodne");
            }
        }
    }
}
