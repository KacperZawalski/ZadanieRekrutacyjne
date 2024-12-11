using Application.Abstraction;
using Domain.Abstraction;

namespace Application.Products.Commands
{
    public sealed class AddProductsCommandHandler : ICommandHandler<AddProductsCommand>
    {
        private readonly IProductRepository _repository;
        public AddProductsCommandHandler(IProductRepository repository)
        {
            _repository = repository;
        }
        public void Handle(AddProductsCommand command)
        {
            _repository.AddProducts(command.Products);
        }
    }
}
