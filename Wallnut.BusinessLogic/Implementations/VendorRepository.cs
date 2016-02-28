// -----------------------------------------------------------------------
// <copyright file="VendorRepository.cs" company="Co">
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
    public class VendorRepository : Repository<Vendor>, IVendorRepository
    {



        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="VendorRepository" /> class.
        /// </summary>
        public VendorRepository(IDbContext context)
            : base(context as DbContext)
        {

        }

        #endregion


        new public IEnumerable<Vendor> Find(Expression<Func<Vendor, bool>> predicate)
        {
            return Context.Set<Vendor>().Include("BusinessEntity.BusinessEntityAddresses").Where(predicate);
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
     /*   public void SaveVendor(Vendor vendor)
        {
            if (vendor.BusinessEntityID == 0)
            {
                vendor.BusinessEntity.Person.BusinessEntityID = GetNewBusinessEntityID();
                vendor.BusinessEntityID = vendor.BusinessEntity.Person.BusinessEntityID;
                Context.Set<Wallnut.Domain.Models.Vendor>().Add(vendor);
            }
            else
            {
                (Context as DbContext).Entry(vendor).State = System.Data.EntityState.Modified;
            }
            vendor.ModifiedDate = DateTime.Now;
            // (EFDbContext as DbContext).SaveChanges();
        }/*/
    }
}
