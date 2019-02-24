using LoginApp.Data;
using LoginApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace LoginApp
{
    public partial class App : Application
    {
        static LocalDatabase database;
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
        }

        public static LocalDatabase Database
        {
            get
            {
                if(database == null)
                {
                    database = new LocalDatabase(DependencyService.Get<ILocalFileHelper>().GetLocalPath("User.db3"));
                }

                return database;
            }
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
