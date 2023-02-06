using ECommerceOA.Persistence.Configurations;
using ECommerceOA.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceOA.Persistence.DesignTimeFactory
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<ECommerceOADbContext>
    {
        public ECommerceOADbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<ECommerceOADbContext> dbContextOptionsBuilder = new();
            var result = dbContextOptionsBuilder.UseNpgsql(Configuration.ConfigurationVerification());
            return new ECommerceOADbContext(result.Options);

        }
    }
}
