using ProdajaMobilnihAplikacija.Mobile.ViewModels.Klijent;
using ProdajaMobilnihAplikacija.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProdajaMobilnihAplikacija.Mobile.Views.Klijent
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SoftverPage : ContentPage
    {
        SoftverViewModel model = null;
        public SoftverPage()
        {
            InitializeComponent();
            BindingContext = model = new SoftverViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        //private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{

        //    //await Navigation.PushAsync(new NapraviRezervacijuPage((Vozilo)e.SelectedItem)); // kada vise puta udjem, app pukne 

        //}

        private async void ListView_ItemSelected_1(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Softver;
            await Navigation.PushAsync(new DetaljiSoftveraPage((Softver)(e.SelectedItem)));
        }
    }
}