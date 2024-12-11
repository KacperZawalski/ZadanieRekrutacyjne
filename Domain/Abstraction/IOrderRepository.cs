using Domain.Entities;

namespace Domain.Abstraction
{
    public interface IOrderRepository
    {
        public Order GetOrderById(Guid orderId);
    }
}
