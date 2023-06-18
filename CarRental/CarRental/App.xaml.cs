using CarRental.Database;
using CarRental.Views;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.EntityFrameworkCore;
using CarRental.CustomControls;
namespace CarRental
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private readonly ApplicationDbContext context;
        private ServiceProvider serviceProvider;

        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer("Server=(local); Database=BananaCarRental; Integrated Security=true; Encrypt=True;TrustServerCertificate=True", o => o.CommandTimeout(120));
            });

            services.AddSingleton<MainWindow>();

        }

        private void OnStartup(object sender, StartupEventArgs e)
        {


            LoginWindow loginWindow = new LoginWindow(context);
            loginWindow.Show();
            loginWindow.IsVisibleChanged += (s, ev) =>
            {
                if (loginWindow.IsVisible == false && loginWindow.IsLoaded)
                {
                    MainWindow main = serviceProvider.GetService<MainWindow>();
                    main.Show();
                    loginWindow.Close();
                }
            };
        }

    }
}

