namespace E_shopSystem;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

public class ReviewConfigure
{
    public void Configure(EntityTypeBuilder<Review> builder)
    {
        builder.ToTable("Reviews");
        builder.HasKey(r => r.Id);

        builder.Property(r => r.Rating).IsRequired();
        builder.Property(r => r.Comment).HasMaxLength(500);

        builder.HasOne(r => r.Customer)
               .WithMany(c => c.Reviews)
               .HasForeignKey(r => r.CustomerId);

        builder.HasOne(r => r.Product)
               .WithMany(p => p.Reviews)
               .HasForeignKey(r => r.ProductId);
    }
}
