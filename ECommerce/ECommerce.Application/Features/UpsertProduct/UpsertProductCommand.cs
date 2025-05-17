namespace ECommerce.Application.Features.UpsertProduct;

using ECommerce.Domain.Products;
using MediatR;

public class UpsertProductCommand : IRequest<Product?>
{
    public string Name { get; set; } = default!;

    public string Description { get; set; } = default!;

    public decimal Price { get; set; }
}
