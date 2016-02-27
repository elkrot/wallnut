// -----------------------------------------------------------------------
// <copyright file="CustomerRepository.cs" company="Co">
// Copyright Kolodiyazjny Sergey
// </copyright>
// -----------------------------------------------------------------------
namespace Wallnut.BusinessLogic.Implementations
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
        using Wallnut.Domain.Models;
    using Wallnut.BusinessLogic.Interfaces;
    using Wallnut.Domain.Interfaces;
    using System.Data.Entity;
    using System.Linq.Expressions;
    /// <summary>
    /// Super class
    /// </summary>
    public class CustomerRepository: Repository<Customer>,ICustomerRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerRepository" /> class.
        /// </summary>
        public CustomerRepository(IDbContext context)
            : base(context as DbContext)
        {

        }

        new public IEnumerable<Customer> Find(Expression<Func<Customer, bool>> predicate)
        {
            return Context.Set<Customer>().
                Include("SalesTerritory")
                .Include("Person")
                .Include("Store")
                .Where(predicate);
        }

        private int GetNewBusinessEntityID()
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
