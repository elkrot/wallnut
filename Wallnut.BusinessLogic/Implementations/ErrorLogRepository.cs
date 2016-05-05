// -----------------------------------------------------------------------
// <copyright file="ErrorLogRepository.cs" company="Co">
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
    public class ErrorLogRepository : Repository<ErrorLog>, IErrorLogRepository
    {


        public ErrorLogRepository(IDbContext context)
            : base(context as DbContext)
        {

        }


        public new IEnumerable<ErrorLog> GetAll()
        {
            return Context.Set<ErrorLog>().ToList();
        }


    }
}
