using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;


namespace MongoDbNet6.Models

{
    [BsonIgnoreExtraElements]
    public class Student
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        [BsonElement("FirstName")]
        public string FirstName { get; set; }

        [BsonElement("LastName")]
        public string LastName { get; set; }

        [BsonElement("Age")]
        public int Age { get; set; }

        [BsonElement("Gender")]
        public string Gender { get; set; }
    }
}
