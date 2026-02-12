using SmartCart_MVC_Project.Models.Entities;
using SmartCart_MVC_Project.Repositories;

namespace SmartCart_MVC_Project;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }

    public async Task<IEnumerable<Category>> GetAllAsync()
    {
        return await _categoryRepository.GetAllAsync();
    }

    public async Task<Category?> GetByIdAsync(int id)
    {
        return await _categoryRepository.GetByIdAsync(id);
    }

    public async Task CreateAsync(Category category)
    {
        await _categoryRepository.AddAsync(category);
        await _categoryRepository.SaveChangesAsync();
    }
}
