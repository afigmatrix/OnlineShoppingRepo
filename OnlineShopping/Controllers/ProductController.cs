using Microsoft.AspNetCore.Mvc;
using OnlineShopping.Service.Interface;

namespace OnlineShopping.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService productService;

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        public async Task SetFavorite(FavoriteModel model)
        {
            await productService.SetFavorite(model);
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
