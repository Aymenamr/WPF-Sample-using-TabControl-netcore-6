﻿using SoccerManagement.Main.Views;
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

namespace SoccerManagement.Main
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void AddPlayerStackPanel_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            AddPlayerTab.Content = new AddPlayerView();
        }

        private void GetPlayerStackPanel_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            GetPlayersTab.Content = new ListOfPlayersView();
        }
        
        private void GetDashboardStackPanel_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            DashboardTab.Content = new DashboardView();
        }

    }
}
