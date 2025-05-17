namespace ECommerce.Infrastructure.Repositories;

using System.Threading.Tasks;
using ECommerce.Application.Repositories;
using ECommerce.Domain.Products;

public class ProductRepository : IProductRepository
{
    public Task<Product?> UpsertProduct(Product product) => throw new NotImplementedException();
}
