using CleanArchitecture.Basic.Client.Presentation.Interfaces;
using System.Windows;

namespace CleanArchitecture.Basic.Client.Presentation.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow(IMainViewModel mainViewModel)
        {
            DataContext = mainViewModel;
            InitializeComponent();
        }
    }
}