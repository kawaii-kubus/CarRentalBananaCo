using CarRental.Database;
using CarRental.Database.Tables;
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

namespace CarRental.Views
{
    /// <summary>
    /// Logika interakcji dla klasy EmployeesWindow.xaml
    /// </summary>
    public partial class EmployeesWindow : Window
    {
        private readonly ApplicationDbContext _context;

        public EmployeesWindow(ApplicationDbContext context)
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

        private async void EmployeesListWindow_Loaded(object sender, RoutedEventArgs e)
        {
            List<Pracownicy> workers = await _context.Pracownicy.ToListAsync();
            EmployeesListdataGrid.ItemsSource = workers;
        }
        private void previousWindowBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow(_context);
            this.Visibility = Visibility.Hidden;
            menu.Show();
        }
    }
}
