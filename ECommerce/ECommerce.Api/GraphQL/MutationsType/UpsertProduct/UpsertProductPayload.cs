namespace ECommerce.Api.GraphQL.MutationsType.UpsertProduct;

using ECommerce.Domain.Products;

public class UpsertProductPayload 
{
    public Guid? Id { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public decimal? Price { get; set; }

    public static UpsertProductPayload ToPayload(Product? product)
    {
        return new UpsertProductPayload
        {
            Id = product?.Id,
            Description = product?.Description,
            Name = product?.Name,
            Price = product?.Price,
        };
    }
}
