using DirectList__Backend_Project_.Data;
using DirectList__Backend_Project_.Models;
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
            return View();
        }
        public IActionResult Message()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Message(Contact contact)
        {
            if (ModelState.IsValid)
            {
                
                contact.CreatedDate = DateTime.Now;
                _appDbContext.Contacts.Add(contact);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
                
            }

            
            return View("Index",contact);
        }
    }
}
