using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace CloneDomain.Models
{
    [Table("ShipMethod", Schema="Purchasing")]
    public partial class ShipMethod
    {
        public ShipMethod()
        {
            this.PurchaseOrderHeaders = new List<PurchaseOrderHeader>();
            this.SalesOrderHeaders = new List<SalesOrderHeader>();
        }

 
        [Column("ShipMethodID")] 
	        public int ShipMethodID { get; set; }
 
        [Column("Name")] 
	        public string Name { get; set; }
 
        [Column("ShipBase")] 
	        public decimal ShipBase { get; set; }
 
        [Column("ShipRate")] 
	        public decimal ShipRate { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<PurchaseOrderHeader> PurchaseOrderHeaders { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}
