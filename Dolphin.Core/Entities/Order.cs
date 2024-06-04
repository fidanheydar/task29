﻿
using Dolphin.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolphin.Core.Entities
{
    public class Order:BaseEntity
    {
        public string UserId { get; set; }
        public User User { get; set; }
        public List<OrderItem>? OrderItems { get; set; }
    }
}
