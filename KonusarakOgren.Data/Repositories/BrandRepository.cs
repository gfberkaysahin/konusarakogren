using DataAccessLayer.Concrete;
using EntityLayer;
using EntityLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories;

public class BrandRepository : Repository<Brand>, IBrandRepository
{
    public BrandRepository(DbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Brand>> GetAllBrandsAsync()
    {
        return await Context.Brands.ToListAsync();
    }
    
    private Context Context
    {
        get { return Context as Context; }
    }
    
}