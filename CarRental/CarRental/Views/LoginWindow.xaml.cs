
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
    /// Logika interakcji dla klasy LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {

        private readonly ApplicationDbContext _context;
        public LoginWindow(ApplicationDbContext context)
        {
            InitializeComponent();
            _context = context;
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

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            //this.Close();
            //MainWindow main = new MainWindow(_context);
            //main.Show();

            this.IsVisibleChanged += (s, ev) =>
            {
                if (this.IsVisible == false && this.IsLoaded)
                {
                    MainWindow main = new MainWindow(_context);
                    main.Show();
                    this.Close();
                }
            };
        }

 



    }

}
