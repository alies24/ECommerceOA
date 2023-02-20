using ECommerce_OA.Domain.Entities.Abstract;
using ECommerce_OA.Domain.Entities.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_OA.Application.Repositories
{
    public interface IRepository<T>
        where T : CommonEntity, new()
      
    {
        public DbSet<T> Table { get; }
    }
}
