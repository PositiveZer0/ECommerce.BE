namespace ECommerce.Application.Features.GetProducts;

using System.Threading;
using System.Threading.Tasks;
using ECommerce.Application.Repositories;
using ECommerce.Domain.Products;
using HotChocolate;
using MediatR;

public class GetProductsQueryHandler : IRequestHandler<GetProductsQuery, IExecutable<Product>>
{
    private readonly IProductRepository _productRepository;

    public GetProductsQueryHandler(IProductRepository productRepository)
    {
        _productRepository = productRepository;
    }

    public Task<IExecutable<Product>> Handle(GetProductsQuery request, CancellationToken cancellationToken) =>
        Task.FromResult(_productRepository.GetProducts());
}
