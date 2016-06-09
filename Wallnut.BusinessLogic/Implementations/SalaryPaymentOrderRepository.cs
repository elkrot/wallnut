﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wallnut.BusinessLogic.Interfaces;
using Wallnut.Domain.Models;
using Wallnut.Domain.Interfaces;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Wallnut.BusinessLogic.Implementations
{
    public class SalaryPaymentOrderRepository : Repository<SalaryPaymentOrder>, ISalaryPaymentOrderRepository
    {
        public SalaryPaymentOrderRepository(IDbContext context)
            : base(context as DbContext)
        {

        }


    }
}

