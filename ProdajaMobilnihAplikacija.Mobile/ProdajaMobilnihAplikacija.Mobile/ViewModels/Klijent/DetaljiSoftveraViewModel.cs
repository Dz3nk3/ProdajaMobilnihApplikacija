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
    public  class DetaljiSoftveraViewModel
    {
        private readonly APIService _SoftverService = new APIService("Softver");
        private readonly APIService _OcjenaService = new APIService("Ocjena");
        private readonly APIService _KategorijaService = new APIService("Kategorija");
        private readonly APIService _MojSoftverService = new APIService("MojSoftver");

        private Softver _softverDetalji = null;


        public DetaljiSoftveraViewModel()
        {
            _softverDetalji = null;
            InitCommand = new Command(() => Init());
        }

        public DetaljiSoftveraViewModel(Softver softver)
        {
            _softverDetalji = softver;
            InitCommand = new Command(() => Init());
            //SpecifikacijeCommand = new Command(async () => await Specifikacije());

        }


        public ObservableCollection<Softver> SoftverList { get; set; } = new ObservableCollection<Softver>();
        public ObservableCollection<MojSoftver> MojSoftverList { get; set; } = new ObservableCollection<MojSoftver>();



        public ICommand InitCommand { get; set; }

        public async void Init()
        {

            SoftverList.Clear();

            var MojSoftverSearchReqeuest = new MojSoftverSearchRequest();
            MojSoftverSearchReqeuest.SoftverId = _softverDetalji.SoftverId;

            var listaMojSoftver = await _MojSoftverService.Get<List<Model.MojSoftver>>(MojSoftverSearchReqeuest);

            foreach (var item in listaMojSoftver)
            {
                MojSoftverList.Add(item);
            }

            SoftverList.Add(_softverDetalji);

        }
    
    }
}
