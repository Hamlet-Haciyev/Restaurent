using DirectList__Backend_Project_.Data;
using DirectList__Backend_Project_.Models;
using DirectList__Backend_Project_.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList__Backend_Project_.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public HomeController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IActionResult Index()
        {
            Setting setting = _appDbContext.Settings.FirstOrDefault();
            List<Social> socials = _appDbContext.Socials.ToList();
            List<YourDream> yourDreams = _appDbContext.YourDreams.ToList();
            List<Blog> blogs = _appDbContext.Blogs.OrderByDescending(o=>o.CreatedDate).ToList();
            List<Restaurant> restaurants = _appDbContext.Restaurants.Include(r=>r.RestaurantImages).ToList();
            List<RestBook> restBooks = _appDbContext.RestBooks.ToList();
            List<Restaurant> mostVisitedRestaurants = _appDbContext.Restaurants
                                                                        .Include(r => r.RestaurantImages)
                                                                        .Take(4)
                                                                        .ToList();


            VmHome vmHome = new VmHome()
            {
                Setting = setting,
                Socials = socials,
                YourDreams=yourDreams,
                Blogs=blogs,
                Restaurants =restaurants,
               MostVisitedRestaurants= mostVisitedRestaurants
            };

            return View(vmHome);
        }

        
    }
    class Cust
    {
        public int Count { get; set; }
        public int Id { get; set; }
    }
}
