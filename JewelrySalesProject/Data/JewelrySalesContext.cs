using JewelrySalesProject.Models;
using Microsoft.EntityFrameworkCore;

namespace JewelrySalesProject.Data
{
    public class JewelrySalesContext : DbContext
    {
        public JewelrySalesContext(DbContextOptions<JewelrySalesContext> options) : base(options)
        {
        }

        public DbSet<Sale> Sales { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Showcase> Showcases { get; set; }
        public DbSet<Parcel> Parcels { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sale>().ToTable("Sale");
            modelBuilder.Entity<Product>().ToTable("Product");
            modelBuilder.Entity<Client>().ToTable("Client");
            modelBuilder.Entity<Showcase>().ToTable("Showcase");
            modelBuilder.Entity<Parcel>().ToTable("Parcel");
        }
    }
}
