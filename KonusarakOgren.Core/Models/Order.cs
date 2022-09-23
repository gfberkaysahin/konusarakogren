using System.ComponentModel.DataAnnotations;

namespace EntityLayer;

public class Order
{
    [Key]
    public uint ID { get; set; }

    public string UserID { get; set; }
    public ApplicationUser ApplicationUser { get; set; }
    public double TotalPrice { get; set; }
    public DateTime CreatedDate { get; set; }
}