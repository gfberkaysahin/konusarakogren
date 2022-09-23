namespace EntityLayer.Repositories;

public interface IBrandRepository:IRepository<Brand>
{
    Task<IEnumerable<Brand>> GetAllBrandsAsync();
}