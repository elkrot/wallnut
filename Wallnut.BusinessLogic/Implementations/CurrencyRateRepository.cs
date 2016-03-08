// -----------------------------------------------------------------------
// <copyright file="CurrencyRateRepository.cs" company="Co">
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
    public class CurrencyRateRepository: Repository<CurrencyRate>,ICurrencyRateRepository
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrencyRateRepository" /> class.
        /// </summary>
        public CurrencyRateRepository(IDbContext context)
            : base(context as DbContext)
        {

        }


    }
}
