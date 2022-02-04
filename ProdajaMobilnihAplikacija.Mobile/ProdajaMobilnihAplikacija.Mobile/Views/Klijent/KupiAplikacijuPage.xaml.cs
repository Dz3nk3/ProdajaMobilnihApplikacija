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
    public partial class KupiAplikacijuPage : ContentPage
    {
        KupiAplikacijuViewModel model = null;
        public KupiAplikacijuPage(Softver softver = null)
        {
            InitializeComponent();
            BindingContext = model = new KupiAplikacijuViewModel(softver);
        }
        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }
    }
}