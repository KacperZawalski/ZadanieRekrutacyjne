using Domain.Primitives;

namespace Domain.Entities
{
    public sealed class OrderItem : Entity
    {
        public Product Product { get; private set; }
        public int Amount { get; set; }
        public OrderItem(Guid id, Product product, int amount) : base(id)
        {
            Product = product;
            Amount = amount;
        }
        public OrderItem(Product product, int amount)
        {
            Product = product;
            Amount = amount;
        }
        /// <summary>
        /// EF constructor
        /// </summary>
        private OrderItem() { }
    }
}
