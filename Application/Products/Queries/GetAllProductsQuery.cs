using Application.Abstraction;
using Domain.Entities;

namespace Application.Products.Queries
{
    public class GetAllProductsQuery : IQuery<List<Product>>
    {
    }
}
