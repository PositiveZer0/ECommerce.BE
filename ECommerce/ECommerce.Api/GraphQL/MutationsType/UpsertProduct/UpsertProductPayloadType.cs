namespace ECommerce.Api.GraphQL.MutationsType.UpsertProduct;

public class UpsertProductPayloadType : ObjectType<UpsertProductPayload>
{
    protected override void Configure(IObjectTypeDescriptor<UpsertProductPayload> descriptor)
    {
        descriptor.BindFieldsExplicitly();

        descriptor.Field(f => f.Id);
        descriptor.Field(f => f.Name);
        descriptor.Field(f => f.Description);
        descriptor.Field(f => f.Price);
    }
}
