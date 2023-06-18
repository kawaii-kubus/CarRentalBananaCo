using CarRental.Database;
using CarRental.Database.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
    /// Logika interakcji dla klasy CarOrdersWindow.xaml
    /// </summary>
    public partial class CarOrdersWindow : Window
    {
        private readonly ApplicationDbContext _context;

        public CarOrdersWindow(ApplicationDbContext context)
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

        private void previousWindowBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow(_context);
            this.Visibility = Visibility.Hidden;
            menu.Show();
        }


        private void AddCarBtn_Click(object sender, RoutedEventArgs e)
        {
            AddCarWindow addCarWindow = new AddCarWindow(_context);
            addCarWindow.Show();

        }

        private async void CarOrdersWindow_Loaded(object sender, RoutedEventArgs e)
        {
            List<ZamowieniaSamochodw> cars = await _context.ZamowieniaSamochodow.ToListAsync();
            AddCarDataGrid.ItemsSource = cars;
        }

        private async void RemoveCarBtn_Click(object sender, RoutedEventArgs e)
        {
            int? selectedOrder = AddCarDataGrid.SelectedIndex;
            if (selectedOrder != -1)
            {
                TextBlock ID = AddCarDataGrid.Columns[0].GetCellContent(AddCarDataGrid.Items[(int)selectedOrder]) as TextBlock;

                ZamowieniaSamochodw reservationToDelete = _context.ZamowieniaSamochodow.Where(x => x.ID == int.Parse(ID.Text)).FirstOrDefault();
                _context.Remove(reservationToDelete);
                _context.SaveChanges();
                List<ZamowieniaSamochodw> cars = await _context.ZamowieniaSamochodow.ToListAsync();
                AddCarDataGrid.ItemsSource = cars;

            }

        }
        private async void RefreshData_Click(object sender, RoutedEventArgs e)
        {
            List<ZamowieniaSamochodw> cars = await _context.ZamowieniaSamochodow.ToListAsync();
            AddCarDataGrid.ItemsSource = cars;
        }
    }
}
