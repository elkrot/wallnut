using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace CloneDomain.Models
{
    [Table("Currency", Schema="Sales")]
    public partial class Currency
    {
        public Currency()
        {
            this.CurrencyRates = new List<CurrencyRate>();
            this.CurrencyRates1 = new List<CurrencyRate>();
        }

 
        [Column("CurrencyCode")] 
	        public string CurrencyCode { get; set; }
 
        [Column("Name")] 
	        public string Name { get; set; }
 
        [Column("ModifiedDate")] 
	        public System.DateTime ModifiedDate { get; set; }
 
        [Column("IsSysRow")] 
	        public bool IsSysRow { get; set; }
        public virtual ICollection<CurrencyRate> CurrencyRates { get; set; }
        public virtual ICollection<CurrencyRate> CurrencyRates1 { get; set; }
    }
}
