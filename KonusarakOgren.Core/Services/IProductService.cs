namespace EntityLayer.Services;

public interface IProductService
{
    Task<IEnumerable<Product>> GetAllProducts();
    Task<Product> GetProductById(int id);
    Task<Product> CreateProduct(Product newProduct);
    Task UpdateProduct(Product productToBeUpdated, Product product);
    Task DeleteProduct(Product product);
}