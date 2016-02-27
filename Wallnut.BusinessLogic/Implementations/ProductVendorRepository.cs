﻿// -----------------------------------------------------------------------
// <copyright file="ProductVendorRepository.cs" company="Co">
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

    /// <summary>
    /// Super class
    /// </summary>
    public class ProductVendorRepository: Repository<ProductVendor>,IProductVendorRepository
    {

        #region Member Variables
        #endregion

        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ProductVendorRepository" /> class.
        /// </summary>
        public ProductVendorRepository(IDbContext context)
            : base(context as DbContext)
        {
        }

        #endregion

        #region Properties
        #endregion

        #region Functions
        #endregion

        #region Enums
        #endregion
    }
}
