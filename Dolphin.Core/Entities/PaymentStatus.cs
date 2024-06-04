using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolphin.Core.Entities
{
    public class PaymentStatus
    {
        public int OrderId { get; set; }

        public string StatusCode { get; set; }
        public string State { get; set; }
    }
}
