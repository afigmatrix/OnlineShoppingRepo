using System.ComponentModel.DataAnnotations;

namespace OnlineShopping.Models.DTO.Account
{
    public class RegisterDto
    {
        [Required,EmailAddress(ErrorMessage ="Email is not valid format")]
        public string Email { get; set; }
        [Required, MinLength(8, ErrorMessage = "Min lengh 8 symbol")]
        public string Password { get; set; }
        [Required, MinLength(8, ErrorMessage = "Min lengh 8 symbol")]
        public string ConfirmPassword { get; set; }
    }
}
