using System;
using System.Windows.Forms;

namespace UserInterfaceLibrary
{
    [System.ComponentModel.ToolboxItem(false)]
    public partial class UserItem : UserControl, ICatalogItem
    {
        [System.ComponentModel.ToolboxItem(false)]
        public ILibraryItem ContainedItem { get; set; }
        public Action<BorrowingItem> OnSelect { get; set; }
        public Action<ISelectableItem> OnItemClick { get; set; }
        public bool IsSelected { get; set; } = false;
        private bool OpenSummary { get; set; }

        public UserItem()
        {
            InitializeComponent();
            EventWrapper(this);
            EventWrapper(icon);
            EventWrapper(labelFirstName);
            EventWrapper(labelSurname);
            EventWrapper(labelEmail);
            EventWrapper(labelPhoneNumber);
            EventWrapper(tableLayoutPanel1);
        }

        internal UserItem(User user, bool openSummary = false) : this()
        {
            FillData(user);
            OpenSummary = openSummary;
        }

        private void FillData(User user)
        {
            icon.Image = Icons.userIcon;
            ContainedItem = user;
            labelFirstName.Text = user.FirstName;
            labelSurname.Text = user.Surname;
            labelEmail.Text = user.Email;
            labelPhoneNumber.Text = user.PhoneNumber;
        }

        private void EventWrapper(Control ctrl)
        {
            ctrl.Click += new EventHandler(ItemClicked);
            ctrl.MouseEnter += new EventHandler(OnHover);
            ctrl.MouseLeave += new EventHandler(OnLeave);
            ctrl.DoubleClick += new EventHandler(ItemDoubleClicked);
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
                BackColor = UIColors.SelectableItemHoverColor;
        }

        public void OnLeave(object sender, EventArgs e)
        {
            if (!IsSelected)
                BackColor = UIColors.SelectableItemColor;
        }
        public void ItemDoubleClicked(object sender, EventArgs e)
        {
            if (OpenSummary)
            {
                UserSummaryProfileForm profile = new UserSummaryProfileForm((User)ContainedItem);
                profile.ShowDialog();
                ContainedItem = profile.User;
                FillData(profile.User);
            }
        }

        public void Selected()
        {
            BackColor = UIColors.SelectableItemSelectedColor;
        }

        public void Deselected()
        {
            BackColor = UIColors.SelectableItemColor;
        }
    }
}
