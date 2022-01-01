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
           return View(_appDbContext.Restaurants
                                                .Include(ri=>ri.RestaurantImages)
                                                .Include(r=>r.TagToRestaurants).ThenInclude(t=>t.Tag)
                                                .Include(rf=>rf.FeaturesToRestaurants).ThenInclude(r=>r.Features)
                                                .Include(rm=>rm.MenuToRestaurants).ThenInclude(mr=>mr.Menu)
                                                .ToList());
        }
        public IActionResult Create()
        {
            ViewBag.Tags = _appDbContext.Tags.ToList();
            ViewBag.Features = _appDbContext.Features.ToList();
            

            return View();
        }
        [HttpPost]
        public IActionResult Create(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.Restaurants.Add(restaurant);
                _appDbContext.SaveChanges();

                if (restaurant.ImageFiles!=null)
                {
                    foreach (var item in restaurant.ImageFiles)
                    {
                        if (item != null)
                        {
                            if (item.ContentType == "image/png" || item.ContentType == "image/jpeg")
                            {
                                if (item.Length <= 2097152)
                                {
                                    string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmSS") + "-" + item.FileName;
                                    string path = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);
                                    using (var stream = new FileStream(path, FileMode.Create))
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

                    }
                }
                


                foreach (var item in restaurant.Tags)
                {
                    TagToRestaurant tagToRestaurant = new TagToRestaurant();
                    tagToRestaurant.RestaurantId = restaurant.Id;
                    tagToRestaurant.TagId = item;
                    _appDbContext.TagToRestaurants.Add(tagToRestaurant);
                }
                _appDbContext.SaveChanges();

                foreach (var item in restaurant.Features)
                {
                    FeaturesToRestaurant featuresToRestaurant = new FeaturesToRestaurant();
                    featuresToRestaurant.RestaurantId = restaurant.Id;
                    featuresToRestaurant.FeaturesId = item;
                    _appDbContext.FeaturesToRestaurants.Add(featuresToRestaurant);
                }
                _appDbContext.SaveChanges();


                return RedirectToAction("Index");
            }

            ViewBag.Tags = _appDbContext.Tags.ToList();
            ViewBag.Features = _appDbContext.Features.ToList();
            return View(restaurant);
        }

        public IActionResult Update(int? id)
        {
            Restaurant restaurant = _appDbContext.Restaurants
                                                        .Include(t=>t.TagToRestaurants).ThenInclude(tr=>tr.Tag)
                                                        .FirstOrDefault(i=>i.Id==id);

            restaurant.Tags = _appDbContext.TagToRestaurants.Where(t => t.RestaurantId == id).Select(r=>r.TagId).ToList();
            restaurant.Features = _appDbContext.FeaturesToRestaurants.Where(fr => fr.RestaurantId == id).Select(r => r.FeaturesId).ToList();

            ViewBag.Tags = _appDbContext.Tags.ToList();
            ViewBag.Features = _appDbContext.Features.ToList();

            return View(restaurant);
        }
        [HttpPost]
        public IActionResult Update(Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                
                if (restaurant.ImageFiles != null)
                {
                    // Restaurant Images remove from Uploads Folder
                    List<RestaurantImages> restaurantImages = _appDbContext.RestaurantImages.Where(ri => ri.RestaurantId == restaurant.Id).ToList();
                    foreach (var rtImg in restaurantImages)
                    {
                        string oldPathName = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", rtImg.Image);

                        if (!string.IsNullOrEmpty(oldPathName))
                        {
                            if (System.IO.File.Exists(oldPathName))
                            {
                                System.IO.File.Delete(oldPathName);
                            }
                        }
                        _appDbContext.RestaurantImages.Remove(rtImg);
                    }
                    _appDbContext.SaveChanges();

                    foreach (var item in restaurant.ImageFiles)
                    {

                        if (item.ContentType=="image/png"|| item.ContentType == "image/jpeg")
                        {
                            if (item.Length<=2097152)
                            {
                                string fileName = Guid.NewGuid() + "-" + DateTime.Now.ToString("yyyyMMddHHmmSS") + "-" + item.FileName;
                                string path = Path.Combine(_webHostEnvironment.WebRootPath,"Uploads",fileName);

                                using (var stream = new FileStream(path,FileMode.Create))
                                {
                                    item.CopyTo(stream);
                                }

                                RestaurantImages restaurantImages1 = new RestaurantImages();
                                restaurantImages1.Image = fileName;
                                restaurantImages1.RestaurantId = restaurant.Id;

                                _appDbContext.RestaurantImages.Add(restaurantImages1);
                                _appDbContext.SaveChanges();
                                
                            }
                        }
                    }

                    // (TagToRestaurant) old object  remove from TagToRestaurant
                    List<TagToRestaurant> tagToRestaurants = _appDbContext.TagToRestaurants.Where(tr => tr.RestaurantId == restaurant.Id).ToList();

                    foreach (var item in tagToRestaurants)
                    {
                        _appDbContext.TagToRestaurants.Remove(item);
                    }
                    _appDbContext.SaveChanges();

                    List<FeaturesToRestaurant> featuresToRestaurants = _appDbContext.FeaturesToRestaurants.Where(fr => fr.RestaurantId == restaurant.Id).ToList();

                    foreach (var item in featuresToRestaurants)
                    {
                        _appDbContext.FeaturesToRestaurants.Remove(item);
                    }
                    _appDbContext.SaveChanges();


                    if (restaurant.Tags !=null && restaurant.Tags.Count>0)
                    {
                        foreach (var item in restaurant.Tags)
                        {
                            TagToRestaurant tagToRestaurant = new TagToRestaurant();
                            tagToRestaurant.RestaurantId = restaurant.Id;
                            tagToRestaurant.TagId = item;
                            _appDbContext.TagToRestaurants.Add(tagToRestaurant);
                        }
                        _appDbContext.SaveChanges();
                    }

                    if (restaurant.Features != null && restaurant.Features.Count > 0)
                    {
                        foreach (var item in restaurant.Features)
                        {
                            FeaturesToRestaurant featuresToRestaurant = new FeaturesToRestaurant();
                            featuresToRestaurant.RestaurantId = restaurant.Id;
                            featuresToRestaurant.FeaturesId = item;
                            _appDbContext.FeaturesToRestaurants.Add(featuresToRestaurant);
                        }
                        _appDbContext.SaveChanges();
                    }


                }
                else
                {
                    List<TagToRestaurant> tagToRestaurants = _appDbContext.TagToRestaurants.Where(tr => tr.RestaurantId == restaurant.Id).ToList();

                    foreach (var item in tagToRestaurants)
                    {
                        _appDbContext.TagToRestaurants.Remove(item);
                    }
                    _appDbContext.SaveChanges();

                    if (restaurant.Tags != null && restaurant.Tags.Count > 0)
                    {
                        foreach (var item in restaurant.Tags)
                        {
                            TagToRestaurant tagToRestaurant = new TagToRestaurant();
                            tagToRestaurant.RestaurantId = restaurant.Id;
                            tagToRestaurant.TagId = item;
                            _appDbContext.TagToRestaurants.Add(tagToRestaurant);
                        }
                        _appDbContext.SaveChanges();
                    }

                    List<FeaturesToRestaurant> featuresToRestaurants = _appDbContext.FeaturesToRestaurants.Where(fr => fr.RestaurantId == restaurant.Id).ToList();

                    foreach (var item in featuresToRestaurants)
                    {
                        _appDbContext.FeaturesToRestaurants.Remove(item);
                    }
                    _appDbContext.SaveChanges();

                    if (restaurant.Features != null && restaurant.Features.Count > 0)
                    {
                        foreach (var item in restaurant.Features)
                        {
                            FeaturesToRestaurant featuresToRestaurant = new FeaturesToRestaurant();
                            featuresToRestaurant.RestaurantId = restaurant.Id;
                            featuresToRestaurant.FeaturesId = item;
                            _appDbContext.FeaturesToRestaurants.Add(featuresToRestaurant);
                        }
                        _appDbContext.SaveChanges();
                    }

                }
                _appDbContext.Restaurants.Update(restaurant);
                _appDbContext.SaveChanges();

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
