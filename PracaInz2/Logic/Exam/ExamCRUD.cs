using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public static class ExamCRUD
    {

        static ExamCRUD()
        {
        }

        internal static string InsertExam(Exam exam)
        {
            if (!CheckExamNameExistence(exam))
            {
                DatabaseGateway.InsertDocument("exams", exam);
                return null;
            }
            else
            {
                return "Istnieje egzamin o takiej nazwie";
            }
        }

        internal static string UpdateExam(Exam exam)
        {
            if (!CheckExamNameExistence(exam)){
                DatabaseGateway.UpdateDocument("exams", exam.Id, exam);
                return null;
            }
            else
            {
                return "Istnieje egzamin o takiej nazwie";
            }
        }

        private static bool CheckExamNameExistence(Exam exam)
        {
            Exam foundExam = FindExam(nameof(Exam.Name), exam.Name);
            if (foundExam != null)
            {
                if (foundExam.Id != exam.Id)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool DeleteExam(Exam exam)
        {
            if (Session.ActiveUser.Id == exam.Author)
            {
                DatabaseGateway.DeleteDocument<Exam>("exams", exam.Id);
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public static Exam FindExam(string column, string value)
        {
            Exam result = DatabaseGateway.FindDocument<Exam>("exams", column, value);
            return result;
        }

        public static List<Exam> FindExams(string collection, string column, string value)
        {
            List<Exam> result = DatabaseGateway.FindDocuments<Exam>(collection, column, value);
            for (int i = 0; i < result.Count; i++)
            {
                User user = UserCRUD.FindUserById("_id", result[i].Author);
                result[i].AuthorFirstName = user.FirstName;
                result[i].AuthorSurname = user.Surname;
            }
            return result;
        }
    }
}
