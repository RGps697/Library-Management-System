using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class QuestionAnswer
    {
        public string AnswerText { get; set; }
        public bool IsCorrectAnswer { get; set; }

        protected QuestionAnswer()
        {

        }

        public QuestionAnswer(string value)
        {
            AnswerText = value;
        }
        public QuestionAnswer(QuestionAnswer answer)
        {
            AnswerText = answer.AnswerText;
            IsCorrectAnswer = answer.IsCorrectAnswer;
        }
    }

}
