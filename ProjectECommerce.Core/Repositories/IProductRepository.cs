using ProjectECommerce.Core.Models;

namespace ProjectECommerce.Core.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<List<Product>> GetProductsByCategory(string categoryName);
    }
}
