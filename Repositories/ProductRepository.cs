using Microsoft.EntityFrameworkCore;
using SmartCart_MVC_Project.Data;
using SmartCart_MVC_Project.Models.Entities;

namespace SmartCart_MVC_Project;

public class ProductRepository 
    : Repository<Product>, IProductRepository
{
    public ProductRepository(ApplicationDbContext context)
        : base(context)
    {
    }

    public IEnumerable<Product> GetProductsByCategory(int categoryId)
    {
        return _context.Products
                    //    .Include(p => p.Category)
                       .Where(p => p.CategoryId == categoryId)
                       .ToList();
    }
}
