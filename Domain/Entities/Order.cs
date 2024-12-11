using Domain.Primitives;

namespace Domain.Entities
{
    public sealed class Order : Entity
    {
        private readonly decimal _twoProductsDiscount = 0.1m;
        private readonly decimal _threeProductsDiscount = 0.2m;
        private readonly decimal _totalExceedsValueDiscount = 0.05m;
        private readonly decimal _valueToExceed = 5000m;
        private decimal _total = 0m;

        public List<OrderItem> Items { get; } = [];
        public Order(Guid id, List<OrderItem> items) : base(id)
        {
            Items = items;
        }
        public Order(List<OrderItem> items)
        {
            Items = items;
        }
        public Order()
        { 
        }

        public void AddItem(Product product)
        {
            var orderItem = Items.Find(x => x.Product.Id == product.Id);
            
            if (orderItem == null)
            {
                Items.Add(new OrderItem(product, 1));
            }
            else
            {
                orderItem.Amount++;
            }
        }

        public void RemoveItem(Guid id)
        {
            var orderItem = Items.Find(x => x.Product.Id == id);

            if (orderItem == null)
            {
                return;
            }
            
            orderItem.Amount--;

            if (orderItem.Amount == 0)
            {
                Items.Remove(orderItem);
            }
        }
        public decimal GetTotalPrice()
        {
            _total = Items.Sum(x => x.Amount * x.Product.Price);

            _total -= GetFirstDiscount();
            _total -= GetSecondDiscount();
            
            return _total;
        }

        public decimal GetSecondDiscount()
        {
            decimal discount = 0m;
            if (_total > _valueToExceed)
            {
                discount = _total * _totalExceedsValueDiscount;
            }
            return discount;
        }

        public decimal GetFirstDiscount()
        {
            decimal discount = 0m;

            var sortedProducts = Items.OrderBy(x => x.Product.Price).ToList();

            if (Items.Sum(x => x.Amount) == 2)
            {
                int index = sortedProducts[0].Amount == 1 ? 1 : 0;

                discount = sortedProducts[index].Product.Price * _twoProductsDiscount;
            }
            else if (Items.Sum(x => x.Amount) >= 3)
            {
                discount = sortedProducts[0].Product.Price * _threeProductsDiscount;
            }
            return discount;
        }
    }
}
