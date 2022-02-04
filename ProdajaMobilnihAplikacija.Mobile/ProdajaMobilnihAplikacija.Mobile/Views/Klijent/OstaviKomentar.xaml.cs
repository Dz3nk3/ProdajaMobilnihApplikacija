using LaavorRatingConception;
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
    public partial class OstaviKomentar : ContentPage
    {
        OstaviKomentarViewModel model = null;
        public OstaviKomentar(MojSoftver softver = null)
        {
            InitializeComponent();
            BindingContext = model = new OstaviKomentarViewModel(softver);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await model.Init();
        }


        private void ratingStar_Voted(object sender, EventArgs e)
        {
            RatingConception rating = (RatingConception)sender;
            int index = rating.IndexVoted;
            int value = rating.Value;

            index_star.Text = index.ToString();
            value_star.Text = value.ToString();

            rating.InitialValue = 1;
            model.Ocjena = value;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await model.Ocjeni();
            await Navigation.PushAsync(new MojSoftverPage());
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new MojSoftverPage());
        }
    }
}