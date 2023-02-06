using ECommerce_OA.Domain.Entities.Common;

namespace ECommerce_OA.Domain.Entities.Concrete
{
    public class Customer:CommonEntity
    {
        public string CustomerName { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
