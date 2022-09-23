using EntityLayer.Repositories;

namespace EntityLayer;

public interface IUnitOfWork : IDisposable
{
    IBrandRepository Brands { get; }
    IProductRepository Products { get; }
    ICategoryRepository Categories { get; }
    ICommentRepository Comments { get; }
    Task<int> CommitAsync();
}