using BookLibrary.Commands;
using BookLibrary.Views.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace BookLibrary.ViewModels
{
   public class LibrarianUCViewModel:BaseViewModel
    {
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; OnPropertyChanged(); }
        }

        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged(); }
        }


        public RelayCommand SignInCommand { get; set; }
        public Grid MyGrid { get; internal set; }

        public LibrarianUCViewModel()
        {
            SignInCommand = new RelayCommand((e) =>
              {
                  if(Username=="admin" && Password == "admin")
                  {
                      var viewModel = new LibraryHomeUCViewModel();
                      var view = new LibrantHomeUC();
                      view.DataContext = viewModel;

                      MyGrid.Children.RemoveAt(0);
                      MyGrid.Children.Add(view);
                  }
              });
        }
    }
}
