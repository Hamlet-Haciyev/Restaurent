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
    public class AboutController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AboutController(AppDbContext appDbContext,IWebHostEnvironment webHostEnvironment)
        {
            _appDbContext = appDbContext;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View(_appDbContext.Abouts.FirstOrDefault());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(About about)
        {
            if (ModelState.IsValid)
            {

                if (about.ImageFile != null)
                {
                    if (about != null)
                    {
                        if (about.ImageFile.ContentType == "image/png" || about.ImageFile.ContentType == "image/jpeg")
                        {
                            if (about.ImageFile.Length <= 2097152)
                            {
                                string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmSS") + "-" + about.ImageFile.FileName;
                                string path = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                                using (var stream = new FileStream(path, FileMode.Create))
                                {
                                    about.ImageFile.CopyTo(stream);
                                }
                                about.Image = fileName;

                                _appDbContext.Abouts.Add(about);
                                _appDbContext.SaveChanges();
                                return RedirectToAction("Index");

                            }
                            else
                            {
                                ModelState.AddModelError("", "Picture must be then less 2mb");
                                return RedirectToAction("Index");
                            }
                        }
                        else
                        {
                            ModelState.AddModelError("","Picture must be png or jpeg format");
                            return RedirectToAction("Index");
                        }
                    }
                }
                else
                {
                    _appDbContext.Abouts.Add(about);
                    _appDbContext.SaveChanges();
                    return RedirectToAction("Index");
                }



                return RedirectToAction("Index");
            }

            return View(about);
        }
        public IActionResult Update(int? id)
        {
            About about = _appDbContext.Abouts.Find(id);
            return View(about);
        }
        [HttpPost]
        public IActionResult Update(About about)
        {
            if (ModelState.IsValid)
            {
                if (about.ImageFile != null)
                {
                    if (about.ImageFile.ContentType == "image/png" || about.ImageFile.ContentType == "image/jpeg")
                    {
                        if (about.ImageFile.Length <= 2097152)
                        {

                            string oldPathFile = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", about.Image);
                            if (!string.IsNullOrEmpty(about.Image))
                            {
                                if (System.IO.File.Exists(oldPathFile))
                                {
                                    System.IO.File.Delete(oldPathFile);
                                }
                            }

                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmSS") + "-" + about.ImageFile.FileName;
                            string path = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                            using (var stream = new FileStream(path, FileMode.Create))
                            {
                                about.ImageFile.CopyTo(stream);
                            }

                            about.Image = fileName;
                            _appDbContext.Abouts.Update(about);
                            _appDbContext.SaveChanges();
                            return RedirectToAction("Index");

                        }
                    }
                }
                else
                {
                    _appDbContext.Abouts.Update(about);
                    _appDbContext.SaveChanges();
                    return RedirectToAction("Index");

                }
            }
           

            return View(about);
        }
        public IActionResult Delete(int? id)
        {
            About about = null;


            if (id != null)
            {
                about = _appDbContext.Abouts.Find(id);
            }

           
                if (!string.IsNullOrEmpty(about.Image))
                {
                string oldPathFile = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", about.Image);

                if (System.IO.File.Exists(oldPathFile))
                    {
                        System.IO.File.Delete(oldPathFile);
                    }
                }
            

            if (about != null)
            {
                _appDbContext.Abouts.Remove(about);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("","about not found");
                return View();
            }

        }
    }
}
