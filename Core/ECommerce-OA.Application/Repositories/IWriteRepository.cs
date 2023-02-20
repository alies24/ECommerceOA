using ECommerce_OA.Domain.Entities.Abstract;
using ECommerce_OA.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_OA.Application.Repositories
{
    public interface IWriteRepository<T> : IRepository<T>
        where T: CommonEntity, new()
    {
        Task<bool> AddAsync(T entity);
        Task<bool> AddRangeAsync(List<T> entities);
        bool Update(T entity);
        bool Remove(T entity);
        Task<bool> Remove(int id);
        bool RemoveRange(List<T> entities);
        Task<int> SaveAsync();

    }
}
