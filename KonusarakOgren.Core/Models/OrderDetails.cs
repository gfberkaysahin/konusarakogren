using System.ComponentModel.DataAnnotations;

namespace EntityLayer;

public class OrderDetails
{
    [Key]
    public uint ID { get; set; }

    public uint OrderID { get; set; }
    public Order Order { get; set; }
    public uint ProductID { get; set; }
    public Product Product { get; set; }

    public string UserID { get; set; }
    public ApplicationUser ApplicationUser { get; set; }
    public double Price { get; set; }
}