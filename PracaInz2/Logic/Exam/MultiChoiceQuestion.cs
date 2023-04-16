using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class MultiChoiceQuestion : IQuestion
    {
        public ushort Id { get; set; }
        public string Description { get; set; }
        public List<QuestionAnswer> Answers { get; set; } = new List<QuestionAnswer>();
        byte correctAnswerAmount;
        public byte CorrectAnswerAmount
        {
            get
            {
                return correctAnswerAmount;
            }
            set
            {
                if(value <= byte.MaxValue && value >= byte.MinValue)
                {
                    correctAnswerAmount = value;
                }
            }
        }
        public byte Points { get; set; } = 1;

        public MultiChoiceQuestion()
        {
        }

        public MultiChoiceQuestion(IQuestion question)
        {
            Id = question.Id;
            Description = question.Description;
            for (int i = 0; i < question.Answers.Count; i++)
            {
                Debug.WriteLine($"multichoice {i}");
                Answers.Add(new QuestionAnswer(question.Answers[i]));
            }
            CorrectAnswerAmount = question.CorrectAnswerAmount;
            Points = question.Points;
        }

        public bool MarkCorrectAnswer(QuestionAnswer answer)
        {
            if (answer.IsCorrectAnswer)
            {
                answer.IsCorrectAnswer = false;
                CorrectAnswerAmount--;
                return true;
            }
            else
            {
                answer.IsCorrectAnswer = true;
                CorrectAnswerAmount++;
                return true;
            }
        }
    }
}
