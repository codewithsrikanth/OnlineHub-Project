using OnlineHub.Entities;

namespace OnelineHub.Repositories.Interfaces
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetUserOrders(int userId);
    }
}
