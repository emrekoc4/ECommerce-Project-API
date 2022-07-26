using Microsoft.AspNetCore.Mvc;
using ProjectECommerce.Core.Services;

namespace ProjectECommerce.API.Controllers
{
    public class ProductsController : CustomBaseController
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("categoryName")]
        public async Task<IActionResult> Products(string categoryName)
        {
            return CreateActionResult(await _productService.GetProductsByCategory(categoryName));
        }

        [HttpGet]
        public async Task<IActionResult> Products()
        {
            return CreateActionResult(await _productService.GetProducts());
        }
    }
}
