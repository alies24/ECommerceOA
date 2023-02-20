using ECommerce_OA.Application.Repositories;
using ECommerce_OA.Domain.Entities.Common;
using ECommerceOA.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace ECommerceOA.Persistence.Repositories
{
    public class WriteRepository<T>:IWriteRepository<T>
        where T : CommonEntity, new()
    {
        ECommerceOADbContext _dbContext;
        public WriteRepository(ECommerceOADbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public DbSet<T> Table => _dbContext.Set<T>();

        public async Task<bool> AddAsync(T entity)
        {
            var result = await Table.AddAsync(entity);
            return result.State == EntityState.Added;
        }

        public async Task<bool> AddRangeAsync(List<T> entities)
        {
             await Table.AddRangeAsync(entities);
             return true;
           
        }

        public bool Remove(T entity)
        {
            var result = Table.Remove(entity);
            return result.State == EntityState.Deleted;

        }

        public async Task<bool> Remove(int id)
        {
           var result = await Table.FirstOrDefaultAsync(i => i.Id == id);
            Table.Remove(result);
            return true;
            
            
        }

        public bool RemoveRange(List<T> entities)
        {
            Table.RemoveRange(entities);
            return true;
        }

        public async Task<int> SaveAsync()
        {
            
            return await _dbContext.SaveChangesAsync();
        }

        public bool Update(T entity)
        {
            var result = Table.Update(entity);
            return result.State == EntityState.Modified;
            
        }
    }
}
