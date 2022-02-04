using ProdajaMobilnihAplikacija.Mobile.Views.Klijent;
using ProdajaMobilnihAplikacija.Model;
using ProdajaMobilnihAplikacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProdajaMobilnihAplikacija.Mobile.ViewModels.Klijent
{
    public class RacunViewModel : BaseViewModel
    {
        private readonly APIService _RezervacijaService = new APIService("Rezervacija");
        private readonly APIService _klijentService = new APIService("Klijent");
        private readonly APIService _UgovorService = new APIService("Ugovor");

        private readonly APIService _RacunService = new APIService("Racun");

        public RacunViewModel()
        {
            InitCommand = new Command(async () => await Init());
            OstaviDojamCommand = new Command(async () => await OstaviDojam());
        }

        string _NazivPlacanja = string.Empty;
        public string NazivPlacanja
        {
            get { return _NazivPlacanja; }
            set
            {
                SetProperty(ref _NazivPlacanja, value);
            }
        }

        //public ObservableCollection<Racun> UgovorList { get; set; } = new ObservableCollection<Racun>();
        //public ObservableCollection<Racun> _PronadjeniUgovorService { get; set; } = new ObservableCollection<Racun>();
        public ObservableCollection<Narudzba> RezervacijaList { get; set; } = new ObservableCollection<Narudzba>();
        public ObservableCollection<Narudzba> _PronadjenaRezervacijaList { get; set; } = new ObservableCollection<Narudzba>();
        public ObservableCollection<Model.Racun> _RacunList { get; set; } = new ObservableCollection<Model.Racun>();


        public ICommand InitCommand { get; set; }
        public async Task Init()
        {


            if (APIService.UserID != 0)
            {
                var KlijentModel = await _klijentService.GetById<Model.Klijent>(APIService.UserID);
            }


            RacunSearchRequest search = new RacunSearchRequest();

            var list = await _RacunService.Get<List<Model.Racun>>(null);

            _RacunList.Clear();

            foreach (var racun in list)
            {
                _RacunList.Add(racun);
            }

        }

        public ICommand OstaviDojamCommand { get; set; }
        public async Task OstaviDojam()
        {
            //await Application.Current.MainPage.Navigation.PushModalAsync(new DojamZahtjevPage());

        }
    }
}
