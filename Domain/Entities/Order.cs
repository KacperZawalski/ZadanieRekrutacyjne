using Domain.Primitives;

namespace Domain.Entities
{
    public sealed class Order : Entity
    {
        public List<OrderItem> Items { get; } = [];
        public Order(Guid id, List<OrderItem> items) : base(id)
        {
            Items = items;
        }
        public Order()
        { 
        }
    }
}
