using Domain.Primitives;

namespace Domain.Entities
{
    public sealed class Product : Entity
    {
        public string Name { get; private set; } = string.Empty;
        public decimal Price { get; private set; }
    }
}
