using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace UserInterfaceLibrary
{
    internal class ExamResultCatalog : ICatalog
    {
        public List<KeyValuePair<string, KeyValuePair<string, string>>> SearchableFields { get; set; }
        internal List<SortingOrder> SortingFields { get; private set; }
        public ICatalogItem[] ItemControls { get; set; } = new ICatalogItem[0];

        public ExamResultCatalog()
        {
            SearchableFields = new List<KeyValuePair<string, KeyValuePair<string, string>>>{
                new KeyValuePair<string, KeyValuePair<string, string>>("Nazwa egzaminu", new KeyValuePair<string, string>(nameof(Exam.Name), "exams")),
                new KeyValuePair<string, KeyValuePair<string, string>>("Nazwisko użytkownika", new KeyValuePair<string, string>(nameof(User.Surname), "users")),
            };

            SortingFields = new List<SortingOrder>
            {
                new SortingOrder("Wynik", nameof(ExamResult.UserSurname), true),
                new SortingOrder("Wynik", nameof(ExamResult.UserSurname), false),
                new SortingOrder("Wynik", nameof(ExamResult.Score), true),
                new SortingOrder("Wynik", nameof(ExamResult.Score), false),
            };
        }

        public void FindItems(string collection, string column, string value)
        {
            List<ExamResult> receivedItems = ExamResultCRUD.FindExamResults(collection, column, value);
            if (!Session.CanViewAllExamResults)
            {
                for (int i = 0; i < receivedItems.Count; i++)
                {
                    if (receivedItems[i].ExamAuthorId != Session.ActiveUserId)
                    {
                        receivedItems.Remove(receivedItems[i]);
                        i--;
                    }
                }
            }
            ItemControls = CreateExamResultItems(receivedItems);
        }

        public void FindItemsById(string column, ObjectId userId)
        {
            List<ExamResult> receivedItems = ExamResultCRUD.FindExamResultsById(column, userId);
            ItemControls = CreateExamResultItems(receivedItems);
        }

        private ExamResultItem[] CreateExamResultItems(List<ExamResult> receivedItems)
        {
            ExamResultItem[] items = new ExamResultItem[receivedItems.Count];

            for (int i = 0; i < receivedItems.Count; i++)
            {
                items[i] = new ExamResultItem(receivedItems[i]);
            }

            return items;
        }

        internal void Sort(SortingOrder order)
        {
            switch (order.SortingField)
            {
                case nameof(ExamResult.Score):
                    if (order.IsAscending)
                    {
                        ItemControls = ItemControls.OrderBy(ob => ((ExamResult)((ExamResultItem)ob).ContainedItem).Score).Cast<BookItem>().ToArray();
                    }
                    else
                    {
                        ItemControls = ItemControls.OrderBy(ob => ((ExamResult)((ExamResultItem)ob).ContainedItem).Score).Reverse().Cast<BookItem>().ToArray();
                    }
                    break;
                case nameof(ExamResult.UserFirstName):
                    if (order.IsAscending)
                    {
                        ItemControls = ItemControls.OrderBy(ob => ((ExamResult)((ExamResultItem)ob).ContainedItem).UserFirstName).Cast<BookItem>().ToArray();
                    }
                    else
                    {
                        ItemControls = ItemControls.OrderBy(ob => ((ExamResult)((ExamResultItem)ob).ContainedItem).UserFirstName).Reverse().Cast<BookItem>().ToArray();
                    }
                    break;
            }
        }
    }
}
