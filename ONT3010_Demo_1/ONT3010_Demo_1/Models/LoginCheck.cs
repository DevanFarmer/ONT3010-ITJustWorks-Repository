using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ONT3010_Demo_1.Models
{
    public class LoginCheck
    {
        [Key]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
