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
    public partial class BorrowingManagementForm : Form
    {
        BorrowingCatalog BorrowingCatalog { get; set; }

        public BorrowingManagementForm()
        {
            if(!Session.CanOpenBorrowingsManagement) throw new UnauthorizedAccessException("Missing privilege to manage borrowings");
            InitializeComponent();
            BorrowingCatalog = new BorrowingCatalog();
            columnSearch.DataSource = BorrowingCatalog.SearchableFields;
            columnSearch.ValueMember = "value";
            columnSearch.DisplayMember = "key";
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            string column = ((KeyValuePair<string, KeyValuePair<string, string>>)columnSearch.SelectedItem).Value.Key;
            string collection = ((KeyValuePair<string, KeyValuePair<string, string>>)columnSearch.SelectedItem).Value.Value;
            BorrowingCatalog.FindItems(collection, column, searchField.Text);
            Console.WriteLine($"kolumna: {column}, kolekcja: {collection}");
            borrowingListPanel.AddItems(BorrowingCatalog.ItemControls);
        }

        private void buttonReturnBook_Click(object sender, EventArgs e)
        {
            string result = BorrowingCRUD.ReturnBook((Borrowing)((BorrowingItem)borrowingListPanel.SelectedItem).ContainedItem);
            if (result == null) { 
                BorrowingCatalog.DeleteFromList((ICatalogItem)borrowingListPanel.SelectedItem);
                borrowingListPanel.DeleteSelectedItem();
                MessageBox.Show("Książka została zwrócona.");
            }
            else
            {
                MessageBox.Show(result);
            }
        }

        private void buttonExtend_Click(object sender, EventArgs e)
        {
            if (borrowingListPanel.SelectedItem != null)
            {
                BorrowingCRUD.ExtendDuePeriod((Borrowing)((BorrowingItem)borrowingListPanel.SelectedItem).ContainedItem);
                ((BorrowingItem)borrowingListPanel.SelectedItem).RefreshLabelTexts();
                MessageBox.Show($"Okres wypożyczenia został wydłużony do: {((Borrowing)((BorrowingItem)borrowingListPanel.SelectedItem).ContainedItem).ReturnDate}.");
            }
        }
    }
}
