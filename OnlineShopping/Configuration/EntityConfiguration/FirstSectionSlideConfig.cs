using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OnlineShopping.Data.Entity;

namespace OnlineShopping.Configuration.EntityConfiguration
{
    public class FirstSectionSlideConfig : IEntityTypeConfiguration<FirstSectionSlide>
    {
        public void Configure(EntityTypeBuilder<FirstSectionSlide> builder)
        {
            builder.Property(m => m.HeaderText).IsRequired().HasMaxLength(100);
            builder.Property(m => m.Description).IsRequired(false).HasMaxLength(500);
            builder.Property(m => m.Image).IsRequired().HasMaxLength(500);
            builder.Property(m => m.URL).IsRequired().HasMaxLength(500);
        }
    }
}
