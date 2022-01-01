using DirectList__Backend_Project_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList__Backend_Project_.ViewModels
{
    public class VmAbout:VmLayout
    {
        public About About { get; set; }
        public List<WorkingProcess> WorkingProcess { get; set; }
        public Banner Banner { get; set; }
    }
}
