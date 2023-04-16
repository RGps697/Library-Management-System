using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace LogicLibrary
{
    public class Exam : ILibraryItem
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonIgnoreIfDefault]
        public bool IsDeleted { get; set; }
        public string Name { get; internal set; }
        public string Description { get; internal set; }
        public ObjectId Author { get; internal set; }
        [BsonIgnore]
        public string AuthorFirstName { get; internal set; }
        [BsonIgnore]
        public string AuthorSurname { get; internal set; }
        public List<IQuestion> Questions { get; internal set; } = new List<IQuestion>();
        public ushort QuestionAmountPerSession { get; internal set; } = 0;
        public ushort LastQuestionId { get; internal set; } = 0;
        [BsonIgnoreIfDefault]
        public List<ObjectId> LinkedBooks { get; set; } = new List<ObjectId>();

        public Exam()
        {
            Questions = new List<IQuestion>();
            LinkedBooks = new List<ObjectId>();
        }

        public Exam(Exam exam)
        {
            Id = exam.Id;
            Name = exam.Name;
            Description = exam.Description;
            Author = exam.Author;
            AuthorFirstName = exam.AuthorFirstName;
            AuthorSurname= exam.AuthorSurname;
            Questions = new List<IQuestion>();
            for(int i = 0; i < exam.Questions.Count; i++)
            {
                if (exam.Questions[i].GetType() == typeof(SingleChoiceQuestion)) {
                    Questions.Add(new SingleChoiceQuestion(exam.Questions[i]));
                }
                else if(exam.Questions[i].GetType() == typeof(MultiChoiceQuestion))
                {
                    Questions.Add(new MultiChoiceQuestion(exam.Questions[i]));
                }
            }
            QuestionAmountPerSession = exam.QuestionAmountPerSession;
            LastQuestionId = exam.LastQuestionId;
            LinkedBooks = new List<ObjectId>();
            for(int i = 0; i < exam.LinkedBooks.Count; i++)
            {
                LinkedBooks.Add(exam.LinkedBooks[i]);
            }

        }
    }
}
