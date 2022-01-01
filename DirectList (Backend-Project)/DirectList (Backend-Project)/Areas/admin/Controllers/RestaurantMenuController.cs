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
    public class RestaurantMenuController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public RestaurantMenuController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            return View(_appDbContext.Menus.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Menu menu)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.Menus.Add(menu);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(menu);
        }
        public IActionResult Update(int? id)
        {
            Menu menu = null;

            if (id != null)
            {
                menu = _appDbContext.Menus.Find(id);
                return View(menu);

            }
            else
            {
                ModelState.AddModelError("", "Id is null ,that's why not found Tag");
                return RedirectToAction("Index");
            }

        }
        [HttpPost]
        public IActionResult Update(Menu menu)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.Menus.Update(menu);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(menu);
        }
        public IActionResult Delete(int? id)
        {
            Menu menu = null;

            if (id != null)
            {
                menu = _appDbContext.Menus.Find(id);
                _appDbContext.Menus.Remove(menu);
                _appDbContext.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
