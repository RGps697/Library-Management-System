using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class ExamSession
    {
        private Exam Exam { get; set; }
        private Random Rand { get; set; } = new Random();

        public ExamSession(Exam exam)
        {
            Exam = exam;
        }

        public List<IQuestion> SelectRandomQuestions()
        {
            List<IQuestion> sessionQuestions = new List<IQuestion>();
            int questionNumber;
            IQuestion randomedQuestion;

            for (int i = 0; i < Exam.QuestionAmountPerSession; i++)
            {
                do
                {
                    questionNumber = Rand.Next(0, Exam.Questions.Count);
                    randomedQuestion = Exam.Questions[questionNumber];
                    Console.WriteLine($"randoming: {questionNumber}");
                }
                while (sessionQuestions.Contains(randomedQuestion));
                sessionQuestions.Add(randomedQuestion);
            }

            return sessionQuestions;
        }

        public decimal EvaluateExam(List<AnsweredChoiceQuestion> sessionQuestions)
        {
            ExamEvaluator evaluator = new ExamEvaluator(sessionQuestions);
            decimal score = evaluator.EvaluateAttempt();
            ExamResult examResult = new ExamResult(Exam, Session.ActiveUser, score);
            ExamResultCRUD.InsertExamResult(examResult);
            return score;
        }
    }
}
