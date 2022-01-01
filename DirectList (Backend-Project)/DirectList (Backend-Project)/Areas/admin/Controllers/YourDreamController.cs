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
    public class YourDreamController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public YourDreamController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            return View(_appDbContext.YourDreams.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(YourDream yourDream)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.YourDreams.Add(yourDream);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(yourDream);
        }
        public IActionResult Update(int? id)
        {
            YourDream yourDream = _appDbContext.YourDreams.Find(id);
            return View(yourDream);
        }
        [HttpPost]
        public IActionResult Update(YourDream yourDream)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.YourDreams.Update(yourDream);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(yourDream);
        }
        public IActionResult Delete(int? id)
        {
            YourDream yourDream = null;


            if (id != null)
            {
                yourDream = _appDbContext.YourDreams.Find(id);
            }


            if (yourDream != null)
            {
                _appDbContext.YourDreams.Remove(yourDream);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "about not found");
                return View();
            }

        }
    }
}
