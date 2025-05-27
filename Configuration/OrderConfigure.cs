using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_shopSystem;
public class OrderConfigure : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder.ToTable("Orders");
        builder.HasKey(o => o.Id);

        builder.HasOne(o => o.Customer)
               .WithMany(c => c.Orders)
               .HasForeignKey(o => o.CustomerId);

        builder.HasOne(o => o.ShippingAddress)
               .WithOne(s => s.Order)
               .HasForeignKey<ShippingAddress>(s => s.OrderId);

        builder.HasOne(o => o.PaymentInformation)
               .WithOne(p => p.Order)
               .HasForeignKey<PaymentInformation>(p => p.OrderId);
    }
}