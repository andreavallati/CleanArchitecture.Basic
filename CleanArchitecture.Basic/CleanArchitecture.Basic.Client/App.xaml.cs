using CleanArchitecture.Basic.Client.Infrastructure.Interfaces;
using CleanArchitecture.Basic.Client.Infrastructure.Services;
using CleanArchitecture.Basic.Client.Presentation.Interfaces;
using CleanArchitecture.Basic.Client.Presentation.ViewModels;
using CleanArchitecture.Basic.Client.Presentation.Views;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;

namespace CleanArchitecture.Basic.Client
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        // The service provider that holds the DI container
        private readonly ServiceProvider _serviceProvider;

        public App()
        {
            // Configure DI services
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            // Build the service provider
            _serviceProvider = serviceCollection.BuildServiceProvider();
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            // Register services
            services.AddSingleton<IUIService, UIService>(); // Register UIService as singleton

            // Register ViewModels
            services.AddSingleton<IMainViewModel, MainViewModel>(); // Register MainViewModel as singleton

            // Register the main window
            services.AddSingleton<MainWindow>();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            // Resolve MainWindow and show it
            var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            mainWindow.Show();

            base.OnStartup(e);
        }
    }
}
