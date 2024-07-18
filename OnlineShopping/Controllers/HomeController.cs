using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShopping.Data;
using OnlineShopping.Models;
using OnlineShopping.Models.ViewModel;
using OnlineShopping.Service.Interface;
using System.Diagnostics;

namespace OnlineShopping.Controllers
{
    public class HomeController : Controller
    {
        private readonly OnlineShoppingDbContext context;
        private readonly IProductService productService;

        public HomeController(OnlineShoppingDbContext _context,IProductService productService)
        {
            context = _context;
            this.productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var vm = new HomeIndexVM
            {
                FirstSectionSlide = await context.FirstSectionSlides.ToListAsync(),
                Products = await productService.GetAll(),
            };
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
