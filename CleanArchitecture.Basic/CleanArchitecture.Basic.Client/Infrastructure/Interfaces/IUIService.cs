using CleanArchitecture.Basic.Client.Domain.Entities;

namespace CleanArchitecture.Basic.Client.Infrastructure.Interfaces
{
    public interface IUIService
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product?> GetProductByIdAsync(long productId);
        Task AddProductAsync(Product product);
    }
}
