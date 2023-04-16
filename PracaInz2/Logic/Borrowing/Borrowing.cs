using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class Borrowing : ILibraryItem
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonIgnoreIfDefault]
        public bool IsDeleted { get; set; }
        public ObjectId BookId { get; set; }
        public ObjectId UserId { get; set; }
        [BsonIgnore]
        public string? Title { get; set; }
        [BsonIgnore]
        public string[]? Authors { get; set; }
        [BsonIgnore]
        public string? FirstName { get; set; }
        [BsonIgnore]
        public string? Surname { get; set; }
        //[BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime BorrowDate { get; set; }
        //[BsonDateTimeOptions(Kind = DateTimeKind.Local)]
        public DateTime ReturnDate { get; set; }

        internal Borrowing(Book book, User user)
        {
            BookId = book.Id;
            UserId = user.Id;
            BorrowDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            Debug.WriteLine($"y {DateTime.Now.Year}  m {DateTime.Now.Month}  d {DateTime.Now.Day}");
            ReturnDate = BorrowDate.AddDays(31);
            Debug.WriteLine($"borrow {BorrowDate}, return {ReturnDate}");
        }

        internal Borrowing(BsonDocument bsonBorrowing)
        {
            Id = bsonBorrowing["_id"].AsObjectId;
            BookId = bsonBorrowing["BookId"].AsObjectId;
            UserId = bsonBorrowing["UserId"].AsObjectId;
            BsonArray bookData = bsonBorrowing["BookData"].AsBsonArray;
            Title = bookData[0]["Title"].AsString;
            Authors = bookData[0]["Authors"].AsBsonArray.Select(p => p.AsString).ToArray();
            BsonArray userData = bsonBorrowing["UserData"].AsBsonArray;
            if (userData.Count > 0)
            {
                FirstName = userData[0]["FirstName"].AsString;
                Surname = userData[0]["Surname"].AsString;
            }
            BorrowDate = bsonBorrowing["BorrowDate"].ToLocalTime();
            ReturnDate = bsonBorrowing["ReturnDate"].ToLocalTime();
        }
    }
}
