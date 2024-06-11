using ShivaPizzaMAUI.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShivaPizzaMAUI.Models;
using CommunityToolkit.Mvvm.ComponentModel;

namespace ShivaPizzaMAUI.Views
{
    public partial class HomeView : ObservableObject
    {
        private readonly ItemService _itemService;
        public HomeView(ItemService itemService) { 
            _itemService = itemService;
            Items = new(_itemService.GetPopularItems());
        
        }
        public ObservableCollection<Items> Items { get; set; }
    }
}
