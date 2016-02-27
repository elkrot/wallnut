using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Wallnut.Domain.Models
{
    [Table("CurrencyRate", Schema="Sales")]
    public partial class CurrencyRate
    {
        public CurrencyRate()
        {
            this.SalesOrderHeaders = new List<SalesOrderHeader>();
        }

 
        [Column("CurrencyRateID")] 
	        public int CurrencyRateID { get; set; }
 
        [Column("CurrencyRateDate")] 
	        public System.DateTime CurrencyRateDate { get; set; }
 
        [Column("FromCurrencyCode")] 
	        public string FromCurrencyCode { get; set; }
 
        [Column("ToCurrencyCode")] 
	        public string ToCurrencyCode { get; set; }
 
        [Column("Rate")] 
	        public decimal Rate { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
        public virtual Currency Currency { get; set; }
        public virtual Currency Currency1 { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeaders { get; set; }
    }
}
