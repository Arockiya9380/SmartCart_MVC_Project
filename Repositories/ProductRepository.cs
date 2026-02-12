using Microsoft.EntityFrameworkCore;
using SmartCart_MVC_Project.Data;
using SmartCart_MVC_Project.Models.Entities;

namespace SmartCart_MVC_Project;

public class ProductRepository : Repository<Product>, IProductRepository
{
    public ProductRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Product>> GetProductsWithCategoryAsync()
    {
        return await _context.Products
                             .Include(p => p.Category)
                             .ToListAsync();
    }
}
