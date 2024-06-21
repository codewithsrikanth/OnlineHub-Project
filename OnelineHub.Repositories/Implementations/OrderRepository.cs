using Microsoft.EntityFrameworkCore;
using OnelineHub.Repositories.Interfaces;
using OnlineHub.Entities;

namespace OnelineHub.Repositories.Implementations
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private AppDbContext appContext
        {
            get
            {
                return _appDbContext as AppDbContext;
            }
        }
        public OrderRepository(DbContext appDbContext) : base(appDbContext)
        {
        }

        public IEnumerable<Order> GetUserOrders(int userId)
        {
            return appContext.Orders
                .Include(o=>o.OrderItems)
                .Where(x=>x.UserId == userId).ToList();
        }
    }
}
