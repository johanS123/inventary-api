using Microsoft.EntityFrameworkCore;
using MinimalApiEfCore.Models;

namespace MinimalApiEfCore.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Product> Products { get; set; } = null!;
    public DbSet<Entry> Entries { get; set; } = null!;
    public DbSet<Exit> Exits { get; set; } = null!;
    public DbSet<StatusProduct> StatusProducts { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Configuraciones adicionales
        modelBuilder.Entity<Product>()
            .HasOne(p => p.StatusProduct)
            .WithMany(s => s.Products)
            .HasForeignKey(p => p.StatusProductId);

        modelBuilder.Entity<Entry>()
            .HasOne(e => e.Product)
            .WithMany(p => p.Entries)
            .HasForeignKey(e => e.ProductId);

        modelBuilder.Entity<Exit>()
            .HasOne(e => e.Product)
            .WithMany(p => p.Exits)
            .HasForeignKey(e => e.ProductId);
    }
}
