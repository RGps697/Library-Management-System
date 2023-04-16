using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public static class BookCRUD
    {
        static BookCRUD()
        {

        }

        public static string InsertBook(Book book, string ebookFilePath, Image coverImage)
        {
            if (!Session.CanAddBooks) 
                throw new UnauthorizedAccessException("Missing privilege to add books");

            if (!CheckInventoryNumber(book))
                return $"Istnieje książka o podanym numerze inwentarzowym";
            

            if (book.IsEbook && (!string.IsNullOrEmpty(ebookFilePath)) && (book.EbookId == ObjectId.Empty))
            {
                InsertEbookFile(book, ebookFilePath);
            }
            
            if (coverImage != null && book.CoverId == ObjectId.Empty)
            {
                InsertBookCover(book, coverImage);
            }

            DatabaseGateway.InsertDocument("books", book);
            return null;
        }

        public static string UpdateBook(Book book, string filePath, bool ebookFileRemoved, Image coverImage, bool coverRemoved)
        {
            if (!CheckInventoryNumber(book))
            {
                return $"Istnieje książka o podanym numerze inwentarzowym";
            }

            if (book.IsEbook && (!string.IsNullOrEmpty(filePath)) && (book.EbookId == ObjectId.Empty))
            {
                InsertEbookFile(book, filePath);
            }
            else if (book.IsEbook && (!string.IsNullOrEmpty(filePath)) && (ebookFileRemoved))
            {
                RemoveEbookFile(book.EbookId);
                InsertEbookFile(book, filePath);
            }
            else if (!book.IsEbook && (string.IsNullOrEmpty(filePath)) && (ebookFileRemoved))
            {
                RemoveEbookFile(book.EbookId);
                book.EbookId = ObjectId.Empty;
            }

            if (coverImage != null && book.CoverId == ObjectId.Empty)
            {
                InsertBookCover(book, coverImage);
            }
            else if (coverImage != null && book.CoverId != ObjectId.Empty && coverRemoved)
            {
                RemoveBookCover(book.CoverId);
                InsertBookCover(book, coverImage);
            }
            else if (book.CoverId != ObjectId.Empty && coverRemoved)
            {
                RemoveBookCover(book.CoverId);
                book.CoverId = ObjectId.Empty;
            }

            var res = DatabaseGateway.UpdateDocument("books", book.Id, book);
            if (res.MatchedCount == 1)
            {
                return null;
            }
            else
            {
                return "Błąd przy aktualizacji książki";
            }
        }

        public static bool UpdateBook<T>(ObjectId id, string field, T value)
        {
            return DatabaseGateway.UpdateDocumentField<T>("books", id, field, value);
        }

        public static List<Book> FindBooks(string collection, string column, string value)
        {
            List<Book> result = DatabaseGateway.FindDocuments<Book>(collection, column, value);
            for(int i = 0; i < result.Count; i++)
            {
                if (result[i].CoverId != ObjectId.Empty) LoadBookCover(result[i]);
            }
            return result;
        }

        public static List<Book> FindBooks(string collection, string column, string value, ObjectId withoutId)
        {
            List<Book> result = DatabaseGateway.FindDocumentsWithoutId<Book>(collection, column, value, withoutId);
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i].CoverId != ObjectId.Empty) LoadBookCover(result[i]);
            }
            return result;
        }

        public static Book FindBookById(string column, ObjectId value)
        {
            Book result = DatabaseGateway.FindDocumentById<Book>("books", column, value);
            if (result.CoverId != ObjectId.Empty) LoadBookCover(result);
            return result;
        }

        public static List<Book> FindBooksById(string column, ObjectId value)
        {
            var result = DatabaseGateway.FindDocumentsById<Book>("books", column, value);
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i].CoverId != ObjectId.Empty) LoadBookCover(result[i]);
            }
            result.OrderByDescending(x => x.Id);
            return result;
        }

        public static List<Book> FindBooksByIds(string column, List<ObjectId> value)
        {
            var result = DatabaseGateway.FindDocumentsByIds<Book>("books", column, value);
            for (int i = 0; i < result.Count; i++)
            {
                if (result[i].CoverId != ObjectId.Empty) LoadBookCover(result[i]);
            }
            result.OrderByDescending(x => x.Id);
            return result;
        }

        public static List<Book> FindBooksUsingRange(string collection, string column, string value)
        {
            string[] values;
            values = value.Split("-");
            int val1 = 0;
            bool parse1 = int.TryParse(values[0], out val1);
            int val2 = 0;
            bool parse2 = int.TryParse(values[1], out val2);
            if (parse1 && parse2)
            {
                var result = DatabaseGateway.FindDocumentsUsingRange<Book>("books", column, val1, val2);
                return result;
            }
            else
            {
                return null;
            }
        }

        private static void LoadBookCover(Book book)
        {
            Stream stream = BookCRUD.GetBookCover(book.CoverId);
            if(stream.Length > 0)
                book.CoverImage = Image.FromStream(stream);
        }

        public static string DeleteBook(Book book)
        {
            if (Session.CanRemoveBooks)
            {
                Book DbBookData = FindBookById("_id", book.Id);
                if (!DbBookData.IsBorrowed)
                {
                    DatabaseGateway.DeleteDocument<Book>("books", book.Id);
                    if (book.IsEbook)
                    {
                        RemoveEbookFile(book.EbookId);
                    }
                    return null;
                }
                else
                {
                    return "Książka jest wypożyczona";
                }
            }
            return "Brak uprawnień";
        }

        //GridFS

        private static void InsertEbookFile(Book book, string filePath)
        {
            FileStream stream = new FileStream(filePath, FileMode.Open);
            book.EbookId = DatabaseGateway.InsertBucketFile(book.Title, stream, DatabaseGateway.TargetBucket.EbookBucket);
            stream.Close();
        }

        public static Stream GetEbookFile(ObjectId id)
        {
            return DatabaseGateway.FindBucketFile(id, DatabaseGateway.TargetBucket.EbookBucket);
        }

        public static void RemoveEbookFile(ObjectId ebookId)
        {
            DatabaseGateway.RemoveBucketFile(ebookId, DatabaseGateway.TargetBucket.EbookBucket);
        }

        private static void InsertBookCover(Book book, System.Drawing.Image coverImage)
        {
            MemoryStream stream = new MemoryStream();
            coverImage.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
            stream.Position = 0;
            book.CoverId = DatabaseGateway.InsertBucketFile(book.Title, stream, DatabaseGateway.TargetBucket.ImageBucket);
            stream.Close();
        }

        public static Stream GetBookCover(ObjectId id)
        {
            return DatabaseGateway.FindBucketFile(id, DatabaseGateway.TargetBucket.ImageBucket);
        }

        public static void RemoveBookCover(ObjectId id)
        {
            DatabaseGateway.RemoveBucketFile(id, DatabaseGateway.TargetBucket.ImageBucket);
        }

        //

        private static bool CheckInventoryNumber(Book book)
        {
            Book foundBook = FindBooks("books", nameof(Book.InventoryNumber), book.InventoryNumber).FirstOrDefault();
            if (foundBook != null && !foundBook.Id.Equals(book.Id))
            {
                return false;
            }
            else
            {
                return true;
            }
        }


    }
}
