using Microsoft.EntityFrameworkCore;
using OnlineShopping.Data;
using OnlineShopping.Repository.Interface;

namespace OnlineShopping.Repository.Impl
{
    public class ProductRepository : IProductRepository
    {
        private readonly OnlineShoppingDbContext context;

        public ProductRepository(OnlineShoppingDbContext context)
        {
            this.context = context;
        }

        public async Task<FavoriteModel> GetByModel(FavoriteModel favoriteModel)
        {
            return await context.FavoriteModels.FirstOrDefaultAsync(m => m.ProductId == favoriteModel.ProductId && m.UID == favoriteModel.UID);
        }
        public async Task AddFavorite(FavoriteModel favoriteModel)
        {
            await context.FavoriteModels.AddAsync(favoriteModel);
        }

        public async Task<bool> CheckFavorite(FavoriteModel favoriteModel)
        {
            return await context.FavoriteModels.AnyAsync(m=>m.ProductId == favoriteModel.ProductId);
        }

        public async Task Commit()
        {
            await context.SaveChangesAsync();
        }

        public async Task<List<Product>> GetAll()
        {
            return await context.Products.ToListAsync();
        }

        public async Task RemoveFavorite(FavoriteModel favoriteModel)
        {
           context.FavoriteModels.Remove(favoriteModel);
        }
    }
}
