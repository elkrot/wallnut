using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wallnut.Domain.Models;
using Wallnut.BusinessLogic.Interfaces;
using Wallnut.Domain.Interfaces;
using System.Data.Entity;

namespace Wallnut.BusinessLogic.Implementations
{
    public class BusinessEntityRepository : Repository<BusinessEntity>, IBusinessEntityRepository
    {
        public BusinessEntityRepository(IDbContext context)
            : base(context as DbContext)
        {
        }

        public int GetNewBusinessEntityID()
        {
            var be = new BusinessEntity();
            be.BusinessEntityID = 0;
            be.ModifiedDate = DateTime.Now;
            Context.Set<Wallnut.Domain.Models.BusinessEntity>().Add(be);
            (Context as DbContext).SaveChanges();
            return be.BusinessEntityID;
        }
    }
}
