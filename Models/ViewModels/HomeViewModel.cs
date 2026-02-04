namespace SmartCart_MVC_Project;

public class HomeViewModel
{
    public List<ProductViewModel> FeaturedProducts { get; set; }
    public List<string> Categories { get; set; }

    public int TotalProducts { get; set; }
    public int TotalCategories { get; set; }
}
