using CarRental.Database;
using CarRental.Database.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    /// Logika interakcji dla klasy AddCarWindow.xaml
    /// </summary>
    public partial class AddCarWindow : Window
    {
        private readonly ApplicationDbContext _context;

        public AddCarWindow(ApplicationDbContext context)
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
        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            _context.ZamowieniaSamochodow.Add(new ZamowieniaSamochodw
            {
                SamochodID = int.Parse(SamochodIdTxt.Text),
                StatusID = int.Parse(StatusIdTxt.Text),
                DataZamowienia = (DateTime)DataZamowieniaCalendar.SelectedDate
            });
            _context.SaveChanges();
            Thread.Sleep(2000);

            Close();

        }

        private void SamochodIdTxt_GotFocus(object sender, RoutedEventArgs e)
        {
            SamochodIdTxt.Clear();
        }

        private void StatusIdTxt_GotFocus(object sender, RoutedEventArgs e)
        {
            StatusIdTxt.Clear();
        }
    }
}
