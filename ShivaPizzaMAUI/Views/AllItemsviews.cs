using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShivaPizzaMAUI.Views
{
    [QueryProperty(nameof(f))]
    public partial class AllItemsviews : ObservableObject
    {
        public ObservableCollection<Items> Items { get; set; }

        [ObservableProperty]
        private bool _fromSearch;
    }
}
