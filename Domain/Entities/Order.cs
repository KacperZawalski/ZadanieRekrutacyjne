using Domain.Primitives;

namespace Domain.Entities
{
    public sealed class Order : Entity
    {
        public List<OrderItem> Items { get; } = [];
    }
}
