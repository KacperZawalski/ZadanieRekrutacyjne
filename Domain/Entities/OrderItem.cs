using Domain.Primitives;

namespace Domain.Entities
{
    public sealed class OrderItem(Product product, int amount) : Entity
    {
        public Product Product { get; private set; } = product;
        public int Amount { get; set; } = amount;
    }
}
