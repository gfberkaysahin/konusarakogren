using EntityLayer;
using EntityLayer.Repositories;
using EntityLayer.Services;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories;

public class CategoryRepository: Repository<Category>, ICategoryRepository
{
    public CategoryRepository(DbContext context) : base(context)
    {
    }
}