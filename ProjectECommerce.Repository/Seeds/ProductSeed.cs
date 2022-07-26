using Bogus;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjectECommerce.Core.Models;

namespace ProjectECommerce.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            int id = 1;
            var stock = new Faker<Product>()   //bogus paketi fake data yüklemesi yapmamı sağlıyor 
                .RuleFor(p => p.Id, f => id++)
                .RuleFor(p => p.Description, f => f.Commerce.ProductName())
                .RuleFor(p => p.Category, f => f.Commerce.Categories(1).First())
                .RuleFor(p => p.Unit, "Dollar")
                .RuleFor(p => p.CreatedDate, f => f.Date.Recent())
                .RuleFor(m => m.UnitPrice, f => f.Commerce.Price(1).First());

            builder.HasData(stock.GenerateBetween(1000, 1000));
        }
    }
}
