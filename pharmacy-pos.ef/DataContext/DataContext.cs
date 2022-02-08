using Microsoft.EntityFrameworkCore;
using pharmacy_pos.ef.Entities.CurrentStock;
using pharmacy_pos.ef.Entities.Product;
using pharmacy_pos.ef.Entities.ProductBatch;
using pharmacy_pos.ef.Entities.ProductPurchase;
using pharmacy_pos.ef.Entities.ProductType;
using pharmacy_pos.ef.Entities.PurchaseItem;
using pharmacy_pos.ef.Entities.SaleHistory;
using pharmacy_pos.ef.Entities.SaleItem;
using pharmacy_pos.ef.Entities.Supplier;

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

        public DbSet<CurrentStock> CurrentStock { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductBatch> ProductBatch { get; set; }
        public DbSet<ProductPurchase> ProductPurchase { get; set; }
        public DbSet<ProductType> ProductType { get; set; }
        public DbSet<PurchaseItem> PurchaseItem { get; set; }
        public DbSet<SaleHistory> SaleHistory { get; set; }
        public DbSet<SaleItem> SaleItem { get; set; }
        public DbSet<Supplier> Supplier { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
