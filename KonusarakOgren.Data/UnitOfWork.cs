using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using EntityLayer;
using EntityLayer.Repositories;

namespace DataAccessLayer;

public class UnitOfWork:IUnitOfWork
{
    private readonly Context _context;
    private BrandRepository _brandRepository;
    private ProductRepository _productRepository;
    private CategoryRepository _categoryRepository;
    private CommentRepository _commentRepository;
    private OrderRepository _orderRepository;
    private OrderDetailsRepository _orderDetailsRepository;

    public UnitOfWork(Context context)
    {
        this._context = context;
    }

    public IBrandRepository Brands => _brandRepository = _brandRepository ?? new BrandRepository(_context);
    public IProductRepository Products => _productRepository = _productRepository ?? new ProductRepository(_context);
    public ICategoryRepository Categories => _categoryRepository = _categoryRepository ?? new CategoryRepository(_context);
    public ICommentRepository Comments => _commentRepository = _commentRepository ?? new CommentRepository(_context);
    public IOrderRepository Orders => _orderRepository = _orderRepository ?? new OrderRepository(_context);
    public IOrderDetails OrderDetails => _orderDetailsRepository = _orderDetailsRepository ?? new OrderDetailsRepository(_context);
        

    public void Dispose()
    {
        throw new NotImplementedException();
    }

    public async Task<int> CommitAsync()
    {
        return await _context.SaveChangesAsync();
    }
}