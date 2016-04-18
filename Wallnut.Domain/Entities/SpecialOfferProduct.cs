using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
   
    public partial class SpecialOfferProduct
    {
        public string ProductName { get {return Product.Name;}  }
        public string SpecialOfferDescription { get { return SpecialOffer.Description; } }
    }
}
