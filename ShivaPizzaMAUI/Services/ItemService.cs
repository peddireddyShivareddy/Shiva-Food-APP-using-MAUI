using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShivaPizzaMAUI.Models;

namespace ShivaPizzaMAUI.Services
{
    public class ItemService
    {
        private readonly static IEnumerable<Items> _items = new 
            List<Items>
        {
            new Items{ 
             Name = "Chicken Biryani",
             Image ="chickenbiryani.png",
             Price = 22
            },
            new Items{
             Name = "Telugu Bojanam",
             Image ="telugubhojanam.png",
             Price = 18
            },
            new Items{
             Name = "Masala Dosa",
             Image ="masaladosa.png",
             Price = 15
            },
            new Items{
             Name = "Panner Butter Masala",
             Image ="paneerbuttermasala.png",
             Price = 18
            },
            new Items{
             Name = "Chicken Tikka Masala",
             Image ="chickentikkamasala.png",
             Price = 20
            },
            new Items{
             Name = "Samosa",
             Image ="samosa.png",
             Price = 10
            },
            new Items{
             Name = "Gajar Halwa",
             Image ="gajar.png",
             Price = 12
            },
            new Items{
             Name = "Khulfi 2pack",
             Image ="kulfi.png",
             Price = 10
            },
            new Items{
             Name = "Kheer",
             Image ="kheer.png",
             Price = 12
            },
            new Items{
             Name = "Mothichoor 5pack",
             Image ="ladoo.png",
             Price = 10
            },


        };

        public IEnumerable<Items> GetAllItems() => _items;

        public IEnumerable<Items> GetPopularItems(int count = 6) => 
            _items.OrderBy(i => Guid.NewGuid())
            .Take(count);

        public IEnumerable<Items> GetItems(string searchTerm) =>
            string.IsNullOrWhiteSpace(searchTerm)
            ? _items
            : _items.Where(i => i.Name.Contains(searchTerm,
                StringComparison.OrdinalIgnoreCase));
    }
}
