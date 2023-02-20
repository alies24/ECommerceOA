using ECommerce_OA.Application.Repositories.OrderRepository;
using ECommerce_OA.Domain.Entities.Concrete;
using ECommerceOA.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceOA.Persistence.Repositories.OrderRepository
{
    public class OrderReadRepository : ReadRepository<Order>, IOrderReadRepository
    {
        public OrderReadRepository(ECommerceOADbContext dbContext) : base(dbContext)
        {
        }
    }
}
