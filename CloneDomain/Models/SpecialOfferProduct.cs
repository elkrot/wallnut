using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace CloneDomain.Models
{
    [Table("SpecialOfferProduct", Schema="Sales")]
    public partial class SpecialOfferProduct
    {
        public SpecialOfferProduct()
        {
            this.SalesOrderDetails = new List<SalesOrderDetail>();
        }

 
        [Column("SpecialOfferID")] 
	        public int SpecialOfferID { get; set; }
 
        [Column("ProductID")] 
	        public int ProductID { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<SalesOrderDetail> SalesOrderDetails { get; set; }
        public virtual SpecialOffer SpecialOffer { get; set; }
    }
}
