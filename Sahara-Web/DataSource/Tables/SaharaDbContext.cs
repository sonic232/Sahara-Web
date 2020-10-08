using Microsoft.EntityFrameworkCore;
using SaharaWeb.DataSource.Models;

namespace SaharaWeb.DataSource.Tables
{
    public class SaharaDbContext : DbContext
    {
        public SaharaDbContext(DbContextOptions<SaharaDbContext> options) : base(options) {
            
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
