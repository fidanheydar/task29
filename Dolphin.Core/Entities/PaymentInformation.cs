using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolphin.Core.Entities
{
    public class PaymentInformation
    {
        public int OrderId { get; set; }
        public string SessionId { get; set; }
        public string OrderType { get; set; }
        public string State { get; set; }
        public int Amount { get; set; }
        public string OrderDescription { get; set; }
        public int Fee { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? PayDate { get; set; }
    }
}
