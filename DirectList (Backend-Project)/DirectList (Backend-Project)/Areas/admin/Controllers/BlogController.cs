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
    public class BlogController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public BlogController(AppDbContext appDbContext,IWebHostEnvironment webHostEnvironment)
        {
            _appDbContext = appDbContext;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {

            return View(_appDbContext.Blogs.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Blog blog)
        {

            if (ModelState.IsValid)
            {
                if (blog.ImageFile!=null)
                {
                    if (blog.ImageFile.ContentType=="image/png"|| blog.ImageFile.ContentType == "image/jpeg")
                    {
                        if (blog.ImageFile.Length<=2097152)
                        {
                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmSS") + "-" + blog.ImageFile.FileName;
                            string pathName = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);

                            using (var stream = new FileStream(pathName,FileMode.Create))
                            {
                                blog.ImageFile.CopyTo(stream);

                            }
                            blog.Image = fileName;
                            blog.CreatedDate = DateTime.Now;

                            _appDbContext.Blogs.Add(blog);
                            _appDbContext.SaveChanges();
                            return RedirectToAction("Index");
                        }
                        else
                        {
                            ModelState.AddModelError("", "You can upload only less than 2mb");
                            return View(blog);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "You can upload only .jpeg , .jpg and .png");
                        return View(blog);
                    }
                }
                else
                {
                    return View(blog);

                }
            }

            return View(blog);
        }

        public IActionResult Delete(int? id)
        {

            Blog blog = _appDbContext.Blogs.Find(id);

            if (id!=null)
            {
                string pathFIle = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", blog.Image);
                if (!string.IsNullOrEmpty(blog.Image))
                {
                    if (System.IO.File.Exists(pathFIle))
                    {
                        System.IO.File.Delete(pathFIle);
                    }
                }
            }

            if (blog != null)
            {
                _appDbContext.Blogs.Remove(blog);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(blog);
        }
    }
}
