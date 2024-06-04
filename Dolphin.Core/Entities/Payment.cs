using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolphin.Core.Entities
{
    public class Payment
    {
        public int Amount { get; set; }
        public int OrderId { get; set; }
        public string SessionId { get; set; }
        public string PaymentUrl { get; set; }
        public string StatusCode { get; set; }
        public string OrderDescription { get; set; }
        public string Currency { get; set; }
        public string LanguageCode { get; set; }
    }
}
