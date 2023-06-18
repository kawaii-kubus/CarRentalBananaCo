using CarRental.Database;
using CarRental.Database.Tables;
using CarRental.Views;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CarRental
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //private readonly ApplicationDbContext _context;

        private readonly ApplicationDbContext _context;


        public MainWindow(ApplicationDbContext context)
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

        private void Login_Button_Click(object sender, RoutedEventArgs e)
        {

            MenuWindow menu = new MenuWindow(_context);
            this.Visibility = Visibility.Hidden;
            menu.Show();

        }
    private void ToStart_Button_Click(object sender, RoutedEventArgs e)
    {
        MainWindow mainWindow = new MainWindow(_context);
        if (this != mainWindow)
        {
            mainWindow.Show();
            this.Close();
        }

    }



}
}
