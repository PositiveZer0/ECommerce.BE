namespace ECommerce.Api.GraphQL.MutationsType.UpsertProduct;

using ECommerce.Application.Features.UpsertProduct;

public class UpsertProductInput : UpsertProductCommand
{
   public UpsertProductCommand ToCommand()
    {
        return new UpsertProductCommand
        {
            Description = Description,
            Price = Price,
            Name = Name,
        };
    }
}
