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
    }
}
