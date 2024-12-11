using Application.Products.Commands;
using Application.Products.Queries;
using Domain.Entities;
using Infrastructure;
using Infrastructure.Repository;
using Presentation.View;

namespace ZadanieRekrutacyjne
{
    public class ZadanieRekrutacyjne
    {
        private readonly AppDbContext _dbContext = new AppDbContext();
        public ZadanieRekrutacyjne()
        {
            Initialize();
        }
        public void Initialize()
        {
            var defaultProducts = new List<Product>()
            {
                new Product("Laptop", 2500),
                new Product("Klawiatura", 120),
                new Product("Mysz", 90),
                new Product("Monitor", 1000),
                new Product("Kaczka debuggująca", 66),
            };
            new AddProductsCommandHandler(new ProductRepository(_dbContext))
                .Handle(new AddProductsCommand(defaultProducts));


            var products =
                new GetAllProductsQueryHandler(new ProductRepository(_dbContext))
                .Handle(new GetAllProductsQuery());
            new MenuView().DisplayMenu(products);
        }
    }
}
