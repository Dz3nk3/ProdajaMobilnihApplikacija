using System;

using ProdajaMobilnihAplikacija.Mobile.Models;

namespace ProdajaMobilnihAplikacija.Mobile.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
