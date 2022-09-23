namespace KonusarakOgrenUILayer.DTO;

public class ProductListDTO
{
    public uint ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Color { get; set; }
    public string Size { get; set; }
    public double Price { get; set; }
    public double DiscountPercante { get; set; }
    public DateTime CreatedDate { get; set; }
    public string BrandName { get; set; }
    public string CategoryName { get; set; }
}