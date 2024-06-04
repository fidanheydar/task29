﻿using Dolphin.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Dolphin.Data.Contexts
{
    public class DolphinDbContext : IdentityDbContext<User>
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<Seller> Sellers { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Slide> Sliders { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Toy> Toys { get; set; }
        public DbSet<ToyCategory> ToyCategories { get; set; }
        public DbSet<ToyImage> ToyImages { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<BasketItem> BasketItems { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Discount> Discounts { get; set; }



        public DolphinDbContext(DbContextOptions<DolphinDbContext> options) : base(options)
        {

        }



    }
}

