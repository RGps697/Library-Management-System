using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    internal interface IQuestionCreator : IQuestion
    {
        bool MarkCorrectAnswer(QuestionAnswer answer);
    }
}
