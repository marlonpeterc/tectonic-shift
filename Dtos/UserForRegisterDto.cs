using System.ComponentModel.DataAnnotations;

namespace TectonicShift.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 8, ErrorMessage = "You must specify a password with minimum of 8 characters")]
        public string Password { get; set; }
    }
}