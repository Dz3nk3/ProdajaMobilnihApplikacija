using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using ProdajaMobilnihAplikacija.Mobile.Services;
using ProdajaMobilnihAplikacija.Mobile.Views;
using ProdajaMobilnihAplikacija.Mobile.Views.Klijent;

namespace ProdajaMobilnihAplikacija.Mobile
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            //MainPage = new MainPage();
            MainPage = new LoginPage();

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
