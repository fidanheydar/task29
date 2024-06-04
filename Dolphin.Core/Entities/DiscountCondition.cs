using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolphin.Core.Entities
{
    public class DiscountCondition
    {
        public int ConditionId { get; set; }
        public int DiscountId { get; set; }
        public string ConditionType { get; set; } // MinimumOrderAmount, UserGroup, CouponCode, PaymentMethod
        public string ConditionValue { get; set; }
    }
}
