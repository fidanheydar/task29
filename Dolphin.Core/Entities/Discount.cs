using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolphin.Core.Entities
{
    public class Discount
    {
        public int DiscountId { get; set; }
        public string DiscountType { get; set; } // Percentage, FixedAmount, Product, Category, Quantity, DateBased
        public decimal DiscountValue { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
