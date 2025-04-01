using CleanArchitecture.Basic.Client.Domain.Entities;
using CleanArchitecture.Basic.Client.Infrastructure.Interfaces;
using CleanArchitecture.Basic.Client.Presentation.Interfaces;
using System.Windows.Input;

namespace CleanArchitecture.Basic.Client.Presentation.ViewModels
{
    public class MainViewModel : BindableBase, IMainViewModel
    {
        private readonly IUIService _uiService;

        private IEnumerable<Product> _products;
        private string _productName;
        private decimal _productPrice;

        public MainViewModel(IUIService uiService)
        {
            _uiService = uiService ?? throw new ArgumentNullException(nameof(uiService));

            AddProductCommand = new DelegateCommand(async () => await AddProductAsync());
            LoadProductsCommand = new DelegateCommand(async () => await LoadProductsAsync());
        }

        public ICommand LoadProductsCommand { get; }
        public ICommand AddProductCommand { get; }

        public Product SelectedProduct { get; set; }

        public IEnumerable<Product> Products
        {
            get => _products;
            set => SetProperty(ref _products, value);
        }

        public string ProductName
        {
            get => _productName;
            set => SetProperty(ref _productName, value);
        }

        public decimal ProductPrice
        {
            get => _productPrice;
            set => SetProperty(ref _productPrice, value);
        }

        private async Task LoadProductsAsync()
        {
            Products = (await _uiService.GetAllProductsAsync()).ToList();
        }

        private async Task AddProductAsync()
        {
            var product = new Product
            {
                Name = ProductName,
                Price = ProductPrice
            };

            await _uiService.AddProductAsync(product);
            await LoadProductsAsync();
        }
    }
}
