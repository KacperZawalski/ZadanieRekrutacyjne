using Domain.Abstraction;
using Domain.Entities;

namespace Infrastructure.Repository
{
    public sealed class OrderRepository : IOrderRepository
    {
        private readonly AppDbContext _db;
        public OrderRepository(AppDbContext appDbContext) 
        {
            _db = appDbContext;
        }
        public Order GetOrderById(Guid orderId)
        {
            return _db.Orders.Where(x => x.Id == orderId).First();
        }
    }
}
