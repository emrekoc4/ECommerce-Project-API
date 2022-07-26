using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectECommerce.Core.Models;

namespace ProjectECommerce.Repository.Configurations
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseMySqlIdentityColumn();
            builder.Property(x => x.Description).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Category).IsRequired().HasMaxLength(50);
            builder.Property(x => x.UnitPrice).IsRequired().HasColumnType("decimal(9,2)");
        }
    }
}
