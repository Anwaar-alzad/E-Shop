using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_shopSystem;

public class ShippingAdressConfigure
{
    public void Configure(EntityTypeBuilder<ShippingAddress> builder)
    {
        builder.ToTable("ShippingAddresses");
        builder.HasKey(s => s.Id);
        builder.Property(s => s.City).IsRequired().HasMaxLength(10);
        builder.Property(s => s.PostalCode).IsRequired().HasMaxLength(20);
        builder.Property(s => s.State).IsRequired().HasMaxLength(20);
        builder.Property(s => s.StreetAddress).IsRequired().HasMaxLength(20);


    }
}
