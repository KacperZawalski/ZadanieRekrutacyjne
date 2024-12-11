using Application.Abstraction;
using Domain.Abstraction;
using Domain.Entities;

namespace Application.Orders.Queries
{
    public sealed class GetOrderByIdQueryHandler : IQueryHandler<GetOrderByIdQuery, Order>
    {
        private IOrderRepository _orderRepository;
        public GetOrderByIdQueryHandler(IOrderRepository orderRepository) 
        {
            _orderRepository = orderRepository;
        }
        public Order Handle(GetOrderByIdQuery query)
        {
            return _orderRepository.GetOrderById(query.OrderId);
        }
    }
}
