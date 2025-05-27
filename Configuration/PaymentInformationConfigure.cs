using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace E_shopSystem;
public class PaymentInformationConfigure : IEntityTypeConfiguration<PaymentInformation>
{
    public void Configure(EntityTypeBuilder<PaymentInformation> builder)
    {
        builder.ToTable("PaymentInformations");
        builder.HasKey(pi => pi.Id);
        // builder.Property(pi => pi.paymentInformation).IsRequired().HasMaxLength(50);
        builder.Property(pi => pi.ExpirationDate).HasMaxLength(5);
        builder.Property(pi => pi.CVV).HasMaxLength(3);
        builder.Property(pi => pi.CardNumber).HasMaxLength(16);


    }


}