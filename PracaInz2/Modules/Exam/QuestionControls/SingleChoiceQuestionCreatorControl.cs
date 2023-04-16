using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserInterfaceLibrary
{
    [ToolboxItem(false)]
    public partial class SingleChoiceQuestionCreatorControl : ChoiceQuestionCreatorControl
    {
        public SingleChoiceQuestionCreatorControl(ExamProcessor.QuestionProcessor processor, SingleChoiceQuestion question) : base(processor, question)
        {

        }
    }
}
