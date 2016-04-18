using System;
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
    public class SpecialOfferProductRepository : Repository<SpecialOfferProduct>, ISpecialOfferProductRepository
    {
        public SpecialOfferProductRepository(IDbContext context)
            : base(context as DbContext)
        {

        }
        new public IEnumerable<SpecialOfferProduct> GetAll()
        {
            return Context.Set<SpecialOfferProduct>().Include("Product")
                .Include("SpecialOffer").ToList();
        }
        new public IEnumerable<SpecialOfferProduct> Find(Expression<Func<SpecialOfferProduct, bool>> predicate)
        {
            return Context.Set<SpecialOfferProduct>().Include("Product")
                .Include("SpecialOffer").Where(predicate);
        }
    }
}
