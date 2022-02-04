using ProdajaMobilnihAplikacija.Mobile.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProdajaMobilnihAplikacija.Mobile.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Pocetna, Title="Pocetna" },
                new HomeMenuItem {Id = MenuItemType.Softver, Title="Komentari aplikacija" },
                //new HomeMenuItem {Id = MenuItemType.Racun, Title="Racun" },
                new HomeMenuItem {Id = MenuItemType.MojSoftver, Title="Moje aplikacije" },
                //new HomeMenuItem {Id = MenuItemType.MojOcjeneIKomentari, Title="MojiKomentari" },
                new HomeMenuItem {Id = MenuItemType.PostavkeProfila, Title="PostavkeProfila" },
                new HomeMenuItem {Id = MenuItemType.About, Title="About" },
                new HomeMenuItem {Id = MenuItemType.Odjava, Title="Odjava" }
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}