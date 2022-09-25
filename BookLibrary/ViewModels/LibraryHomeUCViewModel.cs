﻿using BookLibrary.Commands;
using BookLibrary.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BookLibrary.ViewModels
{
    public class LibraryHomeUCViewModel:BaseViewModel
    {
        public RelayCommand AddNewBookCommand { get; set; }
        public RelayCommand ShowAllBooksCommand { get; set; }
        public Grid MyGrid { get; internal set; }

        public LibraryHomeUCViewModel()
        {
            AddNewBookCommand = new RelayCommand((e) =>
            {
                App.MyGrid.Children.RemoveAt(0);

                var viewModel=new AddBookUCViewModel();
                var view = new AddBookUC();
                view.DataContext = viewModel;

                App.MyGrid.Children.Add(view);
            });


            ShowAllBooksCommand = new RelayCommand((e) =>
              {
                  var view = new AllBooksUC();
                  var viewModel = new AllBooksViewModel();
                  view.DataContext = viewModel;

                  App.MyGrid.Children.RemoveAt(0);
                  App.MyGrid.Children.Add(view);
              });
        }
    }
}
