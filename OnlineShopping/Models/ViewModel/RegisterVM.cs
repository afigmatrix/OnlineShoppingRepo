using OnlineShopping.Models.DTO.Account;

namespace OnlineShopping.Models.ViewModel
{
    public class RegisterVM
    {
        public RegisterDto register { get; set; }
        public string Error { get; set; }
        public bool IsSuccess { get; set; }
    }
}
