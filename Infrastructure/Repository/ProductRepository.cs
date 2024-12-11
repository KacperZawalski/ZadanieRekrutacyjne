using Domain.Abstraction;
using Domain.Entities;

namespace Infrastructure.Repository
{
    public sealed class ProductRepository : IProductRepository
    {
        private readonly AppDbContext _db;
        public ProductRepository(AppDbContext appDbContext)
        {
            _db = appDbContext;
        }
        public List<Product> GetProducts()
        {
            return _db.Products.ToList();
        }
        public void AddProducts(List<Product> products)
        {
            _db.Products.AddRange(products);
            _db.SaveChanges();
        }
        public void AddProduct(Product product)
        {
            _db.Products.Add(product);
            _db.SaveChanges();
        }
    }
}
