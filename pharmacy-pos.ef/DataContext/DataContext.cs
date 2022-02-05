using Microsoft.EntityFrameworkCore;
using pharmacy_pos.ef.Entities.Product;
using pharmacy_pos.ef.Entities.ProductType;

namespace pharmacy_pos.ef.Data
{
    public class DataContext : DbContext
    {
        public DataContext()
        {

        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<ProductType> ProductType { get; set; }
        public DbSet<Product> Product { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
