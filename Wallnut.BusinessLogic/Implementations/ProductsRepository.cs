using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wallnut.Domain.Models;
using Wallnut.BusinessLogic.Interfaces;
using Wallnut.Domain.Interfaces;
using System.Data.Entity;

namespace Wallnut.BusinessLogic.Implementations
{
   public class ProductsRepository : Repository<Product>, IProductsRepository
    {

       public ProductsRepository(IDbContext context)
            : base(context as DbContext)
        {
        }
    }
}
