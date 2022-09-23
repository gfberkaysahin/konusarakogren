namespace EntityLayer.Services;

public interface ICommentService
{
    Task<IEnumerable<Comment>> GetAllComments();
    Task<Comment> GetCommentById(uint id);
    Task<Comment> CreateComment(Comment newComment);
    Task UpdateComment(Comment commentToBeUpdated, Comment comment);
    Task DeleteComment(Comment comment);
}