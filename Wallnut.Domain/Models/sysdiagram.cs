using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("sysdiagrams")]
    public partial class sysdiagram
    {
 
        [Column("name")] 
	        public string name { get; set; }
 
        [Column("principal_id")] 
	        public int principal_id { get; set; }
 
        [Column("diagram_id")] 
	        public int diagram_id { get; set; }
 
        [Column("version")] 
	        public Nullable<int> version { get; set; }
 
        [Column("definition")] 
	        public byte[] definition { get; set; }
    }
}
