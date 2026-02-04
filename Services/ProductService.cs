using SmartCart.Services.Interfaces;
using SmartCart_MVC_Project;
using SmartCart_MVC_Project.Models.Entities;

namespace SmartCart.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly ILogger<ProductService> _logger;

        public ProductService(
            IProductRepository productRepository,
            ILogger<ProductService> logger)
        {
            _productRepository = productRepository;
            _logger = logger;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return  _productRepository.GetAll();
        }

        public async Task<Product?> GetByIdAsync(int id)
        {
            return _productRepository.GetById(id);
        }

        public async Task<IEnumerable<Product>> GetByCategoryAsync(int categoryId)
        {
            return _productRepository.GetProductsByCategory(categoryId);
        }

        public async Task AddAsync(Product product)
        {
            if (product.Price <= 0)
                throw new ArgumentException("Price must be greater than zero");

            _productRepository.Add(product);
            _logger.LogInformation("Product added: {Name}", product.ProductName);
        }

        public async Task UpdateAsync(Product product)
        {
            _productRepository.Update(product);
        }

        public async Task DeleteAsync(Product product)
        {
            _productRepository.Delete(product);
        }
    }
}
