using ProdajaMobilnihAplikacija.Mobile.ViewModels.Klijent;
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
    public partial class Racun : ContentPage
    {
        RacunViewModel model = null;
        public Racun()
        {
            InitializeComponent();
            BindingContext = model = new RacunViewModel();
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushAsync(new OcijenivanjeIKomentarisanje());
            await model.OstaviDojam();
        }

    }
}