using DirectList__Backend_Project_.Data;
using DirectList__Backend_Project_.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList__Backend_Project_.Areas.admin.Controllers
{
    [Area("admin")]
    public class AdministratorController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AdministratorController(AppDbContext appDbContext, IWebHostEnvironment webHostEnvironment)
        {
            _appDbContext = appDbContext;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View(_appDbContext.Administrators.Include(a=>a.Restaurant).ToList());
        }

        public IActionResult Create()
        {
            ViewBag.Restaurants = _appDbContext.Restaurants.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Administrator administrator)
        {
            if (ModelState.IsValid)
            {

                if (administrator.ImageFile != null)
                {
                    if (administrator != null)
                    {
                        if (administrator.ImageFile.ContentType == "image/png" || administrator.ImageFile.ContentType == "image/jpeg")
                        {
                            if (administrator.ImageFile.Length <= 2097152)
                            {
                                string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmSS") + "-" + administrator.ImageFile.FileName;
                                string path = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                                using (var stream = new FileStream(path, FileMode.Create))
                                {
                                    administrator.ImageFile.CopyTo(stream);
                                }
                                administrator.Image = fileName;

                                _appDbContext.Administrators.Add(administrator);
                                _appDbContext.SaveChanges();
                                return RedirectToAction("Index");

                            }
                            else
                            {
                                ViewBag.Restaurants = _appDbContext.Restaurants.ToList();
                                ModelState.AddModelError("", "Picture must be then less 2mb");
                                return RedirectToAction("Index");
                            }
                        }
                        else
                        {
                            ViewBag.Restaurants = _appDbContext.Restaurants.ToList();
                            ModelState.AddModelError("", "Picture must be png or jpeg format");
                            return RedirectToAction("Index");
                        }
                    }
                }
                else
                {
                     ViewBag.Restaurants = _appDbContext.Restaurants.ToList();
                    _appDbContext.Administrators.Add(administrator);
                    _appDbContext.SaveChanges();
                    return RedirectToAction("Index");
                }



                return RedirectToAction("Index");
            }
            ViewBag.Restaurants = _appDbContext.Restaurants.ToList();
            return View(administrator);
        }
        public IActionResult Update(int? id)
        {
            Administrator administrator = _appDbContext.Administrators.Find(id);
            ViewBag.Restaurants = _appDbContext.Restaurants.ToList();

            return View(administrator);
        }
        [HttpPost]
        public IActionResult Update(Administrator administrator)
        {
            if (ModelState.IsValid)
            {
                if (administrator.ImageFile != null)
                {
                    if (administrator.ImageFile.ContentType == "image/png" || administrator.ImageFile.ContentType == "image/jpeg")
                    {
                        if (administrator.ImageFile.Length <= 2097152)
                        {

                            string oldPathFile = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", administrator.Image);
                            if (!string.IsNullOrEmpty(administrator.Image))
                            {
                                if (System.IO.File.Exists(oldPathFile))
                                {
                                    System.IO.File.Delete(oldPathFile);
                                }
                            }

                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmSS") + "-" + administrator.ImageFile.FileName;
                            string path = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                            using (var stream = new FileStream(path, FileMode.Create))
                            {
                                administrator.ImageFile.CopyTo(stream);
                            }

                            administrator.Image = fileName;
                            _appDbContext.Administrators.Update(administrator);
                            _appDbContext.SaveChanges();
                            return RedirectToAction("Index");

                        }
                    }
                }
                else
                {
                    ViewBag.Restaurants = _appDbContext.Restaurants.ToList();

                    _appDbContext.Administrators.Update(administrator);
                    _appDbContext.SaveChanges();
                    return RedirectToAction("Index");

                }
            }

            ViewBag.Restaurants = _appDbContext.Restaurants.ToList();

            return View(administrator);
        }
        public IActionResult Delete(int? id)
        {
            Administrator administrator = null;


            if (id != null)
            {
                administrator = _appDbContext.Administrators.Find(id);
            }


            if (!string.IsNullOrEmpty(administrator.Image))
            {
                string oldPathFile = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", administrator.Image);

                if (System.IO.File.Exists(oldPathFile))
                {
                    System.IO.File.Delete(oldPathFile);
                }
            }


            if (administrator != null)
            {
                _appDbContext.Administrators.Remove(administrator);
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
