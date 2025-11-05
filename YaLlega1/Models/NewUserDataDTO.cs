using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace YaLlega.Models
{
    public class NewUserDataDTO
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string EmailAdress { get; set; }
        [Required]
        [PasswordPropertyText]
        public string Password { get; set; }
    }
}