using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ProdajaMobilnihAplikacija.Mobile.Models;
using ProdajaMobilnihAplikacija.Mobile.Views;
using ProdajaMobilnihAplikacija.Mobile.ViewModels;
using ProdajaMobilnihAplikacija.Mobile.ViewModels.Klijent;
using ProdajaMobilnihAplikacija.Mobile.Views.Klijent;
using ProdajaMobilnihAplikacija.Model;

namespace ProdajaMobilnihAplikacija.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel viewModel;
        private PocetnaViewModel model = null;
        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = model = new PocetnaViewModel();
        }

        async void OnItemSelected(object sender, EventArgs args)
        {
            var layout = (BindableObject)sender;
            var item = (Item)layout.BindingContext;
            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            //await Navigation.PushModalAsync(new NavigationPage(new NewItemPage()));
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
            //if (viewModel.Items.Count == 0)
            //    viewModel.IsBusy = true;
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as Softver;
            await Navigation.PushAsync(new KupiAplikacijuPage((Softver)(e.SelectedItem)));
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            base.OnAppearing();
            await model.Init();
        }
    }
}