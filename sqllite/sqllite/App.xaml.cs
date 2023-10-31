using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace sqllite
{
    public partial class App : Application
    {
        public static string DatabasePath { get; private set; }
        public App()
        {
            InitializeComponent();

            DatabasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "app.db");

            MainPage = new NavigationPage(new Login());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
