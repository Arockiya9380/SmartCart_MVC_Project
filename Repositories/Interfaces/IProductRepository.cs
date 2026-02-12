using SmartCart_MVC_Project.Models.Entities;

namespace SmartCart_MVC_Project;

public interface IProductRepository : IRepository<Product>
{
    Task<IEnumerable<Product>> GetProductsWithCategoryAsync();
}
