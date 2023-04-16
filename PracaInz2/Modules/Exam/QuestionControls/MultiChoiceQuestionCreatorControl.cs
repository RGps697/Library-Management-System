using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UserInterfaceLibrary
{
    [System.ComponentModel.ToolboxItem(false)]
    public partial class MultiChoiceQuestionCreatorControl : ChoiceQuestionCreatorControl
    {

        public MultiChoiceQuestionCreatorControl(ExamProcessor.QuestionProcessor processor, MultiChoiceQuestion question) : base(processor, question)
        {

        }
    }
}
