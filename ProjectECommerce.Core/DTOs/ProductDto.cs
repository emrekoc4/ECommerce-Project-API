
namespace ProjectECommerce.Core.DTOs
{
    public class ProductDto : BaseDto
    {
        public string Description { get; set; }
        public string Category { get; set; }
        public string Unit { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
