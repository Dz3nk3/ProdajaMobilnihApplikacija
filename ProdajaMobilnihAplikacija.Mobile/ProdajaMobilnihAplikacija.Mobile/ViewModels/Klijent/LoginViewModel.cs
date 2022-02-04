using ProdajaMobilnihAplikacija.Mobile.Views;
using ProdajaMobilnihAplikacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
namespace ProdajaMobilnihAplikacija.Mobile.ViewModels.Klijent
{
    public class LoginViewModel : BaseViewModel
    {
        private readonly APIService serviceKlijenti = new APIService("Klijent");

        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
        }


        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }


        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }


        public static int UserID { get; set; }

        public ICommand LoginCommand { get; set; } 
        async Task Login()
        {
            IsBusy = true;

            APIService.Username = Username;
            APIService.Password = Password;

            //ovo izbrisati kada se napravi authentifikacija
            Application.Current.MainPage = new MainPage();

            LoginRequest search;

            try
            {
                if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Obavezno unesite korisničko ime i lozinku!", "Ok");
                    return;
                }


                search = new LoginRequest()
                {
                    Username = _username,
                    Password = _password
                };

                var request = new KlijentSearchRequest()
                {
                    _Username = Username
                };
                var temp = await serviceKlijenti.Get<List<Model.Klijent>>(request);
                var obj = temp;

                for (int i = 0; i < obj.Count; i++)
                {
                    if (Username == obj[i].KorisnickoIme)
                    {
                        APIService.UserID = obj[i].KlijentId;
                    }
                }

                Application.Current.MainPage = new MainPage();

            }
            catch (Exception ex)
            {
                //throw;
            }

        }
    }
}
