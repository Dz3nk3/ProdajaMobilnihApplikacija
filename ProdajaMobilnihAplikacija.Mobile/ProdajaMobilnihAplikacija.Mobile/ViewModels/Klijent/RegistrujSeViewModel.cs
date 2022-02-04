using ProdajaMobilnihAplikacija.Mobile.Views;
using ProdajaMobilnihAplikacija.Mobile.Views.Klijent;
using ProdajaMobilnihAplikacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProdajaMobilnihAplikacija.Mobile.ViewModels.Klijent
{
    public class RegistrujSeViewModel : BaseViewModel
    {
        private readonly APIService _serviceKlijenti = new APIService("Klijent");

        public RegistrujSeViewModel()
        {
            RegistracijaCommand = new Command(async () => await Register());
            Title = "Registracija";
            _klijent = new KlijentInsertRequest();
        }

        private bool _isButtonEnabled = true;
        public bool IsButtonEnabled
        {
            get { return _isButtonEnabled; }
            set { SetProperty(ref _isButtonEnabled, value); }
        }

        public string _Ime { get; set; } = null;
        public string _Prezime { get; set; } = null;
        public string _DatumRodjenja { get; set; }
        public string _Email { get; set; } = null;
        public string _Adresa { get; set; } = null;
        public string _BrojTelefona { get; set; } = null;
        public string _KorisnickoIme { get; set; } = null;
        public string _Password { get; set; } = null;
        public string _PasswordConfirmation { get; set; } = null;



        private KlijentInsertRequest _klijent;
        public KlijentInsertRequest Klijent
        {
            get { return _klijent; }
            set { SetProperty(ref _klijent, value); }
        }


        public ICommand SpasiKlijentaRegistrcija { get; set; }




        public ICommand RegistracijaCommand { get; set; }
        public async Task Register()
        {

            try
            {
                //Username
                //var listUsers = await _serviceKlijenti.Get<List<Model.Klijent>>(null);

                //if (_KorisnickoIme != null)
                //{
                //    foreach (var item in listUsers)
                //    {
                //        if (_KorisnickoIme == item.KorisnickoIme)
                //        {
                //            await Application.Current.MainPage.DisplayAlert("Greška", "Korisničko ime već postoji.", "Pokušajte ponovo");
                //            return;
                //        }
                //    }
                //}

               

                //First name
                if (string.IsNullOrWhiteSpace(_Ime) || _Ime.Length < 3)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Ime je obavezno polje!Minimalna dužina mora biti 3 karaktera", "Ok");
                    return;


                }
                if (char.IsLower(_Ime[0]))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Prvo slovo imena mora biti veliko!", "Ok");
                    return;
                }
                bool containsInt = _Ime.Any(char.IsDigit);
                if (containsInt)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Brojevi u imenu nisu dozovljeni!", "Ok");
                    return;
                }
                if (string.IsNullOrWhiteSpace(_Ime) || _Ime.Length < 3)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Korisničko ime je obavezno polje!Minimalna dužina mora biti 3 karaktera", "Ok");
                    return;
                }

                //Last name
                if (string.IsNullOrWhiteSpace(_Prezime) || _Prezime.Length < 3)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Prezime je obavezno polje!Minimalna dužina mora biti 3 karaktera", "Ok");
                    return;


                }
                if (char.IsLower(_Prezime[0]))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Prvo slovo prezimena mora biti veliko!", "Ok");
                    return;
                }
                //bool containsInta = _Prezime.Any(char.IsDigit);
                //if (containsInta)
                //{
                //    await Application.Current.MainPage.DisplayAlert("Greška", "Brojevi u prezimenu nisu dozovljeni!", "Ok");
                //    return;
                //}

                //Email
                if (string.IsNullOrWhiteSpace(_Email))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Email je obavezno polje!", "Ok");
                    return;
                }
                if (!Regex.IsMatch(_Email, @"([a-z]+)([\\.]?)([a-z]*)([@])(yahoo|outlook|gmail|hotmail|fit|edu.fit)(.ba|.com|.org)"))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Email mora biti u formatu: nešto@(gmail,hotmail,fit,edu.fit,outlook,yahoo).(ba,com,org)", "Ok");
                    return;
                }

                //PhoneNumber
                if (string.IsNullOrWhiteSpace(_BrojTelefona))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Broj telefona je obavezno polje!", "Ok");
                    return;
                }
                if (!Regex.IsMatch(_BrojTelefona, @"(06[0-9])([/])([0-9]){3}([-])([0-9]){3}$"))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Broj telefona mora biti u formatu: 06X/XXX-XXX", "Ok");
                    return;
                }

                //Password
                if (_Password != _PasswordConfirmation)
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Lozinke se ne podudaraju!", "Unesite ponovo");
                    return;
                }
                if (string.IsNullOrWhiteSpace(_Password))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Unesi lozinku!", "Ok");
                    return;
                }
                if (string.IsNullOrWhiteSpace(_PasswordConfirmation))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Unesi potvrdu lozinke!", "Ok");
                    return;
                }


                if (string.IsNullOrWhiteSpace(_DatumRodjenja))
                {
                    await Application.Current.MainPage.DisplayAlert("Greška", "Izaberite datum!", "Ok");
                    return;
                }




                var request = new KlijentInsertRequest()
                {
                    Ime = _Ime,
                    Prezime = _Prezime,
                    Adresa = _Adresa,
                    Email = _Email,
                    BrojTel = _BrojTelefona,
                    //Spol = 
                    KorisnickoIme = _KorisnickoIme,
                    DatumRodjenja = _DatumRodjenja,
                    Password = _Password,
                    PasswordConfirmation = _PasswordConfirmation,

                };
                var modelUser = await _serviceKlijenti.PostActionResponse<Model.Klijent>("Registracija", request);

                if (modelUser != null)
                {

                    await Application.Current.MainPage.DisplayAlert("Uspješno ste napravili profil.", "Sada se prijavite.", "Ok");
                    await Application.Current.MainPage.Navigation.PushModalAsync(new LoginPage());

                }


            }
            catch (Exception ex)
            {

                throw;
            }


        }




    }
}
