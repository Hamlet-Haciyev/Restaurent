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
    public class TagController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public TagController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            return View(_appDbContext.Tags.ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Tag tag)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.Tags.Add(tag);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tag);
        }
        public IActionResult Update(int? id)
        {
            Tag tag = null;

            if (id!=null)
            {
                tag = _appDbContext.Tags.Find(id);
                return View(tag);

            }
            else
            {
                ModelState.AddModelError("","Id is null ,that's why not found Tag");
                return RedirectToAction("Index");
            }

        }
        [HttpPost]
        public IActionResult Update(Tag tag)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.Tags.Update(tag);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tag);
        }
        public IActionResult Delete(int? id)
        {
            Tag tag = null;

            if (id != null)
            {
                tag = _appDbContext.Tags.Find(id);
                _appDbContext.Tags.Remove(tag);
                _appDbContext.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
