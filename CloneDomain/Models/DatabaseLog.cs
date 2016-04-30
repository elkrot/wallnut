using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace CloneDomain.Models
{
    [Table("DatabaseLog")]
    public partial class DatabaseLog
    {
 
        [Column("DatabaseLogID")] 
	        public int DatabaseLogID { get; set; }
 
        [Column("PostTime")] 
	        public System.DateTime PostTime { get; set; }
 
        [Column("DatabaseUser")] 
	        public string DatabaseUser { get; set; }
 
        [Column("Event")] 
	        public string Event { get; set; }
 
        [Column("Schema")] 
	        public string Schema { get; set; }
 
        [Column("Object")] 
	        public string Object { get; set; }
 
        [Column("TSQL")] 
	        public string TSQL { get; set; }
 
        [Column("XmlEvent")] 
	        public string XmlEvent { get; set; }
    }
}
