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
    public class PocetnaViewModel : BaseViewModel
    {
        private readonly APIService _SoftverService = new APIService("Softver");
        private readonly APIService _MojSoftverService = new APIService("MojSoftver");
        private readonly APIService _KlijentService = new APIService("Klijent");
        private readonly APIService _SistemPreporukeService = new APIService("Recommender");
        private readonly APIService _KategorijaService = new APIService("Kategorija");

        public PocetnaViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }



        public ObservableCollection<Softver> SoftverList { get; set; } = new ObservableCollection<Softver>();
        public ObservableCollection<Ocjena> OcjenaList { get; set; } = new ObservableCollection<Ocjena>();
        public ObservableCollection<Softver> RecomendedList { get; set; } = new ObservableCollection<Softver>();
        public ObservableCollection<Kategorija> Kategorija { get; set; } = new ObservableCollection<Kategorija>();



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


        public string _searchTerm = string.Empty;
        public string SearchTerm
        {
            get { return _searchTerm; }
            set
            {
                SetProperty(ref _searchTerm, value);
                if (value != null)
                    InitCommand.Execute(null);
            }
        }
        public bool _SearchVisible = true;
        public bool SearchVisible
        {
            get { return _SearchVisible; }
            set
            {
                SetProperty(ref _SearchVisible, value);
                RecommendedVisible = !_SearchVisible;
            }
        }

        public bool _RecommendedVisible = false;
        public bool RecommendedVisible
        {
            get { return _RecommendedVisible; }
            set { SetProperty(ref _RecommendedVisible, value); }
        }




        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            if (Kategorija.Count == 0)
            {
                APIService.UserID = 1;

                var logovaniKlijent = await _KlijentService.GetById< Model.Klijent > (APIService.UserID);

                var tipSoftveraList = await _KategorijaService.Get<List<Kategorija>>(null);

                foreach (var tipSoftvera in tipSoftveraList)
                {
                    Kategorija.Add(tipSoftvera);
                }
            }


            if (!string.IsNullOrEmpty(SearchTerm))
            {
                SoftverList.Clear();
                var request = new SoftverSearchRequest()
                {
                    Naziv = _searchTerm.Trim(),
                    //Verzija = _searchTerm.Trim()
                };

                var vozila = await _SoftverService.Get<IEnumerable<Model.Softver>>(request);


                foreach (var softver in vozila)
                {
                    SoftverList.Add(softver);
                }
            }
            else
            {
                if (SelectedTKategorija != null)
                {
                    SoftverSearchRequest search = new SoftverSearchRequest();
                    search.TipId = SelectedTKategorija.KategorijaId;
                    //search.Verzija = SelectedTipSoftvera.Naziv

                    var list = await _SoftverService.Get<List<Softver>>(search);
                    var predlozeniSoftver = await _SistemPreporukeService.Get<List<Model.Softver>>(APIService.UserID);


                    SoftverList.Clear();
                    foreach (var softvare in predlozeniSoftver)
                    {
                        SoftverList.Add(softvare);

                    }



                }
                else
                {
                    var list = await _SoftverService.Get<List<Softver>>(null);
                    var predlozeniSoftver = await _SistemPreporukeService.Get<List<Model.Softver>>(APIService.UserID);


                    SoftverList.Clear();
                    foreach (var softvare in list)
                    {
                        SoftverList.Add(softvare);

                    }
                }
            }



        }

    }
}
