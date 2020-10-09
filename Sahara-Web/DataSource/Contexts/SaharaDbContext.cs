using Microsoft.EntityFrameworkCore;
using SaharaWeb.DataSource.Models;
using System;

namespace SaharaWeb.DataSource.Contexts
{
    public class SaharaDbContext : DbContext
    {
        public SaharaDbContext(DbContextOptions<SaharaDbContext> options) : base(options) {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasKey("Id");
            modelBuilder.Entity<Category>()
                .HasKey("Id");

            modelBuilder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey("CategoryId");

            modelBuilder.Entity<Category>().HasData(TestData.SeedCategories);
            modelBuilder.Entity<Product>().HasData(TestData.SeedProducts);
        }
    }
}
