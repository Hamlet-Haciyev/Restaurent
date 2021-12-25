using DirectList__Backend_Project_.Data;
using DirectList__Backend_Project_.Models;
using DirectList__Backend_Project_.ViewModels;
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
    public class RestaurantController : Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public RestaurantController(AppDbContext appDbContext, IWebHostEnvironment webHostEnvironment)
        {
            _appDbContext = appDbContext;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
           return View(_appDbContext.Restaurants.Include(ri=>ri.RestaurantImages).Include(r=>r.TagToRestaurants).ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.Restaurants.Add(restaurant);
                _appDbContext.SaveChanges();

                foreach (var item in restaurant.ImageFiles)
                {
                    if (item.ContentType =="image/png"|| item.ContentType =="image/jpeg")
                    {
                        if (item.Length<=2097152)
                        {
                            string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmSS") + "-" + item.FileName;
                            string path = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                            using (var stream = new FileStream(path,FileMode.Create))
                            {
                                item.CopyTo(stream);
                            }

                            RestaurantImages restaurantImages = new RestaurantImages();
                            restaurantImages.Image = fileName;

                            restaurantImages.RestaurantId = restaurant.Id;

                            _appDbContext.RestaurantImages.Add(restaurantImages);
                            _appDbContext.SaveChanges();
                           
                        }
                    }
                }

                
                return RedirectToAction("Index");
            }

            return View(restaurant);
        }



        public IActionResult Delete(int? id)
        {
            Restaurant restaurant = _appDbContext.Restaurants.Find(id);

            List<RestaurantImages> restaurantImages = _appDbContext.RestaurantImages.Where(ri=>ri.RestaurantId==id).ToList();

            foreach (var item in restaurantImages)
            {
                string path = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", item.Image);

                if (!string.IsNullOrEmpty(item.Image))
                {
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                }

                _appDbContext.RestaurantImages.Remove(item);              
            }
            _appDbContext.SaveChanges();



            _appDbContext.Restaurants.Remove(restaurant);
            _appDbContext.SaveChanges();


            return RedirectToAction("Index");

        }


        #region CreateImages
        //public IActionResult CreateImages()
        //{
        //    ViewBag.Restaurants = _appDbContext.Restaurants.ToList();
        //    return View();
        //}
        //[HttpPost]
        //public IActionResult CreateImages(RestaurantImages restaurantImages)
        //{
        //    if (ModelState.IsValid)
        //    {

        //            if (restaurantImages.ImageFile != null)
        //            {
        //                if (restaurantImages.ImageFile.ContentType == "image/png" || restaurantImages.ImageFile.ContentType == "image/jpeg")
        //                {
        //                    if (restaurantImages.ImageFile.Length <= 2097152)
        //                    {
        //                        string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmSS") + "-" + restaurantImages.ImageFile.FileName;
        //                        string pathName = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);

        //                        using (var stream = new FileStream(pathName, FileMode.Create))
        //                        {
        //                        restaurantImages.ImageFile.CopyTo(stream);

        //                        }
        //                            restaurantImages.Image = fileName;

        //                        _appDbContext.RestaurantImages.Add(restaurantImages);
        //                        _appDbContext.SaveChanges();
        //                        return RedirectToAction("Index");
        //                    }



        //            }

        //        }
        //    }
        //    return View(restaurantImages);
        //}
        #endregion
    }
}
