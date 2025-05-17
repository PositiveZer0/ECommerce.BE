namespace ECommerce.Api.GraphQL.Queries;

using ECommerce.Application.Features.GetProducts;
using ECommerce.Domain.Products;
using MediatR;

public class QueryType
{
    [GraphQLDescription("Get products.")]
    [UsePaging]
    [UseSorting]
    [UseFiltering]
    public async Task<IExecutable<Product>> GetProductsAsync(
        [Service] IMediator mediator,
        CancellationToken cancellationToken)
    {
        return await mediator.Send(new GetProductsQuery(), cancellationToken);
    }
}
