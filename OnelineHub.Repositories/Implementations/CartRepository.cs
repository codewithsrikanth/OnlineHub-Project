using Microsoft.EntityFrameworkCore;
using OnelineHub.Repositories.Interfaces;
using OnlineHub.Entities;

namespace OnelineHub.Repositories.Implementations
{
    public class CartRepository : Repository<Cart>, ICartRepository
    {
        private AppDbContext appContext
        {
            get
            {
                return _appDbContext as AppDbContext;
            }
        }

        public CartRepository(DbContext db):base(db)
        {
            
        }
        public Cart GetCart(Guid cartId)
        {
            return appContext.Carts.Include("Items").Where(x=>x.Id == cartId && x.IsActive==true).FirstOrDefault();
        }

        public int DeleteItem(Guid cartId, int itemId)
        {
            throw new NotImplementedException();
        }

        public int UpdateQuanity(Guid cartId, int itemId, int quantity)
        {
            throw new NotImplementedException();
        }

        public int UpdateCart(Guid cartId, int userId)
        {
            throw new NotImplementedException();
        }
    }
}
