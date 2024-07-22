using OnlineShopping.Models.DTO.Product;

namespace OnlineShopping.Service.Interface
{
    public interface IProductService
    {
        Task<List<ProductAllDto>> GetAll(string uid);
        Task SetFavorite(FavoriteModel favoriteModel);
    }
}
