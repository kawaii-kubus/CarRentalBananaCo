﻿using Microsoft.EntityFrameworkCore;
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
    /// Logika interakcji dla klasy CarOrdersWindow.xaml
    /// </summary>
    public partial class CarOrdersWindow : Window
    {
        public CarOrdersWindow()
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

        private void previousWindowBtn_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menu = new MenuWindow();
            this.Close();
            menu.Show();
        }


        private void AddCarBtn_Click(object sender, RoutedEventArgs e)
        {


        }

        private async void CarOrdersWindow_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private async void RemoveCarBtn_Click(object sender, RoutedEventArgs e)
        {


        }

        private async void RefreshData_Click(object sender, RoutedEventArgs e)
        {
       
        }
    }
}