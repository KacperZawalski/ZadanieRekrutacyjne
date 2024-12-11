using Domain.Primitives;

namespace Domain.Entities
{
    public sealed class Product : Entity
    {
        public Product(Guid id, string name, decimal price) : base(id)
        {
            Name = name;
            Price = price;
        }
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; private set; } = string.Empty;
        public decimal Price { get; private set; }
    }
}
