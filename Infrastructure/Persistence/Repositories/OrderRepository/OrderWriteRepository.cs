using ECommerce_OA.Application.Repositories.OrderRepository;
using ECommerce_OA.Domain.Entities.Concrete;
using ECommerceOA.Persistence.Contexts;

namespace ECommerceOA.Persistence.Repositories.OrderRepository
{
    public class OrderWriteRepository : WriteRepository<Order>, IOrderWriteRepository
    {
        public OrderWriteRepository(ECommerceOADbContext dbContext) : base(dbContext)
        {
        }
    }
}
