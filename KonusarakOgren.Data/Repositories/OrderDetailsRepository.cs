using EntityLayer;
using EntityLayer.Repositories;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Repositories;

public class OrderDetailsRepository: Repository<OrderDetails>, IOrderDetails
{
    public OrderDetailsRepository(DbContext context) : base(context)
    {
    }
}