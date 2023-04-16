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
    public partial class UserDashboardForm : Form
    {
        internal BookCatalog BookCatalog { get; private set; } = new BookCatalog();
        internal ExamResultCatalog ExamResultCatalog { get; private set; } = new ExamResultCatalog();
        internal Action OnLogout { get; private set; }

        public UserDashboardForm(Action onLogout)
        {
            InitializeComponent();
            OnLogout = onLogout;
        }

        private void buttonBorrowedBooks_Click(object sender, EventArgs e)
        {
            BookCatalog.FindItemsById("BorrowedBy", Session.ActiveUserId);
            Debug.WriteLine($"user dashboard lenght: {BookCatalog.ItemControls.Length}");
            TabChanged(BookCatalog.ItemControls);
        }

        private void buttonExamAttempts_Click(object sender, EventArgs e)
        {
            ExamResultCatalog.FindItemsById("UserId", Session.ActiveUserId);
            TabChanged(ExamResultCatalog.ItemControls);
        }

        private void TabChanged(ISelectableItem[] items)
        {
            itemsPanel.AddItems(items);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            bool result = Session.LogOut();
            if (result)
            {
                OnLogout();
            }
        }

        private void buttonChangePassword_Click(object sender, EventArgs e)
        {

        }
    }
}
