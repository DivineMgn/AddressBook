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
        [Required(ErrorMessage ="Имя обязательно для заполнения")]
        [Display(Name = "Имя")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Имя не может быть короче 2 символов и длинее 50")] 
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [BsonElement("secondName")]
        [Display(Name = "Отчество")] 
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Отчество не может быть короче 2 символов и длинее 50")]
        [DataType(DataType.Text)]
        public string SecondName { get; set; }

        [BsonRequired]
        [BsonElement("lastName")]
        [Required(ErrorMessage = "Фамилия обязательна для заполнения")]
        [Display(Name = "Фамилия")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Фамилия не может быть короче 2 символов и длинее 50")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [BsonRequired]
        [BsonElement("email")]
        [Required(ErrorMessage = "Адрес эл. почты обязателен для заполнения")]
        [Display(Name = "Адрес электронной почты")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [BsonIgnore]
        public string FullName => $"{this.LastName} {this.FirstName}".Trim();
    }
}