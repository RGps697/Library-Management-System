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
    public partial class ExamResultItem : UserControl, ICatalogItem
    {
        public ILibraryItem ContainedItem { get; set; }
        public Action<ISelectableItem> OnItemClick { get; set; }
        public bool IsSelected { get; set; } = false;

        private ExamResultItem()
        {
            InitializeComponent();
        }

        public ExamResultItem(ExamResult examResult) : this()
        {
            ContainedItem = examResult;
            labelExamName.Text = examResult.ExamName;
            labelExamTaker.Text = $"{examResult.UserFirstName} {examResult.UserSurname}";
            labelScore.Text = examResult.Score.ToString();
        }

        public void ItemClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void OnHover(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void OnLeave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
