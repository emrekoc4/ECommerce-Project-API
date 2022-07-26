
namespace ProjectECommerce.Core.Models
{
    public class OrderDetail : BaseEntity
    {
        public decimal UnitPrice { get; set; }
        public int ProductId { get; set; }
        public ICollection<Product> Products { get; set; }
        public int OrderId { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
