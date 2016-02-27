using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("ErrorLog")]
    public partial class ErrorLog
    {
 
        [Column("ErrorLogID")] 
	        public int ErrorLogID { get; set; }
 
        [Column("ErrorTime")] 
	        public System.DateTime ErrorTime { get; set; }
 
        [Column("UserName")] 
	        public string UserName { get; set; }
 
        [Column("ErrorNumber")] 
	        public int ErrorNumber { get; set; }
 
        [Column("ErrorSeverity")] 
	        public Nullable<int> ErrorSeverity { get; set; }
 
        [Column("ErrorState")] 
	        public Nullable<int> ErrorState { get; set; }
 
        [Column("ErrorProcedure")] 
	        public string ErrorProcedure { get; set; }
 
        [Column("ErrorLine")] 
	        public Nullable<int> ErrorLine { get; set; }
 
        [Column("ErrorMessage")] 
	        public string ErrorMessage { get; set; }
    }
}
