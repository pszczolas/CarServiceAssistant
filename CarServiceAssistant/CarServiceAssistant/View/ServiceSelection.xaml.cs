﻿using CarServiceAssistant.Utils;
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

namespace CarServiceAssistant.View
{
    /// <summary>
    /// Interaction logic for ServiceSelection.xaml
    /// </summary>
    public partial class ServiceSelection : Window
    {
        WindowManager wm = new WindowManager();
        public ServiceSelection()
        {
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            DataContext = new ViewModel.ServiceSelectionViewModel();
            InitializeComponent();
        }
        private void addService_Click(object sender, RoutedEventArgs e)
        {
            wm.OpenAdding();
            this.Visibility = Visibility.Hidden;
            this.Close();
        }

        private void selectService_Click(object sender, RoutedEventArgs e)
        {
            wm.OpenSelection();
            this.Visibility = Visibility.Hidden;
            this.Close();
        }

        private void chooseServiceButton_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
    }
}
