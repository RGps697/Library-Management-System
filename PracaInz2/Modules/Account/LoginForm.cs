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
    public partial class LoginForm : Form
    {
        private Action OnLogin { get; set; }

        public LoginForm(Action onLogin)
        {
            InitializeComponent();
            OnLogin = onLogin;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            bool result = Session.LogIn(textBoxEmail.Text, textBoxPassword.Text);
            if (result)
            {
                OnLogin();
            }
            else
            {
                MessageBox.Show("Błędny e-mail lub hasło");
            }
        }
    }
}
