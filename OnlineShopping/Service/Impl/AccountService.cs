using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using OnlineShopping.Models;
using OnlineShopping.Models.DTO.Account;
using OnlineShopping.Models.ViewModel;
using OnlineShopping.Repository.Interface;
using OnlineShopping.Service.Interface;
using OnlineShopping.Utility;
using System.Security.Cryptography;

namespace OnlineShopping.Service.Impl
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }
        public async Task<RegisterVM> Register(RegisterDto register, ModelStateDictionary modelState)
        {
            var registervm = new RegisterVM();
            registervm.register = register;
            if (!modelState.IsValid)
            {
                registervm.Error = "Data is not valid";
                return registervm;
            }
            var checkEmail = await accountRepository.CheckEmail(register.Email);
            if (checkEmail)
            {
                registervm.Error="Email already exist";
                return registervm;
            }
            if (register.Password != register.ConfirmPassword)
            {
                registervm.Error = "Password is not equal Confirm Password";
                return registervm;
            }

            User user = new User();
            user.Password = General.ComputeHash(register.Password, new SHA256CryptoServiceProvider());
            user.Email = register.Email;
            await accountRepository.Register(user);
            await accountRepository.Commit();

            registervm.IsSuccess = true;
            return registervm;
        }
    }
}
