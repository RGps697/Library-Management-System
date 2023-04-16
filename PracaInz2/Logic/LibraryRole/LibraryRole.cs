using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LogicLibrary
{
    public class LibraryRole : ILibraryItem
    {
        public enum RolePrivilege : byte
        {
            Patron = 1,
            Librarian = 2,
            Examiner = 2,
            Manager = 3,
            Administrator = 4,
            Root = 5
        }

        [BsonId]
        public ObjectId Id { get; set; }
        [BsonIgnoreIfDefault]
        public bool IsDeleted { get; set; }
        public string Name { get; set; }
        public RolePrivilege Privilege { get; set; }
        [BsonIgnoreIfDefault]
        public bool IsPatron { get; set; }
        [BsonIgnoreIfDefault]
        public bool IsLibrarian { get; set; }
        [BsonIgnoreIfDefault]
        public bool IsExaminer { get; set; }
        [BsonIgnoreIfDefault]
        public bool IsManager { get; set; }
        [BsonIgnoreIfDefault]
        public bool IsAdministrator { get; set; }
        public UserRights Rights { get; set; }

        public LibraryRole()
        {
            Rights = new UserRights();
        }

        public LibraryRole(LibraryRole role)
        {
            Id = role.Id;
            Name = role.Name;
            Privilege = role.Privilege;
            IsPatron = role.IsPatron;
            IsLibrarian = role.IsLibrarian;
            IsExaminer = role.IsExaminer;
            IsManager = role.IsManager;
            IsAdministrator = role.IsAdministrator;
            Rights = new UserRights(role.Rights);
        }
    }
}
