using Application.Abstraction;
using Domain.Entities;

namespace Application.Orders.Queries
{
    public sealed record GetOrderByIdQuery(Guid OrderId) : IQuery<Order>;
}
