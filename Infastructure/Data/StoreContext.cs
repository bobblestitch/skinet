using Microsoft.EntityFrameworkCore;
using Core.Entities;
using System.Reflection;

namespace Infastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductBrand> ProductBrands { get; set; }
        public DbSet<ProductType> ProductTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Include the custom EF DB config from the config folder
            // Uses all IEntityTypeConfiguration<x> from an assembly
            // Infastructure/Data/Config/ProductConfiguration
            // Doing this keeps the entities "clean", with the markup/config in it's own section.
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}