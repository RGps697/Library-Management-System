using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class SingleChoiceQuestion : IQuestion
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
                if(value > 1)
                {
                    correctAnswerAmount = 1;
                }
                else if (value < 0)
                {
                    correctAnswerAmount = 0;
                }
                else
                {
                    correctAnswerAmount = value;
                }
            }
        }
        public byte Points { get; set; } = 1;

        public SingleChoiceQuestion()
        {
        }

        public SingleChoiceQuestion(IQuestion question)
        {
            Id = question.Id;
            Description = question.Description;
            for (int i = 0; i < question.Answers.Count; i++)
            {
                Debug.WriteLine($"question: {i}");
                Answers.Add(new QuestionAnswer(question.Answers[i]));
            }
            CorrectAnswerAmount = question.CorrectAnswerAmount;
            Points = question.Points;
        }

        public bool MarkCorrectAnswer(QuestionAnswer answer)
        {
            Console.WriteLine("Current correct answer amount: " + correctAnswerAmount);
            if (answer.IsCorrectAnswer)
            {
                answer.IsCorrectAnswer = false;
                CorrectAnswerAmount--;
                return true;
            }
            else
            {
                if (CorrectAnswerAmount < 1)
                {
                    answer.IsCorrectAnswer = true;
                    CorrectAnswerAmount++;
                    return true;
                }
            }
            return false;
        }
    }
}
