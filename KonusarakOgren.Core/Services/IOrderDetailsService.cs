namespace EntityLayer.Services;

public interface IOrderDetailsService
{
    Task<IEnumerable<OrderDetails>> GetAllOrderDetails();
    Task<OrderDetails> GetOrderDetailsById(uint id);
    Task<OrderDetails> CreateOrderDetails(OrderDetails neworderDetails);
    Task UpdateOrderDetails(OrderDetails orderDetailsToBeUpdated, OrderDetails orderDetails);
    Task DeleteOrderDetails(OrderDetails orderDetails);
}