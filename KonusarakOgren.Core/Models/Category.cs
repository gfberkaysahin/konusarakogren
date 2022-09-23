using System.ComponentModel.DataAnnotations;

namespace EntityLayer;

public class Category
{
    [Key] 
    public uint ID { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
}