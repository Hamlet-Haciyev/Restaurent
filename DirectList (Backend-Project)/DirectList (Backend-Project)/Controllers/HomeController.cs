using DirectList__Backend_Project_.Data;
using DirectList__Backend_Project_.Models;
using DirectList__Backend_Project_.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList__Backend_Project_.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            Setting setting = _appDbContext.Settings.FirstOrDefault();
            List<Social> socials = _appDbContext.Socials.ToList();
            VmLayout vmLayout = new VmLayout()
            {
                Setting = setting,
                Socials = socials

            };

            return View(vmLayout);
        }

        
    }
}
