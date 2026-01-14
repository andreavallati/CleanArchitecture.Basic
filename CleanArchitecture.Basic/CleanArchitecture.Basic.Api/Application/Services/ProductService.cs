using CleanArchitecture.Basic.Api.Application.Interfaces.Repositories;
using CleanArchitecture.Basic.Api.Application.Interfaces.Services;
using CleanArchitecture.Basic.Api.Domain.Entities;

namespace CleanArchitecture.Basic.Api.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<Product?> GetProductByIdAsync(long productId)
        {
            return await _productRepository.GetByIdAsync(productId);
        }

        public async Task AddProductAsync(Product product)
        {
            await _productRepository.AddAsync(product);
            await _productRepository.SaveChangesAsync();
        }
    }
}
