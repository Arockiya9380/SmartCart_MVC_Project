using SmartCart_MVC_Project.Models.Entities;

namespace SmartCart_MVC_Project;

public interface ICategoryService
{
    Task<IEnumerable<Category>> GetAllAsync();
    Task<Category?> GetByIdAsync(int id);
    Task CreateAsync(Category category);
}
