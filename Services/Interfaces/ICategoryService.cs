using SmartCart_MVC_Project.Models.Entities;

namespace SmartCart_MVC_Project;

public interface ICategoryService
{
    IEnumerable<Category> GetAllCategories();
    Category? GetCategoryById(int id);
}
