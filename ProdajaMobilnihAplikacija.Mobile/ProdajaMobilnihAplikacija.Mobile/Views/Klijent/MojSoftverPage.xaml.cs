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
    public partial class MojSoftverPage : ContentPage
    {
        MojSoftverViewModel model = null;
        public MojSoftverPage()
        {
            InitializeComponent();
            BindingContext = model = new MojSoftverViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }
        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MojSoftver;
            await Navigation.PushAsync(new OstaviKomentar((MojSoftver)e.SelectedItem)); // kada vise puta udjem, app pukne 

        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new DetaljiVozilaSlikePage(null));
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OstaviKomentar());
        }
    }
}