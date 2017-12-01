﻿using Xamarin.Forms;
using Microsoft.Practices.Unity;
using System.Collections.ObjectModel;

namespace XFSqliteIOC
{
    public partial class XFSqliteIOCPage : BasePage
    {

        public StudentsViewModel ViewModel { get; private set; }
        public XFSqliteIOCPage()
        {
            //ViewModel = App.Container.Resolve<StudentsViewModel>();
            InitializeComponent();
            BindingContext = ViewModel = App.Container.Resolve<StudentsViewModel>();
        }

        //public IStudentsRepository StudentRepo
        //{
        //    get;
        //    set;
        //} //= new StudentsRepository();

        //protected async override void OnAppearing()
        //{
        //    base.OnAppearing();
        //    //var connection = DependencyService.Get<ISQLiteConnection>().GetConnectionAsync();
        //    //connection.CreateTableAsync<StudentsEntity>();
        //    //var students = connection.Table<StudentsEntity>();
        //    //connection.InsertAsync(new StudentsEntity() { Name = "Divikiran Ravela" });


        //    //await StudentRepo.Insert(new StudentsEntity(){ Name = "Nitika Ravela"});

        //    //var studentsCollection = await ViewModel.StudentsRepo.GetAll();

        //    //ViewModel.Students = new ObservableCollection<StudentsEntity>(studentsCollection);

        //}
    }
}
