using CarRental.Views;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CarRental
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected void ApplicationStart(object sender, EventArgs e)
        {
            var mainWindow = new MainWindow();
            mainWindow.Show();
            mainWindow.IsVisibleChanged += (s, ev) =>
            {
                if (mainWindow.IsVisible == false && mainWindow.IsLoaded)
                {
                    var loginWindow = new LoginWindow();
                    loginWindow.Show();
                    mainWindow.Close();
                }
            };
        }

    }
}
