using Dolphin.Core.Entities.BaseEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolphin.Core.Entities
{
    public class Author:BaseEntity
    {
        [Required]
        public string FullName { get; set; }
        public int Age { get; set; }
        public string? Image { get; set; }
        public List<Book>? Books { get; set; }
        public bool? IsFame { get; set; }

    }
}
