using OnlineShopping.Models.DTO.Account;

namespace OnlineShopping.Repository.Interface
{
    public interface IAccountRepository
    {
        Task<int> Commit();
        Task Register(User user);
        Task<bool> CheckEmail(string email);
    }
}
