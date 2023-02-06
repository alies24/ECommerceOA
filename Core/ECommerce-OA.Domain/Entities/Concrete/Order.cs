using ECommerce_OA.Domain.Entities.Common;

namespace ECommerce_OA.Domain.Entities.Concrete
{
    public class Order:CommonEntity
    {
        public int CustomerId { get; set; }
        public string Description { get; set; }
        public string Adress { get; set; }
        public ICollection<Product> Products { get; set; }
        public Customer Customer { get; set; }
    }
}
