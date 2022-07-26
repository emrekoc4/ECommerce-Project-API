using Microsoft.EntityFrameworkCore;
using ProjectECommerce.Core.Models;
using ProjectECommerce.Core.Repositories;

namespace ProjectECommerce.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(AppDbContext context) : base(context)
        {
        }

        public async Task<List<Product>> GetProductsByCategory(string categoryName)
        {
            return await _context.Products.Where(x => x.Category == categoryName).ToListAsync();
        }
    }
}
