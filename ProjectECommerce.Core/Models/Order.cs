
namespace ProjectECommerce.Core.Models
{
    public class Order : BaseEntity
    {
        public string CustomerName { get; set; }
        public string CustomerEMail { get; set; }
        public string CustomerGSM { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
