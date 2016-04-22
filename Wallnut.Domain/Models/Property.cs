using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("Property", Schema="Person")]
    public partial class Property
    {
        public Property()
        {
            this.PropertyToEntities = new List<PropertyToEntity>();
        }

 
        [Column("PropertyCode")] 
	        public string PropertyCode { get; set; }
 
        [Column("PropertyTitle")] 
	        public string PropertyTitle { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual ICollection<PropertyToEntity> PropertyToEntities { get; set; }
    }
}
