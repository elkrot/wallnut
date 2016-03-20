// -----------------------------------------------------------------------
// <copyright file="BusinessEntityAddressRepository.cs" company="Co">
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
    public class BusinessEntityAddressRepository : Repository<BusinessEntityAddress>, IBusinessEntityAddressRepository
    {


        public BusinessEntityAddressRepository(IDbContext context)
            : base(context as DbContext)
        {

        }


        public new IEnumerable<BusinessEntityAddress> GetAll()
        {
            return Context.Set<BusinessEntityAddress>().Include("Address").Include("AddressType").ToList();
        }

        new public IEnumerable<BusinessEntityAddress> Find(Expression<Func<BusinessEntityAddress, bool>> predicate)
        {
            return Context.Set<BusinessEntityAddress>().
                Include("Address").Include("AddressType")
                .Where(predicate);
        }
    }
}
