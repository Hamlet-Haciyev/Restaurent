using DirectList__Backend_Project_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList__Backend_Project_.ViewModels
{
    public class VmRestBook : VmLayout
    {
        public Restaurant Restaurant { get; set; }
        public RestBook RestBook { get; set; }
    }
}
