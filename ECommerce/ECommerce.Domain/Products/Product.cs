namespace ECommerce.Domain.Products;
public class Product
{
    private Product() { }

    public Guid Id { get; init; }

    public string Name { get; init; } = default!;

    public string Description { get; init; } = default!;

    public decimal Price { get; init; }

    public Product Create(string name, string description, decimal price)
    {
        return new Product
        {
            Id = Guid.NewGuid(),
            Name = name,
            Description = description,
            Price = price,
        };
    }
}
