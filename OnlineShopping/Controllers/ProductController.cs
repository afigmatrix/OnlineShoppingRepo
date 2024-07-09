using Microsoft.AspNetCore.Mvc;

namespace OnlineShopping.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
