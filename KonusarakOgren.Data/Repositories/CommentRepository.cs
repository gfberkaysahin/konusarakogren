using EntityLayer;
using EntityLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories;

public class CommentRepository: Repository<Comment>, ICommentRepository
{
    public CommentRepository(DbContext context) : base(context)
    {
    }
}