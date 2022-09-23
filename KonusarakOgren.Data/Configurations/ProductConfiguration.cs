using EntityLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configurations;

public class ProductConfiguration: IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder
            .HasKey(a => a.Id);

        builder
            .Property(m => m.Id)
            .UseIdentityColumn();

        builder
            .Property(m => m.Name)
            .IsRequired()
            .HasMaxLength(50);

        builder
            .Property(m => m.CategoryId)
            .IsRequired(); 
        
        builder
            .Property(m => m.BrandId)
            .IsRequired();
        
        builder
            .Property(m => m.Description)
            .IsRequired()
            .HasMaxLength(500);
        
        builder
            .ToTable("Products");
    }
}