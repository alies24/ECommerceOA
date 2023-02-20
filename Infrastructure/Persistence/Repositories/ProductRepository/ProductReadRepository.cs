using ECommerce_OA.Application.Repositories.ProductRepository;
using ECommerce_OA.Domain.Entities.Concrete;
using ECommerceOA.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceOA.Persistence.Repositories.ProductRepository
{
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        public ProductReadRepository(ECommerceOADbContext dbContext) : base(dbContext)
        {
        }
    }
}
