using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LogicLibrary
{
    public interface IQuestion
    {
        ushort Id { get; internal set; }
        string Description { get; internal set; }
        List<QuestionAnswer> Answers { get; internal set; }
        byte CorrectAnswerAmount { get; internal set; }
        byte Points { get; internal set; }
        internal bool MarkCorrectAnswer(QuestionAnswer answer);
    }
}
