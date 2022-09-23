using EntityLayer;
using EntityLayer.Services;

namespace KonusarakOgren.Service;

public class CategoryService:ICategoryService
{
    private readonly IUnitOfWork _unitOfWork;

    public CategoryService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public Task<IEnumerable<Category>> GetAllCategories()
    {
        throw new NotImplementedException();
    }

    public async Task<Category> GetCategoryById(uint id)
    {
        return await _unitOfWork.Categories.GetByIdAsync(id);
    }

    public Task<Category> CreateCategory(Category newCategory)
    {
        throw new NotImplementedException();
    }

    public Task UpdateCategory(Category categoryToBeUpdated, Category category)
    {
        throw new NotImplementedException();
    }

    public Task DeleteCategory(Category category)
    {
        throw new NotImplementedException();
    }
}