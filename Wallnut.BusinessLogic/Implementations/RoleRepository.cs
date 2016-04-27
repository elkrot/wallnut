// -----------------------------------------------------------------------
// <copyright file="AddressRepository.cs" company="Co">
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

    /// <summary>
    /// Super class
    /// </summary>
    public class RoleRepository : Repository<Role>, IRoleRepository
    {
        public RoleRepository(IDbContext context)
            : base(context as DbContext)
        {

        }

       /* #region GetNewBusinessEntityID
        private int GetNewBusinessEntityID()
        {
            var be = new BusinessEntity();
            be.BusinessEntityID = 0;
            be.ModifiedDate = DateTime.Now;
            Context.Set<Wallnut.Domain.Models.BusinessEntity>().Add(be);
            (Context as DbContext).SaveChanges();
            return be.BusinessEntityID;

        }
        #endregion*/
    }
}
