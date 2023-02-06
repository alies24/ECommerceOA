using ECommerce_OA.Domain.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_OA.Application.Abstract
{
    public interface IProductService
    {
        List<Product> GetProducts();
    }
}
