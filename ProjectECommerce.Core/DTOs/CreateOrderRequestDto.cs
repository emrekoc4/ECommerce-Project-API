
namespace ProjectECommerce.Core.DTOs
{
    public class CreateOrderRequestDto : BaseDto
    {
        public string CustomerName { get; set; }
        public string CustomerEMail { get; set; }
        public string CustomerGSM { get; set; }
        public List<ProductDetailDto> ProductDetailDtos { get; set; }
    }
}
