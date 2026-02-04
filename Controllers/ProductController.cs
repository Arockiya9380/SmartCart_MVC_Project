using Microsoft.AspNetCore.Mvc;
using SmartCart.Services.Interfaces;

namespace SmartCart_MVC_Project;

public class ProductController : Controller
{

    private readonly IProductService _productService;
    private readonly ICategoryService _categoryService;
    private readonly ILogger<ProductController> _logger;

    public ProductController(
        IProductService productService,
        ICategoryService categoryService,
        ILogger<ProductController> logger)
    {
        _productService = productService;
        _categoryService = categoryService;
        _logger = logger;
    }

    // GET: /Product
    public IActionResult Index(string searchTerm, string category, int page = 1)
    {
        _logger.LogInformation("Fetching product list");

        var products = _productService.GetAllAsync();
        // var products = _productService.GetAllAsync(searchTerm, category, page);
        var categories = _categoryService.GetAllCategories();

        var viewModel = new ProductListViewModel
        {
            Products = (IEnumerable<Models.Entities.Product>)products,
            Categories = categories,
            SearchTerm = searchTerm,
            SelectedCategory = category,
            CurrentPage = page,
            // TotalPages = _productService.GetTotalPages(searchTerm, category)
        };

        return View(viewModel);
    }

    // GET: /Product/Details/5
    // public IActionResult Details(int id)
    // {
    //     _logger.LogInformation($"Fetching product details for ProductId: {id}");

    //     var product = _productService.GetByIdAsync(id);

    //     if (product == null)
    //     {
    //         _logger.LogWarning($"Product not found. ProductId: {id}");
    //         return NotFound();
    //     }

    //     var viewModel = new ProductViewModel
    //     {
    //         Name = product.,
    //         Price = product.Price,
    //         CategoryName = product.CategoryName,
    //         InStock = product.InStock
    //     };

    //     return View(viewModel);
    // }

}
