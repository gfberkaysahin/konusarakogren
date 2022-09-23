namespace EntityLayer.Services;

public interface IOrderService
{
    Task<IEnumerable<Order>> GetAllOrders();
    Task<Order> GetOrderById(uint id);
    Task<Order> CreateOrder(Order newOrder);
    Task UpdateOrder(Order orderToBeUpdated, Order order);
    Task DeleteOrder(Order order);
}