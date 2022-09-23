using EntityLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configurations;

public class OrderDetailsConfiguration: IEntityTypeConfiguration<OrderDetails>
{
    public void Configure(EntityTypeBuilder<OrderDetails> builder)
    {
        builder
            .HasKey(a => a.ID);

        builder
            .Property(m => m.ID)
            .UseIdentityColumn();

        builder
            .Property(m => m.Price)
            .IsRequired();

        builder
            .Property(m => m.OrderID)
            .IsRequired();
        
        builder
            .Property(m => m.ProductID)
            .IsRequired();

        builder
            .Property(m => m.UserID)
            .IsRequired();
        
        
        builder
            .ToTable("OrderDetails");
    }
}