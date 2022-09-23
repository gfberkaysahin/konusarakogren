using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace EntityLayer;

public class Brand
{
    [Key]
    public uint Id { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
    public bool Status { get; set; }
}