using EntityLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccessLayer.Configurations;

public class CommentConfiguration: IEntityTypeConfiguration<Comment>
{
    public void Configure(EntityTypeBuilder<Comment> builder)
    {
        builder
            .HasKey(a => a.ID);

        builder
            .Property(m => m.ID)
            .UseIdentityColumn();

        builder
            .Property(m => m.CommentText)
            .IsRequired()
            .HasMaxLength(50);

        builder
            .Property(m => m.ProductID)
            .IsRequired();

        builder
            .Property(m => m.UserID)
            .IsRequired();
        
        
        builder
            .ToTable("Comments");
    }
}