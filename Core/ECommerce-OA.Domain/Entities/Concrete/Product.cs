using ECommerce_OA.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_OA.Domain.Entities.Concrete
{
    public class Product:CommonEntity
    {
        public decimal UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public string Description { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
