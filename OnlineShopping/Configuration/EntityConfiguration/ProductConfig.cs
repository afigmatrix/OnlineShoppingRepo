using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnlineShopping.Configuration.EntityConfiguration
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(m => m.Image).IsRequired().HasMaxLength(500);
            builder.Property(m => m.Header).IsRequired().HasMaxLength(100);
            builder.Property(m => m.Description).IsRequired().HasMaxLength(300);

        }
    }
}
