using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace LogicLibrary
{
    public class ExamResult : ILibraryItem
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonIgnoreIfDefault]
        public bool IsDeleted { get; set; }
        public ObjectId ExamId { get; set; }
        public ObjectId UserId { get; set; }
        [BsonRepresentation(BsonType.Decimal128)]
        public decimal Score { get; internal set; }
        [BsonIgnore]
        public ObjectId ExamAuthorId { get; internal set; }
        [BsonIgnore]
        public string ExamName { get; internal set; }
        [BsonIgnore]
        public string ExamDescription { get; internal set; }
        [BsonIgnore]
        public string UserFirstName { get; internal set; }
        [BsonIgnore]
        public string UserSurname { get; internal set; }

        internal ExamResult(BsonDocument bsonExamResult)
        {
            Id = bsonExamResult["_id"].AsObjectId;
            ExamId = bsonExamResult["ExamId"].AsObjectId;
            UserId = bsonExamResult["UserId"].AsObjectId;
            Score = bsonExamResult["Score"].AsDecimal;
            BsonArray examData = bsonExamResult["ExamData"].AsBsonArray;
            ExamAuthorId = examData[0]["Author"].AsObjectId;
            ExamName = examData[0]["Name"].AsString;
            ExamDescription = examData[0]["Description"].IsBsonNull ? null : examData[0]["Description"].AsString;
            BsonArray userData = bsonExamResult["UserData"].AsBsonArray;
            UserFirstName = userData[0]["FirstName"].AsString;
            UserSurname = userData[0]["Surname"].AsString;
        }

        internal ExamResult(Exam exam, User user, decimal score)
        {
            ExamId = exam.Id;
            UserId = user.Id;
            Score = score;
        }
    }
}