namespace EntityLayer.Services;

public interface ICategoryService
{
    Task<IEnumerable<Category>> GetAllCategories();
    Task<Category> GetCategoryById(uint id);
    Task<Category> CreateCategory(Category newCategory);
    Task UpdateCategory(Category categoryToBeUpdated, Category category);
    Task DeleteCategory(Category category);
}