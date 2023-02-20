﻿using ECommerce_OA.Application.Repositories.CustomerRepository;
using ECommerce_OA.Domain.Entities.Concrete;
using ECommerceOA.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceOA.Persistence.Repositories.CustomerRepository
{
    public class CustomerWriteRepository : WriteRepository<Customer>, ICustomerWriteRepository
    {
        public CustomerWriteRepository(ECommerceOADbContext dbContext) : base(dbContext)
        {
        }
    }
}
