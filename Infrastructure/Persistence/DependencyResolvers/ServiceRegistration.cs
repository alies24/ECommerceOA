using ECommerceOA.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using ECommerceOA.Persistence.Repositories.CustomerRepository;
using ECommerce_OA.Application.Repositories.CustomerRepository;
using ECommerceOA.Persistence.Repositories.ProductRepository;
using ECommerce_OA.Application.Repositories.ProductRepository;
using ECommerceOA.Persistence.Repositories.OrderRepository;
using ECommerce_OA.Application.Repositories.OrderRepository;
using ECommerceOA.Persistence.Repositories;
using ECommerce_OA.Application.Repositories;

namespace ECommerceOA.Persistence.DependencyResolvers
{
    public static class ServiceRegistration
    {
        public static void AddDependencyResolvers(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddDbContext<ECommerceOADbContext>(options => options.UseNpgsql(@"User ID = postgres; Password = 123456; Host = localhost; Port = 5432; Database = ECommerce;"));
            serviceCollection.AddScoped<ICustomerReadRepository, CustomerReadRepository>();
            serviceCollection.AddScoped<ICustomerWriteRepository, CustomerWriteRepository>();
            serviceCollection.AddScoped<IProductReadRepository, ProductReadRepository>();
            serviceCollection.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            serviceCollection.AddScoped<IOrderReadRepository, OrderReadRepository>();
            serviceCollection.AddScoped<IOrderWriteRepository, OrderWriteRepository>();
            


        }
    }
}
