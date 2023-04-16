using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicLibrary
{
    public class ExamProcessor
    {
        public Exam Exam { get; private set; }
        public QuestionProcessor questionProcessor { get; private set; } = new QuestionProcessor();
        private bool update = false;

        public string GetName
        {
            get
            {
                return Exam.Name;
            }
        }

        public string SetName
        {
            set
            {
                Exam.Name = value;
            }
        }

        public string GetDescription
        {
            get
            {
                return Exam.Description;
            }

        }

        public string SetDescription
        {
            set
            {
                Exam.Description = value;
            }
        }

        public ExamProcessor()
        {
            Exam = new Exam();
            Exam.Author = Session.ActiveUser.Id;
        }

        public ExamProcessor(Exam exam)
        {
            Exam = new Exam(exam);
            update = true;
        }


        public bool AddQuestion(IQuestion question)
        {
            if (Exam.Questions.Count <= 1000)
            {
                question.Id = (ushort)Exam.Questions.Count;
                Exam.Questions.Add(question);
                return true;
            }
            else
            {
                return false;
            }
        }

        public void DeleteQuestion(int index)
        {
            Exam.Questions.RemoveAt(index);
            for(int i = index; i < Exam.Questions.Count; i++)
            {
                Exam.Questions[i].Id--;
            }
        }

        public string GetQuestionName(IQuestion question)
        {
            string questionListName = $"{question.Id + 1}. ";

            if (question is SingleChoiceQuestion)
            {
                questionListName += "Jednokrotny wybór";
            }
            else if (question is MultiChoiceQuestion)
            {
                questionListName += "Wielokrotny wybór";
            }
            else
            {
                throw new MissingMemberException("No suitable question type");
            }

            return questionListName;
        }

        public string[] GetAllQuestionNames()
        {
            string[] allQuestions = new string[Exam.Questions.Count];
            for (int i = 0; i < Exam.Questions.Count; i++)
            {
                allQuestions[i] = GetQuestionName(Exam.Questions[i]);
            }

            return allQuestions;
        }


        public IQuestion GetQuestion(int index)
        {
            IQuestion question = Exam.Questions.ElementAt(index);
            return question;
        }

        public ushort SetQuestionAmountPerSession(decimal value)
        {
            if (value < ushort.MaxValue && value > ushort.MinValue)
            {
                ushort value2 = (ushort)Math.Floor(value);
                int difference = Exam.Questions.Count - value2;
                if (difference >= 0)
                {
                    Exam.QuestionAmountPerSession = value2;
                    return 0;
                }
            }
            return (ushort)Exam.Questions.Count;
        }

        public string ValidateExam()
        {
            string errors = null;
            for (int i = 0; i < Exam.Questions.Count; i++) {
                if (Exam.Questions[i].Answers.Count < 2)
                {
                    errors += $"Pytanie o numerze {Exam.Questions[i].Id+1} ma mniej niż 2 odpowiedzi.\n";
                }
                else if (Exam.Questions[i].CorrectAnswerAmount < 1)
                {
                    errors += $"Pytanie o numerze {Exam.Questions[i].Id+1} nie ma zaznaczonej prawidłowej odpowiedzi\n";
                }
            }
            if (Exam.QuestionAmountPerSession > Exam.Questions.Count) errors += $"Ilość pytań losowanych do podejścia nie może większa od ilości pytań w puli.\n";
            if (Exam.QuestionAmountPerSession == 0) errors += $"Ilość pytań losowanych do podejścia nie może być równa 0.\n";
            if (Exam.QuestionAmountPerSession < 0) errors += $"Ilość pytań losowanych do podejścia nie może być ujemna.\n";

            return errors;
        }

        public bool AddBookLink(ObjectId id)
        {
            if (!Exam.LinkedBooks.Contains(id))
            {
                Exam.LinkedBooks.Add(id);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteBookLink(ObjectId id)
        {
            if (Exam.LinkedBooks.Contains(id))
            {
                Exam.LinkedBooks.Remove(id);
                return true;
            }
            else
            {
                return false;
            }
        }

        public string SaveExam()
        {
            string result;
            if (update)
            {
                 result = ExamCRUD.UpdateExam(Exam);
            }
            else
            {
                result = ExamCRUD.InsertExam(Exam);
            }

            return result;
        }


        public class QuestionProcessor
        {
            public QuestionAnswer? AddAnswer(IQuestion question, string answer)
            {
                if (question.Answers.Count < 20)
                {
                    for (int i = 0; i < question.Answers.Count; i++)
                    {
                        if (question.Answers[i].AnswerText.Equals(answer))
                        {
                            return null;
                        }
                    }
                    QuestionAnswer newAnswer = new QuestionAnswer(answer);
                    question.Answers.Add(newAnswer);
                    return newAnswer;
                }
                return null;
            }

            public bool MarkCorrectAnswer(IQuestion question, QuestionAnswer answer)
            {
                bool result = question.MarkCorrectAnswer(answer);
                return result;
            }

            public void DeleteAnswer(IQuestion question, QuestionAnswer answer)
            {
                if (answer.IsCorrectAnswer)
                {
                    question.CorrectAnswerAmount--;
                }
                question.Answers.Remove(answer);
            }

            public void SetDescription(IQuestion question, string text)
            {
                question.Description = text;
            }

            public void SetPoints(IQuestion question, byte points)
            {
                if (points > 0)
                {
                    question.Points = points;
                }
            }
        }

    }
}
