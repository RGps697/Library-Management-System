using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceLibrary
{
    internal class ExamCatalog : ICatalog
    {
        public List<KeyValuePair<string, KeyValuePair<string, string>>> SearchableFields { get; set; }
        public ICatalogItem[] ItemControls { get; set; }

        internal ExamCatalog()
        {
            SearchableFields = new List<KeyValuePair<string, KeyValuePair<string, string>>>{
                new KeyValuePair<string, KeyValuePair<string, string>>("Nazwa", new KeyValuePair<string, string>(nameof(Exam.Name), "exams")),
                new KeyValuePair<string, KeyValuePair<string, string>>("Nazwisko autor", new KeyValuePair<string, string>(nameof(Exam.AuthorSurname), "exams")),
            };
        }

        public void FindItems(string column, string value)
        {
            List<Exam> receivedExams = ExamCRUD.FindExams("exams", column, value);
            ItemControls = CreateExamItems(receivedExams);
        }

        public void FindItems(string collection, string column, string value)
        {
            List<Exam> receivedExams = ExamCRUD.FindExams(collection, column, value);
            for (int i = 0; i < receivedExams.Count; i++)
            {
                if (receivedExams[i].Author != Session.ActiveUserId)
                {
                    receivedExams.Remove(receivedExams[i]);
                    i--;
                }
            }
            ItemControls = CreateExamItems(receivedExams);
        }

        protected virtual ExamItem[] CreateExamItems(List<Exam> exams)
        {
            ExamItem[] items = new ExamItem[exams.Count];
            for (int i = 0; i < exams.Count; i++)
            {
                items[i] = new ExamItem(exams.ElementAt(i));
            }
            return items;
        }

        internal void DeleteFromList(ICatalogItem item)
        {
            ItemControls = ItemControls.Where(x => !x.Equals(item)).ToArray();
        }
    }
}
