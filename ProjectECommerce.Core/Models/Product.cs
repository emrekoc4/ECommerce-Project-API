using ProjectECommerce.Core.Enums;

namespace ProjectECommerce.Core.Models
{
    public class Product : BaseEntity
    {
        public string Description { get; set; }
        public string Category { get; set; }
        public string Unit { get; set; }
        public decimal UnitPrice { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
