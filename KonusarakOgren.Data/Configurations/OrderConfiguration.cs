using EntityLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configurations;

public class OrderConfiguration: IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder
            .HasKey(a => a.ID);

        builder
            .Property(m => m.ID)
            .UseIdentityColumn();

        builder
            .Property(m => m.TotalPrice)
            .IsRequired();

        builder
            .Property(m => m.CreatedDate)
            .IsRequired();

        builder
            .Property(m => m.UserID)
            .IsRequired();
        
        
        builder
            .ToTable("Orders");
    }
}