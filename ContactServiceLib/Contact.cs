using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContactServiceLib
{
    [Table("Contacts")]
    public class Contact 
    {
        [Key] 
        public long Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [MaxLength(50)]
        public string SecondName { get; set; }

        [Required]
        [MaxLength(150)]
        public string Email { get; set; }
    }
}
