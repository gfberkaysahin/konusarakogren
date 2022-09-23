using EntityLayer;
using EntityLayer.Services;

namespace KonusarakOgren.Service;

public class BrandService:IBrandService
{
    private readonly IUnitOfWork _unitOfWork;

    public BrandService(IUnitOfWork unitOfWork)
    {
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Brand>> GetAllABrands()
    {
        return await _unitOfWork.Brands.GetAllAsync();
    }

    public async Task<Brand> GetBrandById(uint id)
    {
        return await _unitOfWork.Brands.GetByIdAsync(id);
    }

    public async Task<Brand> CreateBrand(Brand newBrand)
    {
        await _unitOfWork.Brands.AddAsync(newBrand);

        return newBrand;
    }

    public async Task UpdateBrand(Brand brandToBeUpdated, Brand brand)
    {
        throw new NotImplementedException();
    }

    public async Task DeleteBrand(Brand brand)
    {
        _unitOfWork.Brands.Remove(brand);

        await _unitOfWork.CommitAsync();
    }
}