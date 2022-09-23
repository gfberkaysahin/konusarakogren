using EntityLayer;
using EntityLayer.Services;

namespace KonusarakOgren.Service;

public class OrderService:IOrderService
{
    public Task<IEnumerable<Order>> GetAllOrders()
    {
        throw new NotImplementedException();
    }

    public Task<Order> GetOrderById(uint id)
    {
        throw new NotImplementedException();
    }

    public Task<Order> CreateOrder(Order newOrder)
    {
        throw new NotImplementedException();
    }

    public Task UpdateOrder(Order orderToBeUpdated, Order order)
    {
        throw new NotImplementedException();
    }

    public Task DeleteOrder(Order order)
    {
        throw new NotImplementedException();
    }
}