using Microsoft.EntityFrameworkCore;

namespace E_shopSystem;

public class ApplicationDBContext : DbContext
{
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<PaymentInformation> PaymentInformation { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<ShippingAddress> ShippingAddresses { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=localhost,1433;Database=E-ShopDB;User Id=SA;Password=;Encrypt=False;TrustServerCertificate=True;");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.ApplyConfiguration();
    }
}
