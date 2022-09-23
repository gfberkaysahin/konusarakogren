using EntityLayer;
using EntityLayer.Services;

namespace KonusarakOgren.Service;

public class CommentService:ICommentService
{
    public Task<IEnumerable<Comment>> GetAllComments()
    {
        throw new NotImplementedException();
    }

    public Task<Comment> GetCommentById(uint id)
    {
        throw new NotImplementedException();
    }

    public Task<Comment> CreateComment(Comment newComment)
    {
        throw new NotImplementedException();
    }

    public Task UpdateComment(Comment commentToBeUpdated, Comment comment)
    {
        throw new NotImplementedException();
    }

    public Task DeleteComment(Comment comment)
    {
        throw new NotImplementedException();
    }
}