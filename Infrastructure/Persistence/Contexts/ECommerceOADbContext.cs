using ECommerce_OA.Domain.Entities.Common;
using ECommerce_OA.Domain.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceOA.Persistence.Contexts
{
    public class ECommerceOADbContext:DbContext
    { 
        public ECommerceOADbContext(DbContextOptions dbContextOptions):base(dbContextOptions)
        {
           
        }
        

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
             var datas = ChangeTracker.Entries<CommonEntity>();
            foreach (var data in datas)
            {
                
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreatedDate = DateTime.UtcNow,
                    EntityState.Modified => data.Entity.UpdatedTime = DateTime.UtcNow,
                    _ => DateTime.UtcNow

                };
            }

            return await base.SaveChangesAsync(cancellationToken);
        }
    }  

}
