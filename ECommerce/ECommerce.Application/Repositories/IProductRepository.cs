namespace ECommerce.Application.Repositories;

using ECommerce.Domain.Products;
using HotChocolate;

public interface IProductRepository
{
    Task<Product?> UpsertProductAsync(Product product, CancellationToken cancellationToken);

    IExecutable<Product> GetProducts();
}
