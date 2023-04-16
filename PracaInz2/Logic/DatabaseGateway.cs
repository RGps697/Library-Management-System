using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver.GridFS;
using System.IO;
using MongoDB.Bson.Serialization;
using Microsoft.VisualBasic;
using System.Collections;
using System.Configuration;
using System.Text.Json;
using System.Xml.Linq;
using SharpCompress.Compressors.Xz;
using System.Text.RegularExpressions;

namespace LogicLibrary
{
    public static class DatabaseGateway
    {
        static IMongoDatabase Database;
        static GridFSBucket EbookBucket;
        static GridFSBucket ImageBucket;
        static readonly string DatabaseName = "library";

        public enum TargetBucket : byte
        {
            EbookBucket = 0,
            ImageBucket = 1
        }

        static DatabaseGateway()
        {
            RegisterClassMaps();

        }

        public static bool ConnectToDatabase()
        {
            string json = File.ReadAllText("appdbconfig.json");
            DatabaseCredentials? settings = JsonSerializer.Deserialize<DatabaseCredentials>(json);
            string connection;
            if (string.IsNullOrEmpty(settings.UserName))
            {
                connection = $"mongodb://{settings.Ip}:{settings.Port}/{DatabaseName}";
            }
            else
            {
                connection = $"mongodb://{settings.UserName}:{settings.Password}@{settings.Ip}:{settings.Port}/{DatabaseName}";
            }
            MongoClient client = new MongoClient(connection);
            Database = client.GetDatabase(DatabaseName);
            EbookBucket = new GridFSBucket(Database, new GridFSBucketOptions { BucketName = "ebooks" }); //ChunkSizeBytes = 26214400 });
            ImageBucket = new GridFSBucket(Database, new GridFSBucketOptions { BucketName = "images" });

            return true;
        }

        public static bool AttemptConnection(string ip, string port, string username, string password)
        {
            try
            {
                string connection;
                if (string.IsNullOrEmpty(username))
                {
                    connection = $"mongodb://{ip}:{port}/{DatabaseName}";
                }
                else
                {
                    connection = $"mongodb://{username}:{password}@{ip}:{port}/{DatabaseName}";
                }
                MongoClient client = new MongoClient(connection);
                IMongoDatabase db = client.GetDatabase(DatabaseName);

                var filter = Builders<User>.Filter.Eq("id", "0");
                db.GetCollection<User>("users").Find(filter).ToList();
                Database = db;

                EbookBucket = new GridFSBucket(Database, new GridFSBucketOptions { BucketName = "ebooks" }); //ChunkSizeBytes = 26214400 });

                DatabaseCredentials databaseCredentials = new DatabaseCredentials()
                {
                    Ip = ip,
                    Port = port,
                    UserName = username,
                    Password = password
                };
                string json = JsonSerializer.Serialize(databaseCredentials);
                File.WriteAllText(@"appdbconfig.json", json);

                return true;
            }
            catch (MongoCommandException e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                return false;
            }
        }

        //registering classes that inherit from interfaces
        private static void RegisterClassMaps()
        {
            BsonClassMap.RegisterClassMap<SingleChoiceQuestion>();
            BsonClassMap.RegisterClassMap<MultiChoiceQuestion>();
        }

        internal static T FindDocument<T>(string collectionName, string column, string value)
        {
            var collection = Database.GetCollection<T>(collectionName);
            value = DeleteRegexCharacters(value);
            if (!string.IsNullOrEmpty(value))
            {
                var filter = Builders<T>.Filter.Regex(column, new BsonRegularExpression(value, "i")) 
                & (Builders<T>.Filter.Not(Builders<T>.Filter.Eq("IsDeleted", "True")));
                return collection.Find(filter).FirstOrDefault();
            }
            else
            {
                return default(T);
            }
        }

        internal static List<T> FindDocuments<T>(string collectionName)
        {
            var collection = Database.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Not(Builders<T>.Filter.Eq("IsDeleted", "True"));
            return collection.Find(filter).ToList();
        }

        internal static List<T> FindDocuments<T>(string collectionName, string column, string value)
        {

            var collection = Database.GetCollection<T>(collectionName);
            value = DeleteRegexCharacters(value);
            if (!string.IsNullOrEmpty(value))
            {
                var filter = Builders<T>.Filter.Regex(column, new BsonRegularExpression(value, "i")) & (Builders<T>.Filter.Not(Builders<T>.Filter.Eq("IsDeleted", "True")));
                return collection.Find(filter).ToList();    
            }
            else
            {
                return new List<T>();
            }
        }

        internal static List<T> FindDocumentsWithoutId<T>(string collectionName, string column, string value, ObjectId id)
        {
            var collection = Database.GetCollection<T>(collectionName);
            value = DeleteRegexCharacters(value);
            if (!string.IsNullOrEmpty(value))
            {
                var filter = Builders<T>.Filter.Regex(column, new BsonRegularExpression(value, "i"))
                    & (Builders<T>.Filter.Not(Builders<T>.Filter.Eq("IsDeleted", "True")))
                    & (Builders<T>.Filter.Not(Builders<T>.Filter.Eq("_id", id)));

                return collection.Find(filter).ToList();
            }
            else
            {
                return new List<T>();
            }
        }

