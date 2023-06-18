using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CarRental.Database;
using CarRental.Database.Tables;

namespace CarRental.Views
{
    /// <summary>
    /// Logika interakcji dla klasy MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        private readonly ApplicationDbContext _context;

        public MenuWindow(ApplicationDbContext context)
        {
            _context = context;
            InitializeComponent();
        }
        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
        private void ToStart_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow(_context);
            mainWindow.Show();
            this.Close();

        }
        private void PracownicyButton_Click(object s, RoutedEventArgs e)
        {
            EmployeesWindow employersWindow = new EmployeesWindow(_context);
            this.Visibility = Visibility.Hidden;
            employersWindow.Show();
        }
        private void ZamowSamochodButton_Click(object s, RoutedEventArgs e)
        {
            CarOrdersWindow carOrdersWindow = new CarOrdersWindow(_context);
            this.Visibility = Visibility.Hidden;
            carOrdersWindow.Show();
        }
        private void WylogujButton_Click(object s, RoutedEventArgs e)
        {
            LoginWindow loginWindow = new LoginWindow(_context);
            this.Visibility = Visibility.Hidden;
            loginWindow.Show();
        }

      private async void CarListWindow_Loaded(object sender, RoutedEventArgs e)
        {
            List<ListaSamochodw> cars = await _context.ListaSamochodow.ToListAsync();
            CarListdataGrid.ItemsSource = cars;
        }  
    }
}
