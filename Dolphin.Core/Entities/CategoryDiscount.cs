using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolphin.Core.Entities
{
    public class CategoryDiscount
    {
        public int CategoryDiscountId { get; set; }
        public int DiscountId { get; set; }
        public int CategoryId { get; set; }
    }
}
