using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("PropertyToEntity", Schema="Person")]
    public partial class PropertyToEntity
    {
 
        [Column("PropertyCode")] 
	        public string PropertyCode { get; set; }
 
        [Column("BusinesEntityID")] 
	        public int BusinesEntityID { get; set; }
 
        [Column("PropertyValue")] 
	        public string PropertyValue { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual BusinessEntity BusinessEntity { get; set; }
        public virtual Property Property { get; set; }
    }
}
