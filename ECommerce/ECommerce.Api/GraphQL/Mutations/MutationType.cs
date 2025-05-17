namespace ECommerce.Api.GraphQL.Mutations;

using ECommerce.Api.GraphQL.MutationsType.UpsertProduct;

public class MutationType : ObjectType<Mutation>
{
    private const string Input = "input";

    protected override void Configure(IObjectTypeDescriptor<Mutation> descriptor)
    {
        descriptor.BindFieldsExplicitly();

        BindUpsertProduct(descriptor);
    }

    private static void BindUpsertProduct(IObjectTypeDescriptor<Mutation> descriptor) =>
        descriptor.Field(m => m.UpsertProductAsync(default!, default!, default!))
            .Argument(
                Input,
                x =>
                {
                    x.Type<UpsertProductInputType>();
                })
            .Type<UpsertProductPayloadType>();
}
