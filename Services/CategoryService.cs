using SmartCart.Repositories;
using SmartCart_MVC_Project.Models.Entities;

namespace SmartCart_MVC_Project;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public IEnumerable<Category> GetAllCategories()
    {
        return _categoryRepository.GetAll();
    }

    public Category? GetCategoryById(int id)
    {
        return _categoryRepository.GetById(id);
    }
}
