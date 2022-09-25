using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookLibrary.ViewModels
{
    public class RegisterStudentUCViewModel:BaseViewModel
    {
        private Student student;

        public Student Student
        {
            get { return student; }
            set { student = value;OnPropertyChanged(); }
        }

        public RegisterStudentUCViewModel()
        {
            Student=new Student();
        }


    }
}
