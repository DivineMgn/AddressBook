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
        public ObjectId Id { get; set; }

        [BsonRequired]
        [BsonElement("firstName")]
        [Required]
        [Display(Name = "Имя")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [BsonElement("secondName")]
        [Display(Name = "Отчество")]
        [DataType(DataType.Text)]
        public string SecondName { get; set; }

        [BsonRequired]
        [BsonElement("lastName")]
        [Required]
        [Display(Name = "Фамилия")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [BsonRequired]
        [BsonElement("email")]
        [Required]
        [Display(Name = "Адрес электронной почты")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [BsonIgnore]
        public string FullName => $"{this.LastName} {this.FirstName}".Trim();
    }
}