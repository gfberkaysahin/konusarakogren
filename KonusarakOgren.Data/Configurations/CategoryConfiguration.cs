using EntityLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configurations;

public class CategoryConfiguration: IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder
            .HasKey(a => a.ID);

        builder
            .Property(m => m.ID)
            .UseIdentityColumn();

        builder
            .Property(m => m.Name)
            .IsRequired()
            .HasMaxLength(50);
        
        builder
            .Property(m => m.Description)
            .IsRequired()
            .HasMaxLength(500);

        builder
            .ToTable("Categories");
    }
}