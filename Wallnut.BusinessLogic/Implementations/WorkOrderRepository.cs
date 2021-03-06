﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wallnut.Domain.Models;
using Wallnut.BusinessLogic.Interfaces;
using Wallnut.Domain.Interfaces;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Wallnut.BusinessLogic.Implementations
{
    public class SpecialOfferRepository : Repository<SpecialOffer>, ISpecialOfferRepository
    {
        public SpecialOfferRepository(IDbContext context)
            : base(context as DbContext)
        {

        }

        new public IEnumerable<SpecialOffer> Find(Expression<Func<SpecialOffer, bool>> predicate)
        {
            return Context.Set<SpecialOffer>().Where(predicate);
        }
    }
}
