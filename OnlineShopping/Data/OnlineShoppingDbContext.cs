using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace OnlineShopping.Data
{
    public class OnlineShoppingDbContext : DbContext
    {
        public OnlineShoppingDbContext(DbContextOptions<OnlineShoppingDbContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<FirstSectionSlide> FirstSectionSlides { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<FavoriteModel> FavoriteModels { get; set; }
    }
}
