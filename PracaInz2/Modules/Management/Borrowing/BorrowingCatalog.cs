using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceLibrary
{
    internal class BorrowingCatalog : ICatalog
    {
        public ICatalogItem[] ItemControls { get; set; }
        public List<KeyValuePair<string, KeyValuePair<string, string>>> SearchableFields { get; set; }

        public BorrowingCatalog()
        {
            SearchableFields = new List<KeyValuePair<string, KeyValuePair<string, string>>>{
                new KeyValuePair<string, KeyValuePair<string, string>>("Tytuł", new KeyValuePair<string, string>(nameof(Book.Title), "books")),
                new KeyValuePair<string, KeyValuePair<string, string>>("Autor", new KeyValuePair<string, string>(nameof(Book.Authors), "books")),
                new KeyValuePair<string, KeyValuePair<string, string>>("Imię użytkownika", new KeyValuePair<string, string>(nameof(User.FirstName), "users")),
                new KeyValuePair<string, KeyValuePair<string, string>>("Nazwisko użytkownika", new KeyValuePair<string, string>(nameof(User.Surname), "users"))
            };
        }

        public void FindItemsById(string column, ObjectId id)
        {
            List<Borrowing> borrowedBooks = BorrowingCRUD.FindBorrowingsById(column, id);
            ItemControls = CreateBorrowingItems(borrowedBooks);
        }

        public void FindItems(string collection, string column, string value)
        {
            List<Borrowing> receivedItems = BorrowingCRUD.FindBorrowings(collection, column, value);
            ItemControls = CreateBorrowingItems(receivedItems);
        }

        private BorrowingItem[] CreateBorrowingItems(List<Borrowing> borrowedBooks)
        {
            BorrowingItem[] items = new BorrowingItem[borrowedBooks.Count];
            for (int i = 0; i < borrowedBooks.Count; i++)
            {
                items[i] = new BorrowingItem(borrowedBooks[i]);
            }

            return items;
        }

        internal void DeleteFromList(ICatalogItem item)
        {
            ItemControls = ItemControls.Where(x => !x.Equals(item)).ToArray();
        }
    }
}
