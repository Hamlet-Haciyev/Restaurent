using DirectList__Backend_Project_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList__Backend_Project_.ViewModels
{
    public class VmContact:VmLayout
    {
        public Contact Contact{ get; set; }
        public Banner Banner { get; set; }
    }
}