        internal static T FindDocumentById<T>(string collectionName, string column, ObjectId id)
        {
            var collection = Database.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Eq(column, id) 
                & (Builders<T>.Filter.Not(Builders<T>.Filter.Eq("IsDeleted", "True")));
            var result = collection.Find(filter).FirstOrDefault();
            return result;
        }

        internal static List<T> FindDocumentsById<T>(string collectionName, string column, ObjectId id)
        {
            var collection = Database.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Eq(column, id) 
                & (Builders<T>.Filter.Not(Builders<T>.Filter.Eq("IsDeleted", "True")));
            var result = collection.Find(filter).ToList();
            foreach (var x in result)
            {
                Console.WriteLine($"database record found: {x}");
            }
            return result;
        }

        internal static List<T> FindDocumentsByIds<T>(string collectionName, string column, List<ObjectId> ids)
        {
            foreach (var x in ids)
            {
                Debug.WriteLine($"id: {x}");
            }
            var collection = Database.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.In(column, ids) 
                & (Builders<T>.Filter.Not(Builders<T>.Filter.Eq("IsDeleted", "True")));
            var result = collection.Find(filter).ToList();
            foreach (var x in result)
            {
                Debug.WriteLine($"database record found: {x}");
            }
            return result;
        }

        internal static List<T> FindDocumentsUsingRange<T>(string collectionName, string column, int minValue, int maxValue)
        {
            var collection = Database.GetCollection<T>(collectionName);
            var filter = Builders<T>.Filter.Gte(column, minValue) 
                & Builders<T>.Filter.Lte(column, maxValue);
            var result = collection.Find(filter).ToList();
            return result;
        }


        private static string DeleteRegexCharacters(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                value = Regex.Replace(value, "[^0-9a-zA-Z@. ]+", "");
            }
            return value;
        }

        internal static void InsertDocument<T>(string collectionName, T document)
        {
            var collection = Database.GetCollection<T>(collectionName);
            collection.InsertOne(document);
        }

        internal static ReplaceOneResult UpsertDocument<T>(string collectionName, ObjectId id, T document)
        {
            var collection = Database.GetCollection<T>(collectionName);
            Console.WriteLine(document.ToString());
            var res = collection.ReplaceOne(new BsonDocument("_id", id), document, new ReplaceOptions { IsUpsert = true });
            Console.WriteLine(res);
            return res;
        }

        internal static ReplaceOneResult UpdateDocument<T>(string collectionName, ObjectId id, T document)
        {
            var collection = Database.GetCollection<T>(collectionName);
            Console.WriteLine($"UpdateDocument: {document}");
            var res = collection.ReplaceOne(new BsonDocument("_id", id), document, new ReplaceOptions { IsUpsert = false });
            Console.WriteLine($"updatedocument result: {res.MatchedCount}");
            return res;
        }

        internal static bool UpdateDocumentField<T>(string collectionName, ObjectId id, string field, T value)
        {
            var collection = Database.GetCollection<T>(collectionName);
            var result = collection.UpdateOne(new BsonDocument("_id", id), Builders<T>.Update.Set(field, value));
            return result.IsAcknowledged;
        }

        internal static bool DeleteDocumentField<T>(string collectionName, ObjectId id, string fieldName)
        {
            var collection = Database.GetCollection<T>(collectionName);
            var result = collection.UpdateOne(new BsonDocument("_id", id), Builders<T>.Update.Unset(fieldName));
            return result.IsAcknowledged;
        }

        internal static void DeleteDocument<T>(string collectionName, ObjectId id)
        {
            var collection = Database.GetCollection<T>(collectionName);
            var res = collection.UpdateOne(Builders<T>.Filter.Eq("_id", id), Builders<T>.Update.Set("IsDeleted", "true"));
        }

        //GRIDFS

        internal static ObjectId InsertBucketFile(string filename, Stream source, TargetBucket bucket)
        {
            ObjectId id = ObjectId.Empty;
            Debug.WriteLine($"Source: {source}");
            if (bucket == TargetBucket.EbookBucket)
            {
                id = EbookBucket.UploadFromStream(filename, source);
            }
            else if (bucket == TargetBucket.ImageBucket)
            {
                id = ImageBucket.UploadFromStream(filename, source);
            }
            return id;
        }

        internal static Stream FindBucketFile(ObjectId id, TargetBucket bucket)
        {
            Stream stream = new MemoryStream();
            if (bucket == TargetBucket.EbookBucket)
            {
                EbookBucket.DownloadToStream(id, stream);
            }
            else if (bucket == TargetBucket.ImageBucket)
            {
                ImageBucket.DownloadToStream(id, stream);
            }
            
            return stream;
        }

        internal static void RemoveBucketFile(ObjectId id, TargetBucket bucket)
        {
            if (bucket == TargetBucket.EbookBucket)
            {
                EbookBucket.Delete(id);
            }
            else if (bucket == TargetBucket.ImageBucket)
            {
                ImageBucket.Delete(id);
            }
        }

        internal static List<BsonDocument> JoinCollections(string collectionName, BsonDocument[] pipeline)
        {
            var collection = Database.GetCollection<BsonDocument>(collectionName);

            List<BsonDocument> results = collection.Aggregate<BsonDocument>(pipeline).ToList();
            Console.WriteLine($"database gateway Result amount: {results}, {results.Count}");
            foreach(BsonDocument result in results)
            {
                Console.WriteLine($"Database result: {result}");
            }
            return results;
        }

    }
}
