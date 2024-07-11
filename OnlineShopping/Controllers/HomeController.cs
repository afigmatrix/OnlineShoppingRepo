using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineShopping.Data;
using OnlineShopping.Models;
using System.Diagnostics;

namespace OnlineShopping.Controllers
{
    public class HomeController : Controller
    {
        private readonly OnlineShoppingDbContext context;

        public HomeController(OnlineShoppingDbContext _context)
        {
            context = _context;
        }

        public async Task<IActionResult> Index()
        {
            var data = await context.FirstSectionSlides.ToListAsync();
            return View(data);
        }

        public IActionResult Privacy()
        {
            return View();
        }

       
    }
}
