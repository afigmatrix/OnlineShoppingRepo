using OnlineShopping.Repository.Interface;
using OnlineShopping.Service.Interface;

namespace OnlineShopping.Service.Impl
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;

        public ProductService(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }
        public async Task<List<Product>> GetAll()
        {
            return await productRepository.GetAll();
        }

        public async Task SetFavorite(FavoriteModel favoriteModel)
        {
            var favModel = await productRepository.GetByModel(favoriteModel);
            if (favModel is not null)
                await productRepository.RemoveFavorite(favModel);
            else
                await productRepository.AddFavorite(favoriteModel);
            await productRepository.Commit();
        }
    }
}
