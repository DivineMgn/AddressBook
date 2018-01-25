using System.ComponentModel.DataAnnotations;

namespace AddressBook.Models
{
    public class Contact
    {
        [Required]
        public long Id { get; set; }
        
        [Required(ErrorMessage = "Имя обязательно для заполнения")]
        [Display(Name = "Имя")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Имя не может быть короче 2 символов и длинее 50")]
        [DataType(DataType.Text)]
        public string FirstName { get; set; }

        [Display(Name = "Отчество")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Отчество не может быть короче 2 и длинее 50 символов")]
        [DataType(DataType.Text)]
        public string SecondName { get; set; }

        [Required(ErrorMessage = "Фамилия обязательна для заполнения")]
        [Display(Name = "Фамилия")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Фамилия не может быть короче 2 и длинее 50 символов")]
        [DataType(DataType.Text)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Адрес эл. почты обязателен для заполнения")]
        [Display(Name = "Адрес электронной почты")]
        [DataType(DataType.EmailAddress)]
        [StringLength(150, ErrorMessage = "Адрес электронной почты не может быть длинее 150 символов")]
        public string Email { get; set; }

        public string FullName => $"{this.LastName} {this.FirstName}".Trim();
    }
}