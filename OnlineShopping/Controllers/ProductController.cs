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

        public  async Task<IActionResult> GetProductPartialView([FromQuery(Name ="UID")]string UID)
        {
            var data = await productService.GetAll(UID);
            return PartialView(data);
        }

        public IActionResult Index()
        {

            return View();
        }
    }
}
