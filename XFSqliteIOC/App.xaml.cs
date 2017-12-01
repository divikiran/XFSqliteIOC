using System;
using Microsoft.Practices.Unity;
using Xamarin.Forms;

namespace XFSqliteIOC
{
    public partial class App : Application
    {
        public static UnityContainer Container { get; set; }

        public App()
        {
            InitializeComponent();
            Initialize();
            MainPage = new NavigationPage(Container.Resolve<XFSqliteIOCPage>()); // new XFSqliteIOCPage();
        }

        private void Initialize()
        {
			App.Container = new UnityContainer();
            App.Container.RegisterType<IStudentsRepository, StudentsRepository>();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}