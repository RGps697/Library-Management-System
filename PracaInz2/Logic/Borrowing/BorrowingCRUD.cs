using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public static class BorrowingCRUD
    {

        static BorrowingCRUD()
        {

        }

        public static string BorrowBookToUser(Book book, User user)
        {
            if (Session.CanIssueBooks)
            {
                return BorrowBook(book, user);
            }
            else
            {
                return "Brak uprawnień.";
            }
        }

        public static string BorrowBookToSelf(Book book)
        {
            if (Session.CanBorrowEbooksByself && book.IsEbook)
            {
                return BorrowBook(book, Session.ActiveUser);
            }
            else
            {
                return "Brak uprawnień.";
            }
        }

        private static string BorrowBook(Book book, User user)
        {
            Book databaseBook = BookCRUD.FindBookById("_id", book.Id);
            if (!databaseBook.IsBorrowed)
            {
                book.IsBorrowed = true;
                BookCRUD.UpdateBook(book.Id, "IsBorrowed", true);
                BookCRUD.UpdateBook(book.Id, "BorrowedBy", user.Id);
                Borrowing borrowing = new Borrowing(book, user);
                InserBorrowing(borrowing);
                return null;
            }
            else
            {
                return "Książka jest już wypożyczona.";
            }
        }

        private static void InserBorrowing(Borrowing borrowing)
        {
            DatabaseGateway.InsertDocument<Borrowing>("borrowings", borrowing);
        }

        public static string ReturnBook(Borrowing borrowing)
        {
            if (Session.CanReturnBooks)
            {
                var result = BookCRUD.UpdateBook(borrowing.BookId, "IsBorrowed", false);
                if (result)
                {
                    DatabaseGateway.DeleteDocumentField<Book>("books", borrowing.BookId, "LastPage");
                    BookCRUD.UpdateBook(borrowing.BookId, "BorrowedBy", ObjectId.Empty);
                    RemoveBorrowing(borrowing.Id);
                    return null;
                }
                return "Błąd przy zwracaniu książki.";
            }
            return "Brak uprawnień.";
        }

        private static void RemoveBorrowing(ObjectId id)
        {
            DatabaseGateway.DeleteDocument<Borrowing>("borrowings", id);
        }

        public static void UpdateBorrowing(Borrowing borrowing)
        {
            DatabaseGateway.UpdateDocument("borrowings", borrowing.Id, borrowing);
        }

        public static void ExtendDuePeriod(Borrowing borrowing)
        {
            borrowing.ReturnDate = borrowing.ReturnDate.AddDays(30);
            Debug.WriteLine($"BorrowingCRUD return date {borrowing.ReturnDate}");
            UpdateBorrowing(borrowing);
        }

        public static List<Borrowing> FindBorrowingsById(string column, ObjectId id)
        {
            BsonArray bsonArray = new BsonArray();
            bsonArray.Add(id);
            List<Borrowing> result = JoinToBorrowings(column, bsonArray);
            return result;
        }

        public static List<Borrowing> FindBorrowings(string collection, string column, string value)
        {
            BsonArray bsonArray = new BsonArray();
            string matchField = null;
            if (collection == "books")
            {
                List<Book> foundBooks = DatabaseGateway.FindDocuments<Book>(collection, column, value);
                for (int i = 0; i < foundBooks.Count; i++)
                {
                    bsonArray.Add(foundBooks[i].Id);
                }
                matchField = nameof(Borrowing.BookId);
            }
            else if (collection == "users")
            {
                List<User> foundUsers = DatabaseGateway.FindDocuments<User>(collection, column, value);
                for (int i = 0; i < foundUsers.Count; i++)
                {
                    bsonArray.Add(foundUsers[i].Id);
                }
                matchField = nameof(Borrowing.UserId);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Collection name out of range");
            }

            List<Borrowing> result = JoinToBorrowings(matchField, bsonArray);
            return result;
        }

        private static List<Borrowing> JoinToBorrowings(string matchField, BsonArray valuesRange)
        {
            BsonDocument findDocuments = new BsonDocument
            {
                {
                    "$match", new BsonDocument
                    {
                        {
                            matchField, new BsonDocument
                            {
                                {
                                    "$in", valuesRange
                                }
                            }
                        },
                        {
                            "IsDeleted", new BsonDocument
                            {
                                {
                                    "$not", new BsonDocument
                                    {
                                        {
                                            "$exists", "false"
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };

            BsonDocument joinUsers = new BsonDocument
            {
                {
                    "$lookup", new BsonDocument
                    {
                        { "from", "users" },
                        { "localField", "UserId" },
                        { "foreignField", "_id" },
                        { "as", "UserData" }
                    }
                }
            };

            BsonDocument joinBooks = new BsonDocument
            {
                {
                    "$lookup", new BsonDocument
                    {
                        { "from", "books" },
                        { "localField", "BookId" },
                        { "foreignField", "_id" },
                        { "as", "BookData" }
                    }
                }
            };

            BsonDocument projectFields = new BsonDocument
            {
                {
                    "$project", new BsonDocument
                    {
                        { "_id", 1 },
                        { "BookId", 1 },
                        { "UserId", 1 },
                        {
                            "UserData", new BsonDocument
                            {
                                    { "FirstName", 1 },
                                    { "Surname", 1 }
                            }
                        },
                        {
                            "BookData", new BsonDocument
                            {
                                    { "Title", 1 },
                                    { "Authors", 1 }
                            }
                        },
                        { "BorrowDate", 1 },
                        { "ReturnDate", 1 }
                    }
                }
            };

            BsonDocument[] pipeline = new BsonDocument[] { findDocuments, joinUsers, joinBooks, projectFields };
            List<BsonDocument> results = DatabaseGateway.JoinCollections("borrowings", pipeline);

            List<Borrowing> convertedResults = new List<Borrowing>();
            Borrowing borrowing;

            foreach (BsonDocument bsonBorrowing in results)
            {
                borrowing = new Borrowing(bsonBorrowing);
                convertedResults.Add(borrowing);
            }

            return convertedResults;
        }
    }
}
