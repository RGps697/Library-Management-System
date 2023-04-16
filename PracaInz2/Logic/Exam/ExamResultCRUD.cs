using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public static class ExamResultCRUD
    {
        internal static void InsertExamResult(ExamResult examResult)
        {
            DatabaseGateway.InsertDocument("examResults", examResult);
        }

        public static List<ExamResult> FindExamResults(string collection, string column, string value)
        {
            BsonArray bsonArray = new BsonArray();
            string matchField = null;
            if (collection == "exams")
            {
                List<Exam> foundExams = DatabaseGateway.FindDocuments<Exam>(collection, column, value);
                for (int i = 0; i < foundExams.Count; i++)
                {
                    bsonArray.Add(foundExams[i].Id);
                }
                matchField = nameof(ExamResult.ExamId);
            }
            else if (collection == "users")
            {
                List<User> foundUsers = DatabaseGateway.FindDocuments<User>(collection, column, value);
                for (int i = 0; i < foundUsers.Count; i++)
                {
                    bsonArray.Add(foundUsers[i].Id);
                }
                matchField = nameof(ExamResult.UserId);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Collection name out of range");
            }

            List<ExamResult> result = JoinToExamResult(matchField, bsonArray);

            return result;
        }

        public static List<ExamResult> FindExamResultsById(string column, ObjectId userId)
        {
            BsonArray bsonArray = new BsonArray();
            bsonArray.Add(userId);
            List<ExamResult> result = JoinToExamResult(column, bsonArray);
            return result;
        }

        private static List<ExamResult> JoinToExamResult(string matchField, BsonArray valuesRange)
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

            BsonDocument joinExams = new BsonDocument
            {
                {
                    "$lookup", new BsonDocument
                    {
                        { "from", "exams" },
                        { "localField", "ExamId" },
                        { "foreignField", "_id" },
                        { "as", "ExamData" }
                    }
                }
            };

            BsonDocument projectFields = new BsonDocument
            {
                {
                    "$project", new BsonDocument
                    {
                        { "_id", 1 },
                        { "ExamId", 1 },
                        { "UserId", 1 },
                        { "Score", 1 },
                        {
                            "UserData", new BsonDocument
                            {
                                    { nameof(User.FirstName), 1 },
                                    { nameof(User.Surname), 1 }
                            }
                        },
                        {
                            "ExamData", new BsonDocument
                            {
                                    { "Author", 1 },
                                    { "Name", 1 },
                                    { "Description", 1 }
                            }
                        }
                    }
                }
            };

            BsonDocument[] pipeline = new BsonDocument[] { findDocuments, joinUsers, joinExams, projectFields };
            List<BsonDocument> results = DatabaseGateway.JoinCollections("examResults", pipeline);

            List<ExamResult> convertedResults = new List<ExamResult>();
            ExamResult examResult;

            foreach (BsonDocument bsonBorrowing in results)
            {
                examResult = new ExamResult(bsonBorrowing);
                convertedResults.Add(examResult);
            }

            return convertedResults;
        }

    }
}
