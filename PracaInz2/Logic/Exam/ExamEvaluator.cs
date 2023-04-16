using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class ExamEvaluator
    {
        private List<AnsweredChoiceQuestion> SessionQuestions { get; set; }
        private double QuestionPoints { get; set; }
        private double CurrentPoints { get; set; }
        private double MaxPoints { get; set; }

        public ExamEvaluator(List<AnsweredChoiceQuestion> sessionQuestions)
        {
            SessionQuestions = sessionQuestions;
            CurrentPoints = 0;
            MaxPoints = 0;
        }

        public decimal EvaluateAttempt()
        {
            int questionCount = SessionQuestions.Count;
            for (int i = 0; i < questionCount; i++)
            {
                RateQuestion(SessionQuestions[i]);
            }
            decimal result = (decimal)((CurrentPoints/MaxPoints)*100);
            return Math.Round(result, 1);
        }

        private void RateQuestion(AnsweredChoiceQuestion question)
        {
            QuestionPoints = 0;
            MaxPoints += question.Points;
            for (int i = 0; i < question.Answers.Count; i++)
            {
                if (question.Answers[i].IsSelected)
                {
                    if (question.Answers[i].IsCorrectAnswer)
                    {
                        QuestionPoints += (double)question.Points / question.CorrectAnswerAmount;
                    }
                    else
                    {
                        QuestionPoints -= (double)question.Points / (question.Answers.Count-question.CorrectAnswerAmount);
                    }

                    QuestionPoints = QuestionPoints < 0 ? 0 : QuestionPoints;
                }
            }

            CurrentPoints += Math.Round(QuestionPoints, 2);
        }
    }
}
