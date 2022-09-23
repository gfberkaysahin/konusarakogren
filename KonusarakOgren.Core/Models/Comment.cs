using System.ComponentModel.DataAnnotations;

namespace EntityLayer;

public class Comment
{
    [Key]
    public uint ID { get; set; }

    public uint ProductID { get; set; }
    public Product Product { get; set; }
    public string UserID { get; set; }
    public ApplicationUser ApplicationUser { get; set; }
    public string CommentText { get; set; }
    public DateTime CreatedDate { get; set; }
}