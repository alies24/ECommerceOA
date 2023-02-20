﻿using ECommerce_OA.Domain.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_OA.Domain.Entities.Common
{
    public class CommonEntity:IEntity
    {
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
