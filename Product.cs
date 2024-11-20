using Microsoft.EntityFrameworkCore;

namespace Inventory.Models 
{
    public class Product
    {
          public int Id { get; set; }
          public string? Name { get; set; }
          public DateTime? ExpirationDate { get; set; }
          public double? Price { get; set; }
          public long? stock {get; set; }
    }

    class ProductDb : DbContext
    {
        public ProductDb(DbContextOptions options) : base(options) { }
        public DbSet<Product> Products { get; set; } = null!;
    }
}