using DataAccessLayer.Configurations;
using EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete;

public class Context : IdentityDbContext<ApplicationUser>
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "server=DESKTOP-T75IVBN\\SQLEXPRESS;database=KonusarakOgrenDB; integrated security=true;");
    }

    public DbSet<Brand> Brands { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Comment> Comments { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetails> OrderDetails { get; set; }
    public DbSet<Category> Categories { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder
            .ApplyConfiguration(new BrandConfiguration());
        
        builder
            .ApplyConfiguration(new CategoryConfiguration());
        
        builder
            .ApplyConfiguration(new CommentConfiguration());
        
        builder
            .ApplyConfiguration(new OrderConfiguration());
        
        builder
            .ApplyConfiguration(new OrderDetailsConfiguration());
        
        builder
            .ApplyConfiguration(new ProductConfiguration());
        
         builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "1",
                Name = "sysadmin",
                NormalizedName = "SYSADMIN"
            });
         
         builder.Entity<IdentityRole>().HasData(new IdentityRole
         {
             Id = "2",
             Name = "admin",
             NormalizedName = "ADMIN"
         });
         
         builder.Entity<IdentityRole>().HasData(new IdentityRole
         {
             Id = "3",
             Name = "customer",
             NormalizedName = "CUSTOMER"
         });
         
         builder.Entity<Brand>().HasData(new Brand
         {
             Id = 1,
             Name = "Waikiki",
             Description = "Waikiki Eşyaları",
             Status = true
         });
         
         builder.Entity<Brand>().HasData(new Brand
         {
             Id = 2,
             Name = "Apple",
             Description = "Apple Eşyaları",
             Status = true
         });
         
         builder.Entity<Category>().HasData(new Category
         {
             ID = 1,
             Name = "Giyim",
             Description = "Giyim Eşyaları"
         });
         
         builder.Entity<Category>().HasData(new Category
         {
             ID = 2,
             Name = "Teknoloji",
             Description = "Teknoloji Eşyaları"
         });
         
         builder.Entity<Product>().HasData(new Product
         {
             Id = 1,
             Name = "Macbook Pro",
             Description = "Apple Eşyaları",
             BrandId = 2,
             Price = 17000,
             CategoryId= 2,
             Color = "Gri",
             Size = "16 inch",
             CreatedDate = DateTime.Now,
             DiscountPercante = 10
         });
         
         builder.Entity<Product>().HasData(new Product
         {
             Id = 2,
             Name = "Waikiki Tişört",
             Description = "Waikiki Eşyaları",
             BrandId = 1,
             Price = 170,
             CategoryId= 1,
             Color = "Kırmızı",
             Size = "M",
             CreatedDate = DateTime.Now,
             DiscountPercante = 10
         });
         
         builder.Entity<Product>().HasData(new Product
         {
             Id = 3,
             Name = "Waikiki Tişört",
             Description = "Waikiki Eşyaları",
             BrandId = 1,
             Price = 170,
             CategoryId= 1,
             Color = "Kırmızı",
             Size = "XL",
             CreatedDate = DateTime.Now,
             DiscountPercante = 10
         });
         
         builder.Entity<Product>().HasData(new Product
         {
             Id = 4,
             Name = "Waikiki Tişört",
             Description = "Waikiki Eşyaları",
             BrandId = 1,
             Price = 170,
             CategoryId= 1,
             Color = "Kırmızı",
             Size = "L",
             CreatedDate = DateTime.Now,
             DiscountPercante = 10
         });
         
         builder.Entity<Product>().HasData(new Product
         {
             Id = 5,
             Name = "Waikiki Tişört",
             Description = "Waikiki Eşyaları",
             BrandId = 1,
             Price = 170,
             CategoryId= 1,
             Color = "Kırmızı",
             Size = "S",
             CreatedDate = DateTime.Now,
             DiscountPercante = 10
         });
         
            builder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = "22e40406-8a9d-2d82-912c-5d6a640ee696",
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true,
                NameSurname = "Sistem Yöneticisi",
                PasswordHash = "AQAAAAEAACcQAAAAEBnB8oXphFdmCsywKjHsM1T0Rqoy+MUE/X6BTKXc92U7kCDqn3k8JwfkAyO3GjGfuA==",
                SecurityStamp = "G4UWDNIBHRMGKMISDT73JLS7P3EBZMRV",
                ConcurrencyStamp = "15142b86-2dd6-4e0a-8731-0af709f5c26b",
            });
            // Add the user to the admin role
            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "1",
                UserId = "22e40406-8a9d-2d82-912c-5d6a640ee696"
            });

    }
    
}