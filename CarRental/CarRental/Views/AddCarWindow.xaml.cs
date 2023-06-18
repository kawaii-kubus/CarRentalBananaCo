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
        public AddCarWindow()
        {
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
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();


        }
        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {

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
