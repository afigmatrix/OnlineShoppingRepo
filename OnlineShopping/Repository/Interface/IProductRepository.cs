namespace OnlineShopping.Repository.Interface
{
    public interface IProductRepository
    {
        Task<FavoriteModel> GetByModel(FavoriteModel favoriteModel);
        Task<List<Product>> GetAll();
        Task<List<int>> GetFavoriteProdIdList();
        Task AddFavorite(FavoriteModel favoriteModel);
        Task RemoveFavorite(FavoriteModel favoriteModel);
        Task Commit();
    }
}
