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
    public partial class DetaljiSoftveraPage : ContentPage
    {
        private DetaljiSoftveraViewModel model = null;
        public DetaljiSoftveraPage(Softver softver)
        {
            InitializeComponent();
            BindingContext = model = new DetaljiSoftveraViewModel(softver);
        }

          protected async override void OnAppearing()
        {
            base.OnAppearing();
            model.Init();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new OstaviKomentar());

        }

        //private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        //{
        //    await Navigation.PushAsync(new DetaljiVozilaSlikePage((Vozilo)(e.SelectedItem)));
        //}
    }
}