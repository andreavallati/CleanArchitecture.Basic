using CleanArchitecture.Basic.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Basic.Api.Infrastructure.Data
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
