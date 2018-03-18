using Amajohn.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Amajohn.DAL
{
    public class AmajohnContext : DbContext
    {
        public AmajohnContext() : base("AmajohnContext")
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<MusicCD> MusicCDs { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Track> Tracks { get; set; }

        // Prevents table names from being pluralizes, which is the default. It is a matter of preference.
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }

}
