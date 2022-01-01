using DirectList__Backend_Project_.Data;
using DirectList__Backend_Project_.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList__Backend_Project_.Areas.admin.Controllers
{
    [Area("admin")]
    public class SettingController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public SettingController(AppDbContext appDbContext, IWebHostEnvironment webHostEnvironment)
        {
            _appDbContext = appDbContext;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            int i = 0;
            foreach (var item in _appDbContext.Settings.ToList())
            {
                i++;
            }
            ViewBag.count = i;


            return View(_appDbContext.Settings.FirstOrDefault());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Setting setting)
        {
            if (ModelState.IsValid)
            {
                if (setting.LogoFile!=null)
                {
                    if (setting.LogoFile.ContentType=="png"|| setting.LogoFile.ContentType == "jpeg")
                    {
                        if (setting.LogoFile.Length<2097152)
                        {

                            _appDbContext.Settings.Add(setting);
                            _appDbContext.SaveChanges();
                            return RedirectToAction("Index");
                        }
                    }
                }
            }
            return View(setting);
        }
        public IActionResult Update(int? id)
        {
            Setting setting = _appDbContext.Settings.FirstOrDefault(i=>i.Id==id);
            return View(setting);
        }
        [HttpPost]
        public IActionResult Update(Setting setting)
        {

            if (ModelState.IsValid)
            {
                if (setting.LogoFile != null)
                {
                    if (setting.LogoFile.ContentType == "png" || setting.LogoFile.ContentType == "jpeg")
                    {
                        if (setting.LogoFile.Length < 2097152)
                        {

                            _appDbContext.Settings.Update(setting);
                            _appDbContext.SaveChanges();
                            return RedirectToAction("Index");
                        }
                    }
                }
            }

            return View(setting);
        }

        public IActionResult Delete(int? id)
        {
            Setting setting = null;

            if (id!=null)
            {
                setting = _appDbContext.Settings.Find(id);
            }
            if (setting != null)
            {
                if (!string.IsNullOrEmpty(setting.Logo))
                {
                    string oldPathFile = Path.Combine(_webHostEnvironment.WebRootPath,"Uploads",setting.Logo);

                    if (System.IO.File.Exists(oldPathFile))
                    {
                        System.IO.File.Delete(oldPathFile);
                    }
                    _appDbContext.Settings.Remove(setting);
                    _appDbContext.SaveChanges();
                    return RedirectToAction("Index");
                }
            }



            return View();
        }
    }
}
