using Dolphin.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dolphin.Core.Entities
{
    public class Seller:BaseEntity
    {
        [Required]
        public string Name { get; set; }
        public int? Follower { get; set; }
        public string? Image { get; set; }
        public double? Ranking { get; set; }
        public List<Book>? Books { get; set; }

    }
}
