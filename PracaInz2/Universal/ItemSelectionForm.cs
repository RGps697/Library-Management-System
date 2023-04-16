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
    public partial class ItemSelectionForm : Form
    {
        ICatalog Catalog { get; set; }
        public ISelectableItem SelectedItem { get; set; }

        internal ItemSelectionForm(ICatalog catalog)
        {
            InitializeComponent();
            Catalog = catalog;
            columnSearch.DataSource = catalog.SearchableFields;
            columnSearch.DisplayMember = "key";
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchField.Text))
            {
                MessageBox.Show("Pole wyszukiwania nie może być puste");
            }
            else
            {
                Catalog.FindItems(
                    ((KeyValuePair<string, KeyValuePair<string, string>>)columnSearch.SelectedItem).Value.Value,
                    ((KeyValuePair<string, KeyValuePair<string, string>>)columnSearch.SelectedItem).Value.Key,
                    searchField.Text
                    );
                resultItemList.AddItems(Catalog.ItemControls);
            }
        }


        private void buttonSelect_Click(object sender, EventArgs e)
        {
            SelectedItem = resultItemList.SelectedItem;
            if (SelectedItem != null)
            {
                DialogResult = DialogResult.OK;
                SelectedItem.Deselected();
                Close();
            }
            else
            {
                MessageBox.Show("Nie wybrany został żaden element");
            }
        }

        private void ItemSelectionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            resultItemList.DeselectItem();
        }
    }
}
