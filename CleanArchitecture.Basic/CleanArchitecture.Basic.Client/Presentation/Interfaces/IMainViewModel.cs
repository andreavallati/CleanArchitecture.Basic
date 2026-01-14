using CleanArchitecture.Basic.Client.Domain.Entities;
using System.Windows.Input;

namespace CleanArchitecture.Basic.Client.Presentation.Interfaces
{
    public interface IMainViewModel
    {
        IEnumerable<Product> Products { get; set; }
        Product SelectedProduct { get; set; }
        ICommand LoadProductsCommand { get; }
        ICommand AddProductCommand { get; }
    }
}
