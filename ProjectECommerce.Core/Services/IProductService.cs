using ProjectECommerce.Core.DTOs;
using ProjectECommerce.Core.Models;

namespace ProjectECommerce.Core.Services
{
    public interface IProductService : IService<Product>
    {
        Task<CustomResponseDto<List<ProductDto>>> GetProductsByCategory(string categoryName);
        Task<CustomResponseDto<List<ProductDto>>> GetProducts();

    }
}
