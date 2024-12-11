using Domain.Entities;

namespace Domain.Abstraction
{
    public interface IProductRepository
    {
        public List<Product> GetProducts();
        public void AddProduct(Product product);
        public void AddProducts(List<Product> products);
    }
}
