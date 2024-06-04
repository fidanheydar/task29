using Dolphin.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolphin.Core.Entities
{
    public class OrderItem:BaseEntity
    {
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public List<OrderProduct>? orderProducts { get; set; }
        public string Status { get; set; } = "Yoldadır";
        public decimal TotalPrice { get; set; }
    }
}
