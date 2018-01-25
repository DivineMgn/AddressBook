using ContactServiceLibrary.Interfaces;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Runtime.Serialization;

namespace ContactServiceLibrary.MongoService
{
    [DataContract]
    public class MongoContactType : IContactType<string>
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRequired]
        [BsonElement("firstName")]
        public string FirstName { get; set; }

        [BsonRequired]
        [BsonElement("lastName")]
        public string LastName { get; set; }

        [BsonElement("secondName")]
        public string SecondName { get; set; }

        [BsonRequired]
        [BsonElement("email")]
        public string Email { get; set; }
    }
} 