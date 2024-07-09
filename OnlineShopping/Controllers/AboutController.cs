using Microsoft.AspNetCore.Mvc;

namespace OnlineShopping.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
