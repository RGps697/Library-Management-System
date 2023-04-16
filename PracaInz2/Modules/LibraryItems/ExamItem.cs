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
    [ToolboxItem(false)]
    public partial class ExamItem : UserControl, ICatalogItem
    {
        public ILibraryItem ContainedItem { get; set; }
        public Action<ISelectableItem> OnItemClick { get; set; }
        public bool IsSelected { get; set; } = false;
        private bool EditExam { get; set; }

        public ExamItem()
        {
            InitializeComponent();
            EventWrapper(this);
            EventWrapper(tableLayoutPanel1);
            EventWrapper(label1);
            EventWrapper(label2);
            EventWrapper(label3);
            EventWrapper(outputName);
            EventWrapper(outputAuthor);
            EventWrapper(outputQuestionsToAnswer);
        }

        internal ExamItem(Exam exam, bool editExam = false) : this()
        {
            ContainedItem = exam;
            FillData(exam);
            EditExam = editExam;
        }

        private void FillData(Exam exam)
        {
            outputName.Text = exam.Name;
            outputAuthor.Text = $"{exam.AuthorFirstName} {exam.AuthorSurname}";
            outputQuestionsToAnswer.Text = exam.QuestionAmountPerSession.ToString();
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
            if (EditExam && Session.ActiveUserId == ((Exam)ContainedItem).Author)
            {
                ExamCreatorForm creator = new ExamCreatorForm((Exam)ContainedItem);
                creator.ShowDialog();
                if(creator.DialogResult == DialogResult.OK)
                {
                    ContainedItem = creator.Exam;
                    FillData(creator.Exam);
                }
            }
            else
            {
                ExamViewerForm viewer = new ExamViewerForm((Exam)ContainedItem);
                viewer.ShowDialog();
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
