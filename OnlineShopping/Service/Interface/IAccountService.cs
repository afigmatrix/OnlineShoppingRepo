using Microsoft.AspNetCore.Mvc.ModelBinding;
using OnlineShopping.Models;
using OnlineShopping.Models.DTO.Account;
using OnlineShopping.Models.ViewModel;

namespace OnlineShopping.Service.Interface
{
    public interface IAccountService
    {
        Task<RegisterVM> Register(RegisterDto register, ModelStateDictionary modelState);
    }
}
