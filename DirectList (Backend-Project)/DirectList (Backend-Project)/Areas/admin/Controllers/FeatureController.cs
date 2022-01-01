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
    public class FeatureController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public FeatureController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            return View(_appDbContext.Features.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Features feature)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.Features.Add(feature);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(feature);
        }
        public IActionResult Update(int? id)
        {
            Features feature = null;

            if (id != null)
            {
                feature = _appDbContext.Features.Find(id);
                return View(feature);

            }
            else
            {
                ModelState.AddModelError("", "Id is null ,that's why not found Tag");
                return RedirectToAction("Index");
            }

        }
        [HttpPost]
        public IActionResult Update(Features feature)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.Features.Update(feature);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(feature);
        }
        public IActionResult Delete(int? id)
        {
            Features feature = null;

            if (id != null)
            {
                feature = _appDbContext.Features.Find(id);
                _appDbContext.Features.Remove(feature);
                _appDbContext.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
