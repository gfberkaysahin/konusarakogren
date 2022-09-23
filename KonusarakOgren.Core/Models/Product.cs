using System.ComponentModel.DataAnnotations;

namespace EntityLayer;

public class Product
{
    
    [Key] 
    public uint Id { get; set; }

    public uint BrandId { get; set; }
    public Brand Brand { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Color { get; set; }
    public string Size { get; set; }
    public double Price { get; set; }
    public double DiscountPercante { get; set; }
    public uint CategoryId { get; set; }
    public Category Category { get; set; }
    public DateTime CreatedDate { get; set; }
}