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
    public partial class DBConnectionForm : Form
    {
        public DBConnectionForm()
        {
            InitializeComponent();
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            bool result = DatabaseGateway.AttemptConnection(connectionIpInput.Text, portInput.Text, userInput.Text, passwordInput.Text);
            if (result)
            {
                MessageBox.Show("Połączono");
            }
            else
            {
                MessageBox.Show("Błąd przy połączeniu");
            }
        }
    }
}
