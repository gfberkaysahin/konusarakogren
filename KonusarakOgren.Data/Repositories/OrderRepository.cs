using EntityLayer;
using EntityLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories;

public class OrderRepository: Repository<Order>, IOrderRepository
{
    public OrderRepository(DbContext context) : base(context)
    {
    }
}