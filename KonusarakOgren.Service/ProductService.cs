using EntityLayer;
using EntityLayer.Services;

namespace KonusarakOgren.Service;

public class ProductService:IProductService
{
    private readonly IUnitOfWork _unitOfWork;

    public ProductService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Product>> GetAllProducts()
    {
        return await _unitOfWork.Products.GetAllAsync();
    }

    public Task<Product> GetProductById(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Product> CreateProduct(Product newProduct)
    {
        throw new NotImplementedException();
    }

    public Task UpdateProduct(Product productToBeUpdated, Product product)
    {
        throw new NotImplementedException();
    }

    public Task DeleteProduct(Product product)
    {
        throw new NotImplementedException();
    }
}