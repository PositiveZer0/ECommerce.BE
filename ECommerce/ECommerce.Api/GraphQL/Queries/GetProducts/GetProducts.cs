namespace ECommerce.Api.GraphQL.Queries.GetProducts;

using ECommerce.Application.Features.GetProducts;
using ECommerce.Domain.Products;
using MediatR;

[ExtendObjectType(typeof(QueryType))]
[QueryType]
public class GetProducts
{
    [GraphQLDescription("Get products.")]
    public async Task<IExecutable<Product>> GetProductsAsync(
        [Service] IMediator mediator,
        CancellationToken cancellationToken)
    {
        var query = new GetProductsQuery();

        var response = await mediator.Send(query, cancellationToken);

        return response;
    }
}
