using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SmartCart.Services.Interfaces;
using SmartCart_MVC_Project.Models.Entities;
using SmartCart_MVC_Project.Models.ViewModels;

namespace SmartCart_MVC_Project;

public class ProductController : Controller
{
    private readonly IProductService _productService;
    private readonly ICategoryService _categoryService;

    public ProductController(IProductService productService, ICategoryService categoryService)
    {
        _productService = productService;
        _categoryService = categoryService;
    }

    // GET: Product
    public async Task<IActionResult> Index()
    {
        var products = await _productService.GetAllProductsAsync();

        var viewModel = products.Select(p => new ProductViewModel
        {
            Id = p.Id,
            Name = p.Name,
            Description = p.Description,
            Price = p.Price,
            ImageUrl = p.ImageUrl,
            CategoryName = p.Category?.Name
        });

        return View(viewModel);
    }

    // GET: Product/Create
    // public IActionResult Create()
    // {
    //     return View();
    // }

    // POST: Product/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(ProductViewModel model)
    {
        if (!ModelState.IsValid)
            return View(model);

        var product = new Product
        {
            Name = model.Name,
            Description = model.Description,
            Price = model.Price,
            CategoryId = model.CategoryId
        };

        await _productService.CreateProductAsync(product);

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Create()
    {
        var categories = await _categoryService.GetAllAsync();

        var model = new ProductViewModel
        {
            Categories = categories.Select(c => new SelectListItem
            {
                Value = c.Id.ToString(),
                Text = c.Name
            })
        };

        return View(model);
    }

    [Authorize(Roles = "Customer")]
    public IActionResult Dashboard()
    {
        return View();
    }
}
