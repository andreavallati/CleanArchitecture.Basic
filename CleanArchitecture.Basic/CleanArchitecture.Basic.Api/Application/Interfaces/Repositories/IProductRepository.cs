

using CleanArchitecture.Basic.Api.Domain.Entities;

namespace CleanArchitecture.Basic.Api.Application.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllAsync();
        Task<Product?> GetByIdAsync(long productId);
        Task AddAsync(Product product);
        Task SaveChangesAsync();
    }
}
