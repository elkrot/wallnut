﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wallnut.BusinessLogic.Interfaces;
using Wallnut.Domain.Models;
using Wallnut.Domain.Interfaces;
using System.Data.Entity;

namespace Wallnut.BusinessLogic.Implementations
{
    public class PasswordRepository: Repository<Password>,IPasswordRepository
    {
        public PasswordRepository(IDbContext context)
            : base(context as DbContext)
        {
        }
    }
}
