
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
    public class ContactController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ContactController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            Setting setting = _appDbContext.Settings.FirstOrDefault();
            List<Social> socials = _appDbContext.Socials.ToList();
            Banner banner = _appDbContext.Banners.FirstOrDefault(b => b.Page.ToLower() == "contact");
            VmContact vmContact = new VmContact()
            {
                Setting = setting,
                Socials = socials,
                Banner=banner
            };

            return View(vmContact);
        }
        public IActionResult Message()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Message(VmContact vmContact)
        {
            if (ModelState.IsValid)
            {

                vmContact.Contact.CreatedDate = DateTime.Now;
                _appDbContext.Contacts.Add(vmContact.Contact);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
                
            }
            Setting setting = _appDbContext.Settings.FirstOrDefault();
            List<Social> socials = _appDbContext.Socials.ToList();
            Banner banner = _appDbContext.Banners.FirstOrDefault(b => b.Page.ToLower() == "contact");
            VmContact vmContact1 = new VmContact()
            {
                Setting = setting,
                Socials = socials,
                Contact = vmContact.Contact,
                Banner = banner
            };


            return View("Index", vmContact1);
        }
    }
}
