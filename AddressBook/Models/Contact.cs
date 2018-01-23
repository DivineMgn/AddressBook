using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.ComponentModel.DataAnnotations;

namespace AddressBook.Models
{
    public class Contact
    {
        [BsonId]
        [BsonElement("id")]
        [BsonRepresentation(BsonType.ObjectId)]

        public string Id { get; set; }

        [BsonRequired]
        [BsonElement("firstName")]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [BsonRequired]
        [BsonElement("secondName")]
        [Display(Name = "Отчество")]
        public string SecondName { get; set; }

        [BsonRequired]
        [BsonElement("lastName")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }

        [BsonRequired]
        [BsonElement("email")]
        [Display(Name = "Адрес электронной почты")]
        public string Email { get; set; }

        [BsonIgnore]
        public string FullName => $"{this.LastName} {this.FirstName} {this.SecondName}".Trim();
    }
}