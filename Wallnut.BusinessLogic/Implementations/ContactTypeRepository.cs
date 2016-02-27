using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wallnut.BusinessLogic.Interfaces;
using Wallnut.Domain.Models;
using Wallnut.Domain.Interfaces;
using System.Data.Entity;

namespace Wallnut.BusinessLogic.Implementations
{
    public class ContactTypeRepository : Repository<ContactType>, IContactTypeRepository
    {
                #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="AddressRepository" /> class.
        /// </summary>
        public ContactTypeRepository(IDbContext context)
            : base(context as DbContext)
        {

        }
        #endregion
    }
}
