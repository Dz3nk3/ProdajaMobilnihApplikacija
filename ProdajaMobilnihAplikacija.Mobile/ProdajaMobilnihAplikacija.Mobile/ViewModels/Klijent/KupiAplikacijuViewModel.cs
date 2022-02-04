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
    public class KupiAplikacijuViewModel : BaseViewModel
    {
        private readonly APIService _SoftverService = new APIService("Softver");
        private readonly APIService _KategorijaService = new APIService("Kategorija");
        private readonly APIService _KlijentService = new APIService("Klijent");
        private readonly APIService _MojSoftverService = new APIService("MojSoftver");


        public Softver _vozilo = null;
        string _Naziv = string.Empty;
        string _Verzija = string.Empty;
        string _Cijena = string.Empty;
        public byte[] _SlikaThumb = null;
        public string _Kategorija = null;
        int _KlijentId = 0;
        double? _ukupnaCijena = 0;


        public KupiAplikacijuViewModel(Softver softver)
        {
            _vozilo = softver;
            InitCommand = new Command(async () => await Init());
            SaveCommand = new Command(async () => await SaveChanges());
            _Naziv = softver.Naziv;
            _Verzija = softver.Verzija;
            _Cijena = softver.Cijena.ToString();
            _SlikaThumb = softver.SlikaThumb;
        }

        public string Naziv
        {
            get { return _Naziv; }
            set
            { SetProperty(ref _Naziv, value); }
        }
        public byte[] SlikaThumb
        {
            get { return _SlikaThumb; }
            set
            { SetProperty(ref _SlikaThumb, value); }
        }
        public string Verzija
        {
            get { return _Verzija; }
            set
            { SetProperty(ref _Verzija, value); }
        }
        public string Cijena
        {
            get { return _Cijena; }
            set
            { SetProperty(ref _Cijena, value); }
        }
        public string Kategorija
        {
            get { return _Kategorija; }
            set
            { SetProperty(ref _Kategorija, value); }
        }
        public int KlijentId
        {
            get { return _KlijentId; }
            set { SetProperty(ref _KlijentId, value); }
        }
        public double? ukupnaCijena
        {
            get { return _ukupnaCijena; }
            set { SetProperty(ref _ukupnaCijena, value); }
        }

        public ObservableCollection<MojSoftver> lokacijaList { get; set; } = new ObservableCollection<MojSoftver>();
        public ObservableCollection<Softver> softverList { get; set; } = new ObservableCollection<Softver>();
        public ObservableCollection<Model.Klijent> popustList { get; set; } = new ObservableCollection<Model.Klijent>();

        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            if (softverList.Count == 0)
            {
                var softver = await _SoftverService.GetById<Model.Softver>(_vozilo.SoftverId);
                var kategorija = await _KategorijaService.GetById<Model.Kategorija>(_vozilo.KategorijaId);

                Kategorija = kategorija.Naziv;
            }
            //ukupnaCijena = _vozilo.CijenaPoSatu * 1.17;
        }

        public ICommand SaveCommand { get; set; }
        public async Task SaveChanges()
        {
            APIService.UserID = 1;
            var KlijentModel = await _KlijentService.GetById<Model.Klijent>(APIService.UserID);
            var MojSoftverModel = await _MojSoftverService.GetById<Model.MojSoftver>(_vozilo.SoftverId);
            var MojSoftver = await _MojSoftverService.Get<List<Model.MojSoftver>>(null);
            var Softver = await _SoftverService.GetById<Model.Softver>(_vozilo.SoftverId);

 


            //if (MojSoftverModel.KlijentId == KlijentModel.KlijentId)
            //{
            for (int i = 0; i < MojSoftver.Count; i++)
            {
                if (KlijentModel.KlijentId == MojSoftver[i].KlijentId)
                {
                        if (Softver.SoftverId == MojSoftver[i].SoftverId)
                        {
                            await Application.Current.MainPage.DisplayAlert("Info", "Vec ste kupili aplikaciju!", "Ok");
                            return;
                        }

                }

            }
            var request = new MojSoftverInsertRequest()
            {
                SoftverId = _vozilo.SoftverId,
                KlijentId = KlijentModel.KlijentId,
                ZaposlenikId = Softver.ZaposlenikId,
            };
            var rezervacijaResponse = await _MojSoftverService.Insert<Model.MojSoftver>(request);

            if (rezervacijaResponse != null)
            {
                await Application.Current.MainPage.DisplayAlert("Cestitamo", "Uspjesno ste kupili aplikaciju!", "Ok");
                return;
            }
        }
    }
}
