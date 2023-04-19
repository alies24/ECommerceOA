using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_OA.Application.ViewModels.Products
{
    public class VM_CreateProduct
    {
        public string Name { get; set; }
        public int UnitsInStock { get; set; }
        public float UnitPrice { get; set; }
        public string Description { get; set; }
    }
}
