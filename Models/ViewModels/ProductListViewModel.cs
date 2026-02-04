using SmartCart_MVC_Project.Models.Entities;

namespace SmartCart_MVC_Project;

public class ProductListViewModel
{
    public IEnumerable<Product> Products { get; set; }

    public IEnumerable<Category> Categories { get; set; }

    public string SearchTerm { get; set; }
    public string SelectedCategory { get; set; }

    public int CurrentPage { get; set; }
    public int TotalPages { get; set; }
}
