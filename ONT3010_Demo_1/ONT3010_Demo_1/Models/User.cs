using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ONT3010_Demo_1.Models
{
    public class User
    {
        [Key]
        [EmailAddress(ErrorMessage = "Must be a valid email address.")]
        public string Email { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        [Phone]
        public string Contact { get; set; }
    }
}
