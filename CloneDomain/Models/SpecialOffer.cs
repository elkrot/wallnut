using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace CloneDomain.Models
{
    [Table("SpecialOffer", Schema="Sales")]
    public partial class SpecialOffer
    {
        public SpecialOffer()
        {
            this.SpecialOfferProducts = new List<SpecialOfferProduct>();
        }

 
        [Column("SpecialOfferID")] 
	        public int SpecialOfferID { get; set; }
 
        [Column("Description")] 
	        public string Description { get; set; }
 
        [Column("DiscountPct")] 
	        public decimal DiscountPct { get; set; }
 
        [Column("Type")] 
	        public string Type { get; set; }
 
        [Column("Category")] 
	        public string Category { get; set; }
 
        [Column("StartDate")] 
	        public System.DateTime StartDate { get; set; }
 
        [Column("EndDate")] 
	        public System.DateTime EndDate { get; set; }
 
        [Column("MinQty")] 
	        public int MinQty { get; set; }
 
        [Column("MaxQty")] 
	        public Nullable<int> MaxQty { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<SpecialOfferProduct> SpecialOfferProducts { get; set; }
    }
}
