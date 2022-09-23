using EntityLayer;
using EntityLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories;

public class ProductRepository: Repository<Product>, IProductRepository
{
    public ProductRepository(DbContext context) : base(context)
    {
    }
}