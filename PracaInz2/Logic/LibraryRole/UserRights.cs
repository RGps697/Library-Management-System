using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class UserRights
    {
        //Patron
        [BsonIgnoreIfDefault]
        public bool CanBorrowEbooksByself { get; set; } = false;
        [BsonIgnoreIfDefault]
        public bool CanSearchCatalog { get; set; } = false;
        [BsonIgnoreIfDefault]
        public bool CanAttemptExams { get; set; } = false;
        //Librarian
        [BsonIgnoreIfDefault]
        public bool CanAddBook { get; set; } = false;
        [BsonIgnoreIfDefault]
        public bool CanEditBook { get; set; } = false;
        [BsonIgnoreIfDefault]
        public bool CanRemoveBook { get; set; } = false;
        [BsonIgnoreIfDefault]
        public bool CanAddPatron { get; set; } = false;
        [BsonIgnoreIfDefault]
        public bool CanEditPatron { get; set; } = false;
        [BsonIgnoreIfDefault]
        public bool CanRemovePatron { get; set; } = false;
        //Examiner
        [BsonIgnoreIfDefault]
        public bool CanCreateExam { get; set; } = false;
        [BsonIgnoreIfDefault]
        public bool CanViewAllExamResults { get; set; } = false;
        //Administrator
        [BsonIgnoreIfDefault]
        public bool CanAddAdministrator { get; set; } = false;

        public UserRights()
        {
        }

        public UserRights(UserRights rights)
        {
            CanBorrowEbooksByself = rights.CanBorrowEbooksByself;
            CanAttemptExams = rights.CanAttemptExams;
            CanAddBook = rights.CanAddBook;
            CanEditBook = rights.CanEditBook;
            CanRemoveBook = rights.CanRemoveBook;
            CanAddPatron = rights.CanAddPatron;
            CanEditPatron = rights.CanEditPatron;
            CanRemovePatron = rights.CanRemovePatron;
            CanCreateExam = rights.CanCreateExam;
            CanViewAllExamResults = rights.CanViewAllExamResults;
        }
    }
}
