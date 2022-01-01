using DirectList__Backend_Project_.Data;
using DirectList__Backend_Project_.Models;
using DirectList__Backend_Project_.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList__Backend_Project_.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public AboutController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            About about = _appDbContext.Abouts.FirstOrDefault();
            Setting setting = _appDbContext.Settings.FirstOrDefault();
            List<Social> socials = _appDbContext.Socials.ToList();
            List<WorkingProcess> workingProcesses = _appDbContext.WorkingProcesses.ToList();
            Banner banner = _appDbContext.Banners.FirstOrDefault(b=>b.Page.ToLower()=="about");
            VmAbout vmAbout = new VmAbout()
            {
                Setting = setting,
                Socials = socials,
                About = about,
                WorkingProcess= workingProcesses,
                Banner= banner
            };
            return View(vmAbout);
        }
    }
}
