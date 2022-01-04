using DirectList__Backend_Project_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList__Backend_Project_.ViewModels
{
    public class VmHome:VmLayout
    {
        public List<YourDream> YourDreams { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Restaurant> Restaurants { get; set; }
        public List<Restaurant> MostVisitedRestaurants { get; set; }

    }
}
