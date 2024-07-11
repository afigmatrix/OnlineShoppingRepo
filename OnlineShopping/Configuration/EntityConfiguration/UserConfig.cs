using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OnlineShopping.Configuration.EntityConfiguration
{
    public class UserConfig : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(m => m.Email).IsRequired().HasMaxLength(100);
            builder.Property(m => m.Password).IsRequired().HasMaxLength(500);
        }
    }
}
