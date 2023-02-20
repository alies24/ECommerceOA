using ECommerce_OA.Application.Repositories.CustomerRepository;
using ECommerce_OA.Domain.Entities.Concrete;
using ECommerceOA.Persistence.Contexts;

namespace ECommerceOA.Persistence.Repositories.CustomerRepository
{
    public class CustomerReadRepository : ReadRepository<Customer>, ICustomerReadRepository
    {
        public CustomerReadRepository(ECommerceOADbContext dbContext) : base(dbContext)
        {
        }
    }
}
