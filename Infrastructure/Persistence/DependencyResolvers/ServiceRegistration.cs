using ECommerceOA.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using ECommerceOA.Persistence.Configurations;

namespace ECommerceOA.Persistence.DependencyResolvers
{
    public static class ServiceRegistration
    {
        public static void AddDependencyResolvers(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ECommerceOADbContext>(options => options.UseNpgsql(Configuration.ConfigurationVerification()));
        }
    }
}
