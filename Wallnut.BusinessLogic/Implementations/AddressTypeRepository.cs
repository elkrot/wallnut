// -----------------------------------------------------------------------
// <copyright file="AddressTypeRepository.cs" company="Co">
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
    public class AddressTypeRepository: Repository<AddressType>,IAddressTypesRepository
    {


        /// <summary>
        /// Initializes a new instance of the <see cref="AddressTypeRepository" /> class.
        /// </summary>
        public AddressTypeRepository(IDbContext context)
            : base(context as DbContext)
        {

        }


    
    }
}
