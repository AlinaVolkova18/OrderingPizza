using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DAL.Entity
{
    public partial class PizzaDB : DbContext
    {
        public PizzaDB()
            : base("name=PizzaDB")
        {
        }

        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Client> Client { get; set; }
        public virtual DbSet<Composition_string> Composition_string { get; set; }
        public virtual DbSet<Ingredient> Ingredient { get; set; }
        public virtual DbSet<Order> Order { get; set; }
        public virtual DbSet<Order_string> Order_string { get; set; }
        public virtual DbSet<Pizza> Pizza { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Admin>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Phone)
                .IsUnicode(false);

            modelBuilder.Entity<Client>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Composition_string>()
                .Property(e => e.Count)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Ingredient>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Ingredient>()
                .Property(e => e.Cost)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Ingredient>()
                .HasMany(e => e.Composition_string)
                .WithRequired(e => e.Ingredient)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.List)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Date_Time)
                .IsUnicode(false);

            modelBuilder.Entity<Order>()
                .Property(e => e.Data)
                .IsUnicode(false);

            modelBuilder.Entity<Order_string>()
                .Property(e => e.Count)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Order_string>()
                .Property(e => e.Cost)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Order_string>()
                .HasOptional(e => e.Order)
                .WithRequired(e => e.Order_string);

            modelBuilder.Entity<Pizza>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Pizza>()
                .Property(e => e.Cost)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Pizza>()
                .Property(e => e.Composition)
                .IsUnicode(false);

            modelBuilder.Entity<Pizza>()
                .Property(e => e.Size)
                .IsUnicode(false);

            modelBuilder.Entity<Pizza>()
                .Property(e => e.Picture)
                .IsUnicode(false);

            modelBuilder.Entity<Status>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Login)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasOptional(e => e.Admin)
                .WithRequired(e => e.User);

            modelBuilder.Entity<User>()
                .HasOptional(e => e.Client)
                .WithRequired(e => e.User);
        }
    }
}
