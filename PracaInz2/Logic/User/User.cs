using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;

namespace LogicLibrary
{
    public class User : ILibraryItem
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonIgnoreIfDefault]
        public bool IsDeleted { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public byte[] Salt { get; set; }
        public string PhoneNumber { get; set; }
        public ObjectId RoleId { get; set; }
        [BsonIgnore]
        public LibraryRole Role { get; set; }
    }

}
