namespace OnlineShopping.Service.Interface
{
    public interface IProductService
    {
        Task<List<Product>> GetAll();
        Task SetFavorite(FavoriteModel favoriteModel);
    }
}
