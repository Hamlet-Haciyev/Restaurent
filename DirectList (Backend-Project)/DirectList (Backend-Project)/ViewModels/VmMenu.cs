﻿using DirectList__Backend_Project_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList__Backend_Project_.ViewModels
{
    public class VmMenu
    {
        public List<Restaurant> Restaurants { get; set; }
        public List<MenuToRestaurant> MenuToRestaurants { get; set; }
    }
}
