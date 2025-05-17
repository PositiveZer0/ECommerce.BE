namespace ECommerce.Application.Repositories;

using ECommerce.Domain.Products;

public interface IProductRepository
{
    Task<Product?> UpsertProduct(Product product);
}
