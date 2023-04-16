using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterfaceLibrary
{
    internal class BookCatalog : ICatalog
    {
        public List<KeyValuePair<string, KeyValuePair<string, string>>> SearchableFields { get; set; }
        internal List<SortingOrder> SortingFields { get; private set; }
        public ICatalogItem[] ItemControls { get; set; } = new ICatalogItem[0];
        List<Book> ReceivedBooks { get; set; }

        internal BookCatalog()
        {
            SearchableFields = new List<KeyValuePair<string, KeyValuePair<string, string>>>
            {
                new KeyValuePair<string, KeyValuePair<string, string>>("Tytuł", new KeyValuePair<string, string>(nameof(Book.Title), "books")),
                new KeyValuePair<string, KeyValuePair<string, string>>("Autor", new KeyValuePair<string, string>(nameof(Book.Authors), "books")),
                new KeyValuePair<string, KeyValuePair<string, string>>("Kategoria", new KeyValuePair<string, string>(nameof(Book.Categories), "books")),
                new KeyValuePair<string, KeyValuePair<string, string>>("Wydawnictwo", new KeyValuePair<string, string>(nameof(Book.Publisher), "books")),
                new KeyValuePair<string, KeyValuePair<string, string>>("Język", new KeyValuePair<string, string>(nameof(Book.Language), "books")),
                new KeyValuePair<string, KeyValuePair<string, string>>("Numer inwentarza", new KeyValuePair<string, string>(nameof(Book.InventoryNumber), "books")),
                new KeyValuePair<string, KeyValuePair<string, string>>("Rok publikacji", new KeyValuePair<string, string>(nameof(Book.PublicationYear), "books"))
            };



            SortingFields = new List<SortingOrder>            
            {
                new SortingOrder("Tytuł", nameof(Book.Title), true),
                new SortingOrder("Tytuł", nameof(Book.Title), false),
                new SortingOrder("Autor", nameof(Book.Authors), true),
                new SortingOrder("Autor", nameof(Book.Authors), false),
                new SortingOrder("Wydawnictwo", nameof(Book.Publisher), true),
                new SortingOrder("Wydawnictwo", nameof(Book.Publisher), false),
                new SortingOrder("Rok publikacji", nameof(Book.PublicationYear), true),
                new SortingOrder("Rok publikacji", nameof(Book.PublicationYear), false)
            };
        }

        public void FindItems(string collection, string column, string value)
        {
            if (column == nameof(Book.PublicationYear))
            {
                ReceivedBooks = BookCRUD.FindBooksUsingRange(collection, column, value);
            }
            else
            {
                ReceivedBooks = BookCRUD.FindBooks(collection, column, value);
            }
            ItemControls = CreateBookItems(ReceivedBooks);
        }

        public void FindItems(string collection, string column, string value, ObjectId withoutId)
        {
            if (column == nameof(Book.PublicationYear))
            {
                ReceivedBooks = BookCRUD.FindBooksUsingRange(collection, column, value);
            }
            else
            {
                ReceivedBooks = BookCRUD.FindBooks(collection, column, value, withoutId);
            }
            ItemControls = CreateBookItems(ReceivedBooks);
        }

        internal void FindItemsById(string column, ObjectId value)
        {
            List<Book> receivedBooks = BookCRUD.FindBooksById(column, value);
            System.Diagnostics.Debug.WriteLine($"Book catalog Called");
            ItemControls = CreateBookItems(receivedBooks);
        }

        internal void FindItemsByIds(string column, List<ObjectId> value)
        {
            List<Book> receivedBooks = BookCRUD.FindBooksByIds(column, value);
            System.Diagnostics.Debug.WriteLine($"Book catalog Called");
            ItemControls = CreateBookItems(receivedBooks);
        }

        protected virtual BookItem[] CreateBookItems(List<Book> books)
        {
            BookItem[] items = new BookItem[books.Count];
            for (int i = 0; i < books.Count; i++)
            {
                items[i] = new BookItem(books.ElementAt(i));
            }
            return items;
        }

        internal void Sort(SortingOrder order)
        {
            switch (order.SortingField)
            {
                case nameof(Book.Title):
                    if (order.IsAscending)
                    {
                        ItemControls = ItemControls.OrderBy(ob => ((Book)((BookItem)ob).ContainedItem).Title).Cast<BookItem>().ToArray();
                    }
                    else
                    {
                        ItemControls = ItemControls.OrderBy(ob => ((Book)((BookItem)ob).ContainedItem).Title).Reverse().Cast<BookItem>().ToArray();
                    }
                    break;
                case nameof(Book.Authors):
                    if (order.IsAscending)
                    {
                        ItemControls = ItemControls.OrderBy(ob => ((Book)((BookItem)ob).ContainedItem).Authors[0]).Cast<BookItem>().ToArray();
                    }
                    else
                    {
                        ItemControls = ItemControls.OrderBy(ob => ((Book)((BookItem)ob).ContainedItem).Authors[0]).Reverse().Cast<BookItem>().ToArray();
                    }
                    break;
                case nameof(Book.Publisher):
                    if (order.IsAscending)
                    {
                        ItemControls = ItemControls.OrderBy(ob => ((Book)((BookItem)ob).ContainedItem).Publisher).Cast<BookItem>().ToArray();
                    }
                    else
                    {
                        ItemControls = ItemControls.OrderBy(ob => ((Book)((BookItem)ob).ContainedItem).Publisher).Reverse().Cast<BookItem>().ToArray();
                    }
                    break;
                case nameof(Book.PublicationYear):
                    if (order.IsAscending)
                    {
                        ItemControls = ItemControls.OrderBy(ob => ((Book)((BookItem)ob).ContainedItem).PublicationYear).Cast<BookItem>().ToArray();
                    }
                    else
                    {
                        ItemControls = ItemControls.OrderBy(ob => ((Book)((BookItem)ob).ContainedItem).PublicationYear).Reverse().Cast<BookItem>().ToArray();
                    }
                    break;
            }
        }
    }
}
