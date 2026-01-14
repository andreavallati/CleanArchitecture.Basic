using CleanArchitecture.Basic.Api.Application.Interfaces.Repositories;
using CleanArchitecture.Basic.Api.Domain.Entities;
using CleanArchitecture.Basic.Api.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Basic.Api.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductDbContext _context;

        public ProductRepository(ProductDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Product>> GetAllAsync()
        {
            return await _context.Products.ToListAsync();
        }

        public async Task<Product?> GetByIdAsync(long productId)
        {
            return await _context.Products.FindAsync(productId);
        }

        public async Task AddAsync(Product product)
        {
            await _context.Products.AddAsync(product);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
