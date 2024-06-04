﻿
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
    public class Book : BaseEntity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public double PurchasePrice { get; set; }
        [Required]
        public double preDiscount { get; set; }
        public double postDiscount { get; set; }
        [Required]
        public int StockCount { get; set; }
        
        public string? Image { get; set; }
        public bool inStock { get; set; }
        public bool? IsFame { get; set; }

        public string? Description { get; set; }

        public int PageCount { get; set; }
        public int Year { get; set; }
        public Seller? Seller { get; set; }
        public Publisher? Publisher { get; set; }
        public Author? Author { get; set; }
        public Language? Language { get; set; }
        public List<BookCategory>? BookCategories { get; set; }
        public ProductType? ProductType { get; set; }

        public int? LanguageId { get; set; }
        public int? SellerId { get; set; }
        public int? AuthorId { get; set; }
        public int? PublisherId { get; set; }
        public int? ProductTypeId { get; set; }
        [NotMapped]
        public List<int>? CategoryIds { get; set; }
    }
}
