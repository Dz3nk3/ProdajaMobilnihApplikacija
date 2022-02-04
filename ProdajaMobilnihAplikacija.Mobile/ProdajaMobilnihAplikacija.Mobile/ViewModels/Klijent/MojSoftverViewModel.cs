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
    public class MojSoftverViewModel : BaseViewModel
    {
        private readonly APIService _SoftverService = new APIService("Softver");
        private readonly APIService _KategorijaService = new APIService("Kategorija");
        private readonly APIService _KlijentService = new APIService("Klijent");
        private readonly APIService _MojSoftverService = new APIService("MojSoftver");


        public MojSoftverViewModel()
        {
            InitCommand = new Command(async () => await Init());

        }


        public ObservableCollection<MojSoftver> MojSoftverList { get; set; } = new ObservableCollection<MojSoftver>();

        public ObservableCollection<Softver> SoftverList { get; set; } = new ObservableCollection<Softver>();
        public ObservableCollection<Kategorija> Kategorija { get; set; } = new ObservableCollection<Kategorija>();
        public ObservableCollection<Model.Klijent> KlijentList { get; set; } = new ObservableCollection<Model.Klijent>();

        Kategorija _SelectedTKategorija = null;
        public Kategorija SelectedTKategorija
        {
            get { return _SelectedTKategorija; }
            set
            {
                SetProperty(ref _SelectedTKategorija, value);
                if (value != null)
                {
                    InitCommand.Execute(null);

                }
            }
        }


        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            //uzeti logiranog uzera


            APIService.UserID = 1;

            var logovaniKlijent = await _KlijentService.GetById<Model.Klijent>(APIService.UserID);

            var searchRequest = new MojSoftverSearchRequest();
            searchRequest.KlijentId = logovaniKlijent.KlijentId;

                var MojSofttveri = await _MojSoftverService.Get<List<Model.MojSoftver>>(searchRequest);



            MojSoftverList.Clear();
            foreach (var softvare in MojSofttveri)
            {
                MojSoftverList.Add(softvare);

            }



        }
    }
}
