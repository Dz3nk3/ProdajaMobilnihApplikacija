using ProdajaMobilnihAplikacija.Model;
using ProdajaMobilnihAplikacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProdajaMobilnihAplikacija.Mobile.ViewModels.Klijent
{
    public class OstaviKomentarViewModel : BaseViewModel
    {
        private readonly APIService _klijentService = new APIService("Klijent");
        private readonly APIService _MojSoftverService = new APIService("MojSoftver");
        private readonly APIService _ZaposlenikService = new APIService("Zaposlenik");

        public int _softverid = 0;
        public MojSoftver _softver = null;
        public OstaviKomentarViewModel(MojSoftver softver)
        {
            _softver = softver;
            InitCommand = new Command(async () => await Init());
            OcjeniCommand = new Command(async () => await Ocjeni());
        }

        //public OstaviKomentarViewModel(int id)
        //{
        //    InitCommand = new Command(async () => await Init());

        //    _softverid = id;
        //}


        int _Ocjena = 0;
        public int Ocjena
        {
            get { return _Ocjena; }
            set
            { SetProperty(ref _Ocjena, value); }
        }

        string _Komentar = string.Empty;
        public string Komentar
        {
            get { return _Komentar; }
            set
            { SetProperty(ref _Komentar, value); }
        }



        public bool IsUpdate = false;
        public int ocjenaID = 0;

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            ////po potrebi liniju koda 58 zakomentarisati!!!
            //APIService.UserID = 1;

            //if (APIService.UserID != 0)
            //{
            //    var KlijentModel = await _klijentService.GetById<Model.Klijent>(APIService.UserID);
            //}

            //var mojSoftver = await _MojSoftverService.GetById<Model.MojSoftver>(APIService.UserID);

            ////var zaposlenik = await _ZaposlenikService.GetById<Model.Zaposlenik>(mojSoftver.ZaposlenikId);

            //var requestOcjena = new MojSoftverInsertRequest()
            //{
            //    Ocjena = Ocjena,
            //    Komentar = Komentar,
            //    ZaposlenikId = mojSoftver.ZaposlenikId,
            //    SoftverId = mojSoftver.SoftverId,
            //    KlijentId = mojSoftver.KlijentId
            //};

            //var modelMojSoftver = await _MojSoftverService.Insert<Model.MojSoftver>(requestOcjena);

            //if (modelMojSoftver != null)
            //{
            //    await Application.Current.MainPage.DisplayAlert("Notifikacija", "Rezervacija uspješno ocijenjena!", "Ok");

            //}
            //await Application.Current.MainPage.DisplayAlert("Notifikacija", "Ostavite komentar!", "Ok");

        }


        public ICommand OcjeniCommand { get; set; }
        public async Task Ocjeni()
        {
            //po potrebi liniju koda ispod, zakomentarisati!!!
            APIService.UserID = 1;

            if (APIService.UserID != 0)
            {
                var KlijentModel = await _klijentService.GetById<Model.Klijent>(APIService.UserID);
            }

            var mojSoftver = await _MojSoftverService.GetById<Model.MojSoftver>(APIService.UserID);

            //var zaposlenik = await _ZaposlenikService.GetById<Model.Zaposlenik>(mojSoftver.ZaposlenikId);

            var requestOcjena = new MojSoftveUpsertRequest()
            {
                Ocjena = Ocjena,
                Komentar = Komentar
            };

            var modelMojSoftver = await _MojSoftverService.Update<Model.MojSoftver>(_softver.MojSoftverId, requestOcjena);

            if (modelMojSoftver != null)
            {
                await Application.Current.MainPage.DisplayAlert("Notifikacija", "Uspjesno ste ostavili dojam!", "Ok");

            }
        }
    }
}
