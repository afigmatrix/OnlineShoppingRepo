using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Models.DTO.Account;
using OnlineShopping.Service.Interface;

namespace OnlineShopping.Controllers
{
    public class AccountController : Controller
    {
        private readonly IAccountService accountService;

        public AccountController(IAccountService accountService)
        {
            this.accountService = accountService;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterDto register)
        {
            var result =await accountService.Register(register,ModelState);
            if (result.IsSuccess)
                return RedirectToAction("Login","Account");
            return View(result);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
    }
}
