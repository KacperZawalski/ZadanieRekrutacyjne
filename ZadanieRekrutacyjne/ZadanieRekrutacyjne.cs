using Application.Products.Commands;
using Application.Products.Queries;
using Domain.Entities;
using Infrastructure;
using Infrastructure.Repository;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Presentation.View;
using ZadanieRekrutacyjne.Validation;

namespace ZadanieRekrutacyjne
{
    public class ZadanieRekrutacyjne
    {
        private readonly AppDbContext _dbContext = new AppDbContext();
        private List<Product> _products;
        private MenuView _menuView = new MenuView();
        private Order _order = new Order();
        public ZadanieRekrutacyjne()
        {
            Initialize();
            while (true)
            {
                HandleInput();
            }
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


            _products =
                new GetAllProductsQueryHandler(new ProductRepository(_dbContext))
                .Handle(new GetAllProductsQuery());

            _menuView.DisplayMenu(_products);
        }
        private void HandleInput()
        {
            var waitForEscKey = new Task(() =>
            {
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }
            });
            waitForEscKey.Start();

            var input = Console.ReadLine();

            if (input == null || !new ChooseProductInputValidation().Validate(input, _products.Count))
            {
                return;
            }

            var productIndex = int.Parse(input[0].ToString()) - 1;
            if (input.EndsWith('r'))
            {
                _order.RemoveItem(_products[productIndex].Id);
            }
            else if (input.EndsWith('a'))
            {
                _order.AddItem(_products[productIndex]);
            }

            _menuView.ClearLastConsoleLine();
        }
    }
}
