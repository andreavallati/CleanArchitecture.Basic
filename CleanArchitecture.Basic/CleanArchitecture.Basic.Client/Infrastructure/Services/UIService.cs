using CleanArchitecture.Basic.Client.Domain.Entities;
using CleanArchitecture.Basic.Client.Helpers;
using CleanArchitecture.Basic.Client.Infrastructure.Interfaces;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace CleanArchitecture.Basic.Client.Infrastructure.Services
{
    public class UIService : IUIService
    {
        private readonly HttpClient _httpClient;

        public UIService()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(Constants.WebServiceEndpoint)
            };
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            var response = await _httpClient.GetAsync("products");
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Product>>(jsonResponse) ?? [];
        }

        public async Task<Product?> GetProductByIdAsync(long productId)
        {
            var response = await _httpClient.GetAsync($"products/{productId}");
            response.EnsureSuccessStatusCode();

            var jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Product>(jsonResponse);
        }

        public async Task AddProductAsync(Product product)
        {
            var jsonContent = JsonConvert.SerializeObject(product);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("products", content);
            response.EnsureSuccessStatusCode();
        }
    }
}
