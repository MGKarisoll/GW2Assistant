using System;

using GW2Assistant.Apps.MobileClient.Models;

namespace GW2Assistant.Apps.MobileClient.ViewModels
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
