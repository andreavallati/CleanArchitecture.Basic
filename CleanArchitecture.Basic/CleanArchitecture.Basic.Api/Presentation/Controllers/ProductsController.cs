using CleanArchitecture.Basic.Api.Application.Interfaces.Services;
using CleanArchitecture.Basic.Api.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Basic.Api.Presentation.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var products = await _productService.GetAllProductsAsync();
            return Ok(products);
        }

        [HttpGet("{productId:long}")]
        public async Task<IActionResult> GetProductById(long productId)
        {
            var product = await _productService.GetProductByIdAsync(productId);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct([FromBody] Product product)
        {
            await _productService.AddProductAsync(product);
            return Ok();
        }
    }
}
