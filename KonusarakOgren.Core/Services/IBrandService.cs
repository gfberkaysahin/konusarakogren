namespace EntityLayer.Services;

public interface IBrandService
{
    Task<IEnumerable<Brand>> GetAllABrands();
    Task<Brand> GetBrandById(uint id);
    Task<Brand> CreateBrand(Brand newBrand);
    Task UpdateBrand(Brand brandToBeUpdated, Brand brand);
    Task DeleteBrand(Brand brand);
}