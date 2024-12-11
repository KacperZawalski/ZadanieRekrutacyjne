using Application.Abstraction;
using Domain.Abstraction;
using Domain.Entities;

namespace Application.Products.Queries
{
    public class GetAllProductsQueryHandler : IQueryHandler<GetAllProductsQuery, List<Product>>
    {
        private readonly IProductRepository _repository;
        public GetAllProductsQueryHandler(IProductRepository repository)
        {
            _repository = repository;
        }

        public List<Product> Handle(GetAllProductsQuery query)
        {
            return _repository.GetProducts();
        }
    }
}
