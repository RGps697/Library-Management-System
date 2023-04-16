using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceLibrary
{
    internal interface IAnswersControl
    {
        internal List<AnsweredQuestionAnswer> GetAnswersChoice();
    }
}
