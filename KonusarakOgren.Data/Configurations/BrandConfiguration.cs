using EntityLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configurations;

public class BrandConfiguration: IEntityTypeConfiguration<Brand>
{
    public void Configure(EntityTypeBuilder<Brand> builder)
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
            .ToTable("Brands");
    }
}