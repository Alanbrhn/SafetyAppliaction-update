using System.ComponentModel.DataAnnotations;

namespace SafetyAppliaction.Models
{
    public class RegisterViewModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password tidak cocok.")]
        public string ConfirmPassword { get; set; }
    }

}
