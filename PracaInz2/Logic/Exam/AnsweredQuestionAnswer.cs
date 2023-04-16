using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class AnsweredQuestionAnswer : QuestionAnswer
    {
        public bool IsSelected { get; set; }

        public AnsweredQuestionAnswer(QuestionAnswer answer) : base()
        {
            AnswerText = answer.AnswerText;
            IsCorrectAnswer = answer.IsCorrectAnswer;
        }

    }
}
