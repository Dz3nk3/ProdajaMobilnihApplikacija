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
    public class OcjeneIKomentariViewModel:BaseViewModel
    {
        private readonly APIService _SoftverService = new APIService("Softver");
        private readonly APIService _KategorijaService = new APIService("Kategorija");
        private readonly APIService _OcjenaService = new APIService("Ocjena");
        private readonly APIService _KlijentService = new APIService("Klijent");



        public OcjeneIKomentariViewModel()
        {
            InitCommand = new Command(async () => await Init());

        }

        public ObservableCollection<Ocjena> OcjenaKomentariList { get; set; } = new ObservableCollection<Ocjena>();

        public ObservableCollection<Softver> SoftverList { get; set; } = new ObservableCollection<Softver>();
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


        public ICommand InitCommand { get; set; }

        public async Task Init()
        {

            APIService.UserID = 1;

            var logovaniKlijent = await _KlijentService.GetById<Model.Klijent>(APIService.UserID);

            var OcjenaList = await _OcjenaService.Get<List<Ocjena>>(logovaniKlijent.KlijentId);

            foreach (var ocjena in OcjenaList)
            {
                OcjenaKomentariList.Add(ocjena);
            }

           

        }


    }
}
