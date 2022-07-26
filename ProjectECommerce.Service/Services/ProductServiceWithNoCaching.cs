using AutoMapper;
using ProjectECommerce.Core.DTOs;
using ProjectECommerce.Core.Models;
using ProjectECommerce.Core.Repositories;
using ProjectECommerce.Core.Services;
using ProjectECommerce.Core.UnitOfWorks;

namespace ProjectECommerce.Service.Services
{
    public class ProductServiceWithNoCaching : Service<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;

        private readonly IMapper _mapper;
        public ProductServiceWithNoCaching(IGenericRepository<Product> repository, IUnitOfWork unitOfWork, IProductRepository productRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<CustomResponseDto<List<ProductDto>>> GetProductsByCategory(string categoryName)
        {
            var products = await _productRepository.GetProductsByCategory(categoryName);
            if (products.Count == 0)
            {
                return CustomResponseDto<List<ProductDto>>.Fail(404, $"{categoryName} not found.");
            }
            var productsDto = _mapper.Map<List<ProductDto>>(products);
            return CustomResponseDto<List<ProductDto>>.Success(200, productsDto);
        }

        public async Task<CustomResponseDto<List<ProductDto>>> GetProducts()
        {
            var products = await GetAllAsync();
            var productsDto = _mapper.Map<List<ProductDto>>(products);
            return CustomResponseDto<List<ProductDto>>.Success(200, productsDto);
        }
    }
}
