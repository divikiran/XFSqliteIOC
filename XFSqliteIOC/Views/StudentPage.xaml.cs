using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XFSqliteIOC.ViewModels;
using Microsoft.Practices.Unity;

namespace XFSqliteIOC.Views
{
    public partial class StudentPage : BasePage
    {
        private NewStudentViewModel ViewModel;

        public StudentPage()
        {
            InitializeComponent();
            BindingContext = ViewModel = App.Container.Resolve<NewStudentViewModel>();
        }

        public StudentsEntity CurrentStudent { get; set; }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (CurrentStudent != null)
            {
                ViewModel.Title = "Edit Student";
                ViewModel.Id = CurrentStudent.Id;
                ViewModel.Name = CurrentStudent.Name;
                ViewModel.Location = CurrentStudent.Location;
                ViewModel.Image = CurrentStudent.Image;
            }
        }
    }
}
