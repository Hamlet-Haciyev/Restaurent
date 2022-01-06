using DirectList__Backend_Project_.Data;
using DirectList__Backend_Project_.Models;
using DirectList__Backend_Project_.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList__Backend_Project_.Controllers
{
    public class ListingFullWidthController : Controller
    {
        private readonly AppDbContext _appDbContext;

        public ListingFullWidthController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<IActionResult> Index(string searchLocation,int? page)
        {

            if (page == null || page <= 1)
            {
                page = 1;
            }

            Banner banner = await _appDbContext.Banners.FirstOrDefaultAsync(b => b.Page.ToLower() == "listing");
            Setting setting = await  _appDbContext.Settings.FirstOrDefaultAsync();
            List<Social> socials = await _appDbContext.Socials.ToListAsync();
            List<Restaurant> restaurants = await  _appDbContext.Restaurants
                                                            .Include(ri => ri.RestaurantImages)
                                                            .Include(tr => tr.TagToRestaurants).ThenInclude(t => t.Tag)
                                                            .Include(fr => fr.FeaturesToRestaurants).ThenInclude(f => f.Features)
                                                            .Include(mr => mr.MenuToRestaurants).ThenInclude(m => m.Menu)
                                                            .Where(r => (searchLocation != null ? ( r.Location.Contains(searchLocation)) : true))
                                                            .ToListAsync();
            List<string> cartList = Request.Cookies["cart"].Split("-").ToList();


            double itemCount = 3;

            int pageCount = (int)Math.Ceiling(Convert.ToDecimal(restaurants.Count / itemCount));

            ViewBag.PageCount = pageCount;
            ViewBag.Page = page;



            VmRestaurants vmRestaurants = new VmRestaurants()
            {
                Restaurants = restaurants.Skip((int)(page-1) * (int)itemCount).Take((int)itemCount).ToList(),
                Socials = socials,
                Setting = setting,
                Banner= banner,
                cartList = cartList
            };

            return View(vmRestaurants);
        }
        public async Task<IActionResult> Detail(int? id)
        {
            Setting setting = await _appDbContext.Settings.FirstOrDefaultAsync();
            List<Social> socials = await _appDbContext.Socials.ToListAsync();
            Restaurant restaurant = await _appDbContext.Restaurants
                                                            .Include(ri => ri.RestaurantImages)
                                                            .Include(tr => tr.TagToRestaurants).ThenInclude(t => t.Tag)
                                                            .Include(fr => fr.FeaturesToRestaurants).ThenInclude(f => f.Features)
                                                            .Include(mr => mr.MenuToRestaurants).ThenInclude(m => m.Menu)
                                                            .Include(a=>a.Administrators)
                                                            .FirstOrDefaultAsync(i => i.Id == id);

            List<RestaurantComment> restaurantComments = _appDbContext.RestaurantComments
                                                                                .OrderByDescending(c=>c.CreatedDate)
                                                                                .Where(i=>i.RestaurantId == id )
                                                                                .ToList();

            VmRestBook vmRestBook = new VmRestBook()
            {
                Socials = socials,
                Setting = setting,
                Restaurant = restaurant,
                RestaurantComments= restaurantComments
            };

            return View(vmRestBook);
        }
        public IActionResult Reserve()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Reserve(VmRestBook vmRestBook)
        {
            Setting setting = await _appDbContext.Settings.FirstOrDefaultAsync();
            List<Social> socials = await _appDbContext.Socials.ToListAsync();
            List<RestaurantComment> restaurantComments = await _appDbContext.RestaurantComments
                                                                                        .Where(rc=>rc.RestaurantId==vmRestBook.RestBook.RestaurantId)
                                                                                        .ToListAsync();

            VmRestBook vmRestBook1 = new VmRestBook()
            {
                Socials = socials,
                Setting = setting,
                RestaurantComments= restaurantComments
            };
            Restaurant restaurant = await _appDbContext.Restaurants
                                                            .Include(ri => ri.RestaurantImages)
                                                            .Include(r=>r.TagToRestaurants).ThenInclude(tr=>tr.Tag)
                                                            .Include(fr=>fr.FeaturesToRestaurants).ThenInclude(f=>f.Features)
                                                            .Include(mr=>mr.MenuToRestaurants).ThenInclude(m=>m.Menu)
                                                            .Include(a => a.Administrators)
                                                            .FirstOrDefaultAsync(i=>i.Id == vmRestBook.RestBook.RestaurantId);
            if (ModelState.IsValid)
            {
                if (vmRestBook.RestBook.Reserve_Date > DateTime.Now)
                {
                    if (restaurant.StartDate.Hour < vmRestBook.RestBook.Reserve_Date.Hour 
                        && restaurant.EndDate.Hour > vmRestBook.RestBook.Reserve_Date.Hour)
                    {
                        int i = 0;
                        List<RestBook> restBooks = await _appDbContext.RestBooks
                                                              .Where(rb => (rb.Reserve_Date.Day == vmRestBook.RestBook.Reserve_Date.Day)
                                                               &&
                                                               (rb.RestaurantId == vmRestBook.RestBook.RestaurantId))
                                                              .ToListAsync();
                        foreach (var item in restBooks)
                        {
                            i++;
                        }

                        if (restaurant.Capacity >= vmRestBook.RestBook.Person_Count + i)
                        {
                            _appDbContext.RestBooks.Add(vmRestBook.RestBook);
                            _appDbContext.SaveChanges();
                            return RedirectToAction("Index", vmRestBook1);
                        }
                        else
                        {
                            vmRestBook1.Restaurant = restaurant;
                            vmRestBook1.RestBook = vmRestBook.RestBook;
                            if (vmRestBook.RestBook.Person_Count == 1)
                            {
                                ModelState.AddModelError("", "Hormetli musterimiz bu gune bos yerimiz yoxdur.");

                            }
                            else if (restaurant.Capacity < vmRestBook.RestBook.Person_Count + i )
                            {
                                ModelState.AddModelError("", "Hormetli musterimiz bu gune " + vmRestBook.RestBook.Person_Count + " neferlik yerimiz yoxdur.");
                            }
                            return View("detail", vmRestBook1);
                        }
                    }
                    else
                    {
                        vmRestBook1.Restaurant = restaurant;
                        vmRestBook1.RestBook = vmRestBook.RestBook;

                        ModelState.AddModelError("", "Hormetli musterimiz daxil etdiyiniz saatda restoranimiz islemir.");
                        
                        return View("detail", vmRestBook1);
                    }
                }
                else
                {
                    vmRestBook1.Restaurant = restaurant;
                    vmRestBook1.RestBook = vmRestBook.RestBook;

                    ModelState.AddModelError("", "Hormetli musterimiz daxil etdiyiniz zaman dogru deyil.");

                    return View("detail", vmRestBook1);
                }
            }
            else
            {
                vmRestBook1.Restaurant = restaurant;
                vmRestBook1.RestBook = vmRestBook.RestBook;
                ModelState.AddModelError("", "Zehmet olmasa reserve uchun sertleri dogru yerine yetirin.");
                return View("detail", vmRestBook1);
            }
        }
        public IActionResult AddCart(int? id)
        {
            string oldData = Request.Cookies["cart"];
            string newData = "";

            CookieOptions cookieOptions = new CookieOptions()
            {
                Expires = DateTime.Now.AddMonths(6)
            };

            if (string.IsNullOrEmpty(oldData))
            {
                newData = id.ToString();
            }
            else
            {
                List<string> cartList = oldData.Split("-").ToList();

                if (cartList.Any(c=>c == id.ToString()))
                {
                    cartList.Remove(id.ToString());
                    newData = string.Join("-",cartList);
                }
                else
                {
                    newData = oldData + "-" + id;

                }
            }
            Response.Cookies.Append("cart", newData, cookieOptions);

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Cart()
        {
            Banner banner = await _appDbContext.Banners.FirstOrDefaultAsync(b => b.Page.ToLower() == "listing");
            Setting setting = await _appDbContext.Settings.FirstOrDefaultAsync();
            List<Social> socials = await _appDbContext.Socials.ToListAsync();

            string oldData = Request.Cookies["cart"];

            List<string> cartList = null;

            if (!string.IsNullOrEmpty(oldData))
            {
                cartList = oldData.Split("-").ToList();
            }

            List<Restaurant> restaurants1 = new List<Restaurant>();

            if (cartList != null)
            {
                foreach (var item in cartList)
                {
                    Restaurant restaurant = _appDbContext.Restaurants
                                                            .Include(r=>r.RestaurantImages)
                                                            .FirstOrDefault(i => i.Id.ToString() == item);

                    if (restaurant != null)
                    {
                        restaurants1.Add(restaurant);
                    }
                }
            }
            VmRestaurants vmRestaurants = new VmRestaurants()
            {
                Socials = socials,
                Setting = setting,
                Banner = banner,
                Restaurants=restaurants1
            };

            return View(vmRestaurants);
        }
        [HttpPost]
        public async Task<IActionResult> Comment(VmRestBook vmRestBook)
        {
            Setting setting = await _appDbContext.Settings.FirstOrDefaultAsync();
            List<Social> socials = await _appDbContext.Socials.ToListAsync();
            Restaurant restaurant = await _appDbContext.Restaurants
                                                            .Include(ri => ri.RestaurantImages)
                                                            .Include(tr => tr.TagToRestaurants).ThenInclude(t => t.Tag)
                                                            .Include(fr => fr.FeaturesToRestaurants).ThenInclude(f => f.Features)
                                                            .Include(mr => mr.MenuToRestaurants).ThenInclude(m => m.Menu)
                                                            .Include(a => a.Administrators)
                                                            .FirstOrDefaultAsync(i => i.Id == vmRestBook.RestaurantComment.RestaurantId);
            
            List<RestaurantComment> restaurantComments = _appDbContext.RestaurantComments
                                                                    .Where(rc=>rc.RestaurantId==vmRestBook.RestaurantComment.RestaurantId)
                                                                    .ToList();

            VmRestBook vmRestBook1 = new VmRestBook()
            {
                Socials = socials,
                Setting = setting,
                Restaurant = restaurant,
                RestaurantComments = restaurantComments
            };

            if (ModelState.IsValid)
            {

                vmRestBook.RestaurantComment.CreatedDate = DateTime.Now;
                _appDbContext.RestaurantComments.Add(vmRestBook.RestaurantComment);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                vmRestBook1.RestaurantComment = vmRestBook.RestaurantComment;
                return View("detail", vmRestBook1);
            }

        }
    }
}
