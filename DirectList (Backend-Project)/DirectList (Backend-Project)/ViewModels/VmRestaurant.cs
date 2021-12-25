
using DirectList__Backend_Project_.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList__Backend_Project_.ViewModels
{
    public class VmRestaurant
    {
        public Restaurant Restaurant { get; set; }
        public List<IFormFile> ImagesFiles { get; set; }
    }
}
