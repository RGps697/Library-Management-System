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
    public partial class AnswerCreatorControl : UserControl, ISelectableItem
    {
        internal QuestionAnswer Answer { get; set; }
        public Action<ISelectableItem> OnItemClick { get; set; }
        public bool IsSelected { get; set; }

        private AnswerCreatorControl()
        {
            InitializeComponent();
            EventWrapper(this);
            EventWrapper(statusIcon);
            EventWrapper(answerText);
        }

        public AnswerCreatorControl(QuestionAnswer answer) : this()
        {
            this.Answer = answer;
            answerText.Text = answer.AnswerText;
            if (answer.IsCorrectAnswer)
            {
                statusIcon.Image = Icons.correct;
            }
        }

        private void EventWrapper(Control ctrl)
        {
            ctrl.Click += new EventHandler(ItemClicked);
            ctrl.MouseEnter += new EventHandler(OnHover);
            ctrl.MouseLeave += new EventHandler(OnLeave);
        }

        public void ItemClicked(object sender, EventArgs e)
        {
            OnItemClick(this);
        }

        public void OnHover(object sender, EventArgs e)
        {
            if (!IsSelected)
                BackColor = UIColors.AnswerCreatorControlHoverColor;
        }

        public void OnLeave(object sender, EventArgs e)
        {
            if (!IsSelected)
                BackColor = UIColors.AnswerCreatorControlColor;
        }

        public void ItemDoubleClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public void Selected()
        {
            BackColor = UIColors.AnswerCreatorControlSelectedColor;
        }

        public void Deselected()
        {
            BackColor = UIColors.AnswerCreatorControlColor;
        }
    }
}
