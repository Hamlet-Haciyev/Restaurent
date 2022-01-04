using DirectList__Backend_Project_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList__Backend_Project_.ViewModels
{
    public class VmRestaurants :VmLayout
    {
        public List<Restaurant> Restaurants { get; set; }
        public Banner Banner { get; set; }
        public List<string> cartList { get; set; }
        public RestaurantComment RestaurantComment { get; set; }
    }
}
