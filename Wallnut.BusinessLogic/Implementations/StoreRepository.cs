// -----------------------------------------------------------------------
// <copyright file="StoreRepository.cs" company="Co">
// Copyright Kolodiyazjny Sergey
// </copyright>
// -----------------------------------------------------------------------
namespace Wallnut.BusinessLogic.Implementations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Wallnut.BusinessLogic.Interfaces;
    using Wallnut.Domain.Models;
    using Wallnut.Domain.Interfaces;
    using System.Data.Entity;
    using System.Linq.Expressions;

    /// <summary>
    /// Super class
    /// </summary>
    public class StoreRepository : Repository<Store>, IStoreRepository
    {
        public StoreRepository(IDbContext context)
            : base(context as DbContext)
        {

        }

        new public IEnumerable<Store> Find(Expression<Func<Store, bool>> predicate)
       {
           return Context.Set<Store>()
               .Where(predicate);
               
       }
    }
}
