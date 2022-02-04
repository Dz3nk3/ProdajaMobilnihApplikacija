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
    public partial class KorisnickiPodaciPage : ContentPage
    {


        PostavkeProfilaViewModel model = null;
        public KorisnickiPodaciPage()
        {
            InitializeComponent();
            BindingContext = model = new PostavkeProfilaViewModel();
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }


    }
}