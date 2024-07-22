using AutoMapper;
using OnlineShopping.Models.DTO.Product;
using OnlineShopping.Repository.Interface;
using OnlineShopping.Service.Interface;

namespace OnlineShopping.Service.Impl
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly IMapper mapper;

        public ProductService(IProductRepository productRepository,IMapper mapper)
        {
            this.productRepository = productRepository;
            this.mapper = mapper;
        }
        public async Task<List<ProductAllDto>> GetAll(string uid)
        {
            var res = new List<ProductAllDto>();
            var allProducts = await productRepository.GetAll();
            var userFavoriteProduct = await productRepository.GetFavoriteProdIdList(uid);
            foreach (var item in allProducts)
            {
                var mappedProduct = mapper.Map<ProductAllDto>(item);
                mappedProduct.IsFavorite = userFavoriteProduct.Any(m => m == item.Id);
                res.Add(mappedProduct);
            }
            return res;
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
