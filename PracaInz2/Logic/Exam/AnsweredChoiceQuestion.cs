using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class AnsweredChoiceQuestion
    {
        public ushort Id { get; private set; }
        public string Description { get; private set; }
        public List<AnsweredQuestionAnswer> Answers { get; private set; }
        public byte CorrectAnswerAmount { get; private set; }
        public byte Points { get; private set; } = 1;

        public AnsweredChoiceQuestion(IQuestion question, List<AnsweredQuestionAnswer> answers)
        {
            Id = question.Id;
            Description = question.Description;
            Answers = answers;
            CorrectAnswerAmount = question.CorrectAnswerAmount;
            Points = question.Points;
        }
    }
}
