using Store.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace Store.Models.DataContext
{
    public class StoreDB : DbContext
    {
        public StoreDB() : base("DefaultConnection") { }

        public DbSet<Products> Products { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
    }
}