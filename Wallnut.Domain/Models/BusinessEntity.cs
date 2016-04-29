using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("BusinessEntity", Schema="Person")]
    public partial class BusinessEntity
    {
        public BusinessEntity()
        {
            this.BusinessEntityAddresses = new List<BusinessEntityAddress>();
            this.BusinessEntityContacts = new List<BusinessEntityContact>();
            this.PropertyToEntities = new List<PropertyToEntity>();
        }

 
        [Column("BusinessEntityID")] 
	        public int BusinessEntityID { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<BusinessEntityAddress> BusinessEntityAddresses { get; set; }
        public virtual ICollection<BusinessEntityContact> BusinessEntityContacts { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<PropertyToEntity> PropertyToEntities { get; set; }
        public virtual Role Role { get; set; }
        public virtual Store Store { get; set; }
        public virtual Vendor Vendor { get; set; }
    }
}
