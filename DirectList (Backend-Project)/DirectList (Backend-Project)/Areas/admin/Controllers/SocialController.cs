using DirectList__Backend_Project_.Data;
using DirectList__Backend_Project_.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList__Backend_Project_.Areas.admin.Controllers
{
    [Area("admin")]

    public class SocialController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public SocialController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            return View(_appDbContext.Socials.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Social social)
        {

            if (ModelState.IsValid)
            {
       
                _appDbContext.Socials.Add(social);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Icon and Link is important data");
            }

            return View(social);
        }

        public IActionResult Update(int? id)
        {
            Social social = _appDbContext.Socials.Find(id);


            return View(social);
        }
        [HttpPost]
        public IActionResult Update(Social social)
        {
            if (ModelState.IsValid)
            {   
               
                    _appDbContext.Socials.Update(social);
                    _appDbContext.SaveChanges();
                    return RedirectToAction("Index");
                
            }

            return View(social);
        }

        public IActionResult Delete(int? id)
        {

            Social social = _appDbContext.Socials.Find(id);

            
            if (social != null)
            {
                _appDbContext.Socials.Remove(social);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(social);
        }
    }
}
