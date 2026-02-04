using SmartCart.Repositories;
using SmartCart_MVC_Project.Data;
using SmartCart_MVC_Project.Models.Entities;

namespace SmartCart_MVC_Project;

public class CategoryRepository : Repository<Category>, ICategoryRepository
{
    public CategoryRepository(ApplicationDbContext context)
            : base(context)
        {
        }
}
