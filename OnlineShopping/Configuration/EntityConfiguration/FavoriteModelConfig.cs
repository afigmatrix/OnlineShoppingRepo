using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnlineShopping.Configuration.EntityConfiguration
{
    public class FavoriteModelConfig : IEntityTypeConfiguration<FavoriteModel>
    {
        public void Configure(EntityTypeBuilder<FavoriteModel> builder)
        {
            builder.Property(m => m.UID).IsRequired().HasMaxLength(100);
        }
    }
}
