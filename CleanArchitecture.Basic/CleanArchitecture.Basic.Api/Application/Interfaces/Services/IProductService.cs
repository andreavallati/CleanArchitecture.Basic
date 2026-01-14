using CleanArchitecture.Basic.Api.Domain.Entities;

namespace CleanArchitecture.Basic.Api.Application.Interfaces.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product?> GetProductByIdAsync(long productId);
        Task AddProductAsync(Product product);
    }
}
