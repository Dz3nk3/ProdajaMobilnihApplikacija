using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using ProdajaMobilnihAplikacija.Mobile.Models;
using ProdajaMobilnihAplikacija.Mobile.Views;
using System.Windows.Input;
using System.Collections.Generic;
using ProdajaMobilnihAplikacija.Model.Requests;

namespace ProdajaMobilnihAplikacija.Mobile.ViewModels
{
    public class ItemsViewModel : BaseViewModel
    {
        private readonly APIService _SoftverService = new APIService("Softver");

        public ObservableCollection<Item> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public ItemsViewModel()
        {
            Title = "Browse";
            Items = new ObservableCollection<Item>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
 
            InitCommad = new Command(async () => await Init());

            MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            {
                var newItem = item as Item;
                Items.Add(newItem);
                await DataStore.AddItemAsync(newItem);
            });
        }



        public string _searchTerm = string.Empty;
        public string SearchTerm
        {
            get { return _searchTerm; }
            set
            {
                SetProperty(ref _searchTerm, value);
                if (value != null)
                    InitCommad.Execute(null);
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


        public ObservableCollection<Model.Softver> SoftverList { get; set; } = new ObservableCollection<Model.Softver>();



        public ICommand InitCommad { get; set; }
        public async Task Init()
        {
            var list = await _SoftverService.Get<List<Model.Softver>>(null);


            SoftverList.Clear();
            foreach (var softver in list)
            {
                SoftverList.Add(softver);
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
        }





        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }






    }
}