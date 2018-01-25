using ContactServiceLibrary.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace ContactServiceLibrary.MsSQLService
{
    [DataContract]
    [Table("Contacts")]
    public class MsSQLContactType : IContactType<long>
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Имя обязательно для заполнения")]
        [Display(Name = "Имя")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Имя не может быть короче 2 символов и длинее 50")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Фамилия обязательна для заполнения")]
        [Display(Name = "Фамилия")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Фамилия не может быть короче 2 символов и длинее 50")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Display(Name = "Отчество")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Отчество не может быть короче 2 символов и длинее 50")]
        [DataType(DataType.Text)]
        public string SecondName { get; set; }

        [Required(ErrorMessage = "Адрес эл. почты обязателен для заполнения")]
        [Display(Name = "Адрес электронной почты")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
} 