
using Application.Abstraction;
using Domain.Entities;

namespace Application.Products.Commands
{
    public sealed record AddProductsCommand(List<Product> products) : ICommand
    {
        public List<Product> Products = products;
    }
}
