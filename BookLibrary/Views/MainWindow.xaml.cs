﻿using BookLibrary.ViewModels;
using BookLibrary.Views.UserControls;
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

namespace BookLibrary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var viewModel = new MainViewModel();
            viewModel.MyGrid = mygrid;

            var homeUCViewModel = new HomeUCViewModel();
            var homeUC = new HomeUC();
            homeUCViewModel.MyGrid = viewModel.MyGrid;


            homeUC.DataContext = homeUCViewModel;
            viewModel.MyGrid.Children.Add(homeUC);


            this.DataContext = viewModel;
        }
    }
}
