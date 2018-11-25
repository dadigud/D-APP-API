using System.ComponentModel.DataAnnotations;

namespace DatingApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(24, MinimumLength = 8, ErrorMessage="Your password must be at least of length 8 or longer")]
        public string Password { get; set; }

    }
}