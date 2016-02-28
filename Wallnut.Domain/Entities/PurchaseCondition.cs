using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wallnut.Domain.Entities
{
    public class PurchaseCondition
    {
        public DateTime DateFirst { get; set; }
        public DateTime DateLast { get; set; }

        public bool IsSmallWholesale { get; set; }
        public bool IsBigShipment { get; set; }
    }
}
