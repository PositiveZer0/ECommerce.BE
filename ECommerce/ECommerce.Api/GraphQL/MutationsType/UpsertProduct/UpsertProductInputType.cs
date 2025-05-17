namespace ECommerce.Api.GraphQL.MutationsType.UpsertProduct;

public class UpsertProductInputType : InputObjectType<UpsertProductInput>
{
    protected override void Configure(IInputObjectTypeDescriptor<UpsertProductInput> descriptor)
    {
        descriptor.BindFieldsExplicitly();

        descriptor.Field(f => f.Name).Type<StringType>();
        descriptor.Field(f => f.Description).Type<StringType>();
        descriptor.Field(f => f.Price).Type<DecimalType>();
    }
}
