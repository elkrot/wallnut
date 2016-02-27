using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Wallnut.Domain.Models
{
   public partial class ProductInventory
    {
        [NotMapped]
        public string ProductName { get { return Product.Name; } }



        [NotMapped]
        public string LocationName { get { return Location.Name; } } 
    }
}
