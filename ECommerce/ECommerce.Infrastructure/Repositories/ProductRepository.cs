namespace ECommerce.Infrastructure.Repositories;

using System.Threading.Tasks;
using ECommerce.Application.Repositories;
using ECommerce.Domain.Products;
using HotChocolate;
using Microsoft.EntityFrameworkCore;

public class ProductRepository : IProductRepository
{
    private readonly ApplicationDbContext _context;

    public ProductRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IExecutable<Product> GetProducts() => _context.Products.AsExecutable();

    public async Task<Product?> UpsertProductAsync(Product product, CancellationToken cancellationToken)
    {
        var existingProduct = await _context.Products
            .FirstOrDefaultAsync(x => x.Id == product.Id, cancellationToken);

        if (existingProduct is null)
        {
            // Add new product
            _context.Products.Add(product);
        }
        else
        {
            // Update existing product
            _context.Entry(existingProduct).CurrentValues.SetValues(product);
        }

        await _context.SaveChangesAsync(cancellationToken);
        return product;
    }
}
