using EntityLayer;
using EntityLayer.Services;

namespace KonusarakOgren.Service;

public class OrderDetailsService:IOrderDetailsService
{
    public Task<IEnumerable<OrderDetails>> GetAllOrderDetails()
    {
        throw new NotImplementedException();
    }

    public Task<OrderDetails> GetOrderDetailsById(uint id)
    {
        throw new NotImplementedException();
    }

    public Task<OrderDetails> CreateOrderDetails(OrderDetails neworderDetails)
    {
        throw new NotImplementedException();
    }

    public Task UpdateOrderDetails(OrderDetails orderDetailsToBeUpdated, OrderDetails orderDetails)
    {
        throw new NotImplementedException();
    }

    public Task DeleteOrderDetails(OrderDetails orderDetails)
    {
        throw new NotImplementedException();
    }
}