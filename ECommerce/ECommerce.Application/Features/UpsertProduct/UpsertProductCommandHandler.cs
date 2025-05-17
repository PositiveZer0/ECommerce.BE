namespace ECommerce.Application.Features.UpsertProduct;

using System.Threading;
using System.Threading.Tasks;
using ECommerce.Application.Repositories;
using ECommerce.Domain.Products;
using MediatR;

public class UpsertProductCommandHandler : IRequestHandler<UpsertProductCommand, Product?>
{
    private readonly IProductRepository _productRepository;

    public UpsertProductCommandHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public async Task<Product?> Handle(UpsertProductCommand request, CancellationToken cancellationToken)
    {
        var product = Product.Create(
               request.Name,
               request.Description,
               request.Price);

        return await _productRepository.UpsertProductAsync(product, cancellationToken);
    }
}
