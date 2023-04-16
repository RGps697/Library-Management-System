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
    [System.ComponentModel.ToolboxItem(false)]
    public partial class BorrowingItem : UserControl, ICatalogItem
    {
        public ILibraryItem ContainedItem { get; set; }
        public Action<ISelectableItem> OnItemClick { get; set; }
        public bool IsSelected { get; set; } = false;
        private bool isOverdue = false;

        public BorrowingItem(Borrowing borrowing)
        {
            InitializeComponent();
            FillData(borrowing);
            if (borrowing.ReturnDate < DateTime.Now)
            {
                isOverdue = true;
                BackColor = UIColors.OverdueBorrowingColor;
            }
            EventWrapper(labelTitle);
            EventWrapper(labelBorrower);
            EventWrapper(labelDates);
            EventWrapper(tableLayoutPanel1);
        }

        public void RefreshLabelTexts()
        {
            FillData((Borrowing)ContainedItem);
        }

        private void FillData(Borrowing borrowing)
        {
            ContainedItem = borrowing;
            labelTitle.Text = borrowing.Title;
            labelBorrower.Text = borrowing.Surname + " " + borrowing.FirstName;
            labelDates.Text = $"{borrowing.BorrowDate.ToString("dd/MM/yyyy")} - {borrowing.ReturnDate.ToString("dd/MM/yyyy")}";
        }

        private void EventWrapper(Control ctrl)
        {
            ctrl.Click += new EventHandler(ItemClicked);
            ctrl.MouseEnter += new EventHandler(OnHover);
            ctrl.MouseLeave += new EventHandler(OnLeave);
        }

        public void ItemClicked(object sender, EventArgs e)
        {
            if (OnItemClick != null)
            {
                OnItemClick(this);
            }
        }

        public void OnHover(object sender, EventArgs e)
        {
            if (!IsSelected)
                if (isOverdue)
                {
                    BackColor = UIColors.OverdueBorrowingHoverColor;
                }
                else
                {
                    BackColor = UIColors.SelectableItemHoverColor;
                }
        }

        public void OnLeave(object sender, EventArgs e)
        {
            if (!IsSelected)
                if (isOverdue)
                {
                    BackColor = UIColors.OverdueBorrowingColor;
                }
                else
                {
                    BackColor = UIColors.SelectableItemColor;
                }
        }

        public void ItemDoubleClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void Selected()
        {
            BackColor = UIColors.SelectableItemSelectedColor;
        }

        public void Deselected()
        {
            if (isOverdue)
            {
                BackColor = UIColors.OverdueBorrowingColor;
            }
            else
            {
                BackColor = UIColors.SelectableItemColor;
            }
        }
    }
}
