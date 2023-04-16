using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceLibrary.Management
{
    public partial class LibraryRoleManagementForm : Form
    {
        LibraryRoleCatalog LibraryRoleCatalog { get; set; }

        public LibraryRoleManagementForm()
        {
            if(!Session.CanOpenRoleManagement) throw new UnauthorizedAccessException("Missing privilege to manage roles");
            InitializeComponent();
            LibraryRoleCatalog = new LibraryRoleCatalog();
            columnSearch.DataSource = LibraryRoleCatalog.SearchableFields;
            columnSearch.DisplayMember = "key";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            LibraryRoleCreatorForm roleCreatorForm = new LibraryRoleCreatorForm();
            roleCreatorForm.ShowDialog();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            LibraryRoleCatalog.FindItems(
                    ((KeyValuePair<string, KeyValuePair<string, string>>)columnSearch.SelectedItem).Value.Value,
                    ((KeyValuePair<string, KeyValuePair<string, string>>)columnSearch.SelectedItem).Value.Key,
                    searchField.Text
                );
            roleListPanel.AddItems(LibraryRoleCatalog.ItemControls);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = MessageBox.Show("Czy na pewno usunąć książkę?", "", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                string result = LibraryRoleCRUD.DeleteLibraryRole((LibraryRole)((ICatalogItem)roleListPanel.SelectedItem).ContainedItem);
                if (result == null)
                {
                    LibraryRoleCatalog.DeleteFromList((ICatalogItem)roleListPanel.SelectedItem);
                    roleListPanel.DeleteSelectedItem();
                }
                else
                {
                    MessageBox.Show(result, "Błąd");
                }
            }
        }
    }
}
