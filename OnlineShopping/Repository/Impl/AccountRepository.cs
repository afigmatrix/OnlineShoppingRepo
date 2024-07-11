using Microsoft.EntityFrameworkCore;
using OnlineShopping.Data;
using OnlineShopping.Models.DTO.Account;
using OnlineShopping.Repository.Interface;

namespace OnlineShopping.Repository.Impl
{
    public class AccountRepository : IAccountRepository
    {
        private readonly OnlineShoppingDbContext context;

        public AccountRepository(OnlineShoppingDbContext context)
        {
            this.context = context;
        }

        public async Task Register(User user)
        {
            await context.Users.AddAsync(user);
        }

        public async Task<int> Commit()
        {
            return await context.SaveChangesAsync();
        }

        public async Task<bool> CheckEmail(string email)
        {
            return await context.Users.AnyAsync(m => m.Email == email);
        }
    }
}
