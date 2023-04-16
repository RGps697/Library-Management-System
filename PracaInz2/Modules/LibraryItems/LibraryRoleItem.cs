using LogicLibrary;
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
    public partial class LibraryRoleItem : UserControl, ICatalogItem
    {
        public ILibraryItem ContainedItem { get; set; }
        public Action<ISelectableItem> OnItemClick { get; set; }
        public bool IsSelected { get; set; } = false;

        private LibraryRoleItem()
        {
            InitializeComponent();
            EventWrapper(this);
            EventWrapper(label1);
            EventWrapper(outputName);
            EventWrapper(tableLayoutPanel1);
        }


        internal LibraryRoleItem(LibraryRole libraryRole) : this()
        {
            ContainedItem = libraryRole;
            FillData(libraryRole);
        }

        public void FillData(LibraryRole role)
        {
            outputName.Text = role.Name;
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
            LibraryRoleCreatorForm roleCreatorForm = new LibraryRoleCreatorForm((LibraryRole)ContainedItem);
            roleCreatorForm.ShowDialog();
            if(roleCreatorForm.DialogResult == DialogResult.OK)
            {
                ContainedItem = roleCreatorForm.Role;
                FillData(roleCreatorForm.Role);
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
