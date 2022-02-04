using ProdajaMobilnihAplikacija.Mobile.Views;
using ProdajaMobilnihAplikacija.Mobile.Views.Klijent;
using ProdajaMobilnihAplikacija.Model;
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
    public class MojiKomentariViewModel : BaseViewModel
    {

        string _ime = string.Empty;


        private readonly APIService _OcjenaService = new APIService("Ocjena");
        private readonly APIService _MojSoftverService = new APIService("MojSoftver");
        private readonly APIService _KlijentService = new APIService("Klijent");



        public MojiKomentariViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public ObservableCollection<Model.Ocjena> OcjenaList { get; set; } = new ObservableCollection<Model.Ocjena>();
        public ObservableCollection<MojSoftver> MojSoftverList { get; set; } = new ObservableCollection<MojSoftver>();



        public ICommand InitCommand { get; set; }

        public async Task Init()
        {

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
