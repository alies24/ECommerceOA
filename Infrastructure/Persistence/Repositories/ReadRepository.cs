using ECommerce_OA.Application.Repositories;
using ECommerce_OA.Domain.Entities.Abstract;
using ECommerce_OA.Domain.Entities.Common;
using ECommerceOA.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceOA.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T>
        where T : CommonEntity, new()
    {
        ECommerceOADbContext _dbContext;
        public ReadRepository(ECommerceOADbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public DbSet<T> Table => _dbContext.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var result = Table.AsQueryable();
            if (!tracking)
            {
               result = result.AsNoTracking();
            }
            return result;
        }

        public async Task<T> GetByIdAsync(int id, bool tracking = true)
        {
            var result =  Table.AsQueryable();
            if (!tracking)
            {
                result = result.AsNoTracking();
            }
            return await result.FirstAsync(i => i.Id == id);
           
        } 
        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var result = Table.AsQueryable();
            if (!tracking)
            {
                result = result.AsNoTracking();
            }
            return await result.FirstOrDefaultAsync(method);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var result  = Table.Where(method);
            if (!tracking)
            {
                result = result.AsNoTracking();
            }
            return result;
        }
    }
}
