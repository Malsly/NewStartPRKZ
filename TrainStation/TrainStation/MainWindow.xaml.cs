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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ViewModels.Impl;

namespace TrainStation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        StationViewModel stationViewModelObject;
        public MainWindow()
        {
            InitializeComponent();
            stationViewModelObject = new StationViewModel();
        }

        private void StationViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            stationViewModelObject.LoadStations();

            StationViewControl.DataContext = stationViewModelObject;
        }
        private void TrainViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            TrainViewControl.DataContext = stationViewModelObject;
        }
        private void VanViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            VanViewControl.DataContext = stationViewModelObject;
        }
        private void SeatViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            SeatViewControl.DataContext = stationViewModelObject;
        }

        private void TicketViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            TicketViewControl.DataContext = stationViewModelObject;
        }
        private void PassangerViewControl_Loaded(object sender, RoutedEventArgs e)
        {
            PassangerViewControl.DataContext = stationViewModelObject;
        }
    }
}
