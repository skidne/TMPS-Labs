﻿using System;
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
using UI.ViewModels;
using Labs;

namespace UI.Views
{
    /// <summary>
    /// Interaction logic for SpaceshipDetails.xaml
    /// </summary>
    public partial class SpaceshipDetails : Window
    {
        public SpaceshipDetails()
        {
            InitializeComponent();
           
            Items.ItemsSource = ((MainWindowViewModel)Application.Current.MainWindow.DataContext).Spaceships;
        }
    }
}
