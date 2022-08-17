using Spy_Screen_Shot_2.Services;
using Spy_Screen_Shot_2.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Spy_Screen_Shot_2
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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
