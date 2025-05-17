namespace ECommerce.Application.Features.GetProducts;

using ECommerce.Domain.Products;
using HotChocolate;
using MediatR;

public class GetProductsQuery : IRequest<IExecutable<Product>>
{
}
