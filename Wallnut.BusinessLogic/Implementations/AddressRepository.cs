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
    public class AddressRepository : Repository<Address>, IAddressRepository
    {

        #region Member Variables
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressRepository" /> class.
        /// </summary>
        public AddressRepository(IDbContext context)
            : base(context as DbContext)
        {

        }
        #endregion

        public new IEnumerable<Address> GetAll()
        {
            return Context.Set<Address>().Include("StateProvince").ToList();
        }


    }
}
