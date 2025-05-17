namespace ECommerce.Api.GraphQL.Mutations;

using ECommerce.Api.GraphQL.MutationsType.UpsertProduct;
using MediatR;

public partial class Mutation
{
    public async Task<UpsertProductPayload> UpsertProductAsync(
       [Service] ISender mediator,
       UpsertProductInput input,
       CancellationToken cancellationToken)
    {
        var command = input.ToCommand();
        var response = await mediator.Send(command, cancellationToken);

        return UpsertProductPayload.ToPayload(response);
    }
}
