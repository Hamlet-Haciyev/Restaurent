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
        public async Task<IActionResult> Index()
        {
            Banner banner = await _appDbContext.Banners.FirstOrDefaultAsync(b => b.Page.ToLower() == "listing");
            Setting setting = await  _appDbContext.Settings.FirstOrDefaultAsync();
            List<Social> socials = await _appDbContext.Socials.ToListAsync();
            List<Restaurant> restaurants = await  _appDbContext.Restaurants
                                                            .Include(ri => ri.RestaurantImages)
                                                            .Include(tr => tr.TagToRestaurants).ThenInclude(t => t.Tag)
                                                            .Include(fr => fr.FeaturesToRestaurants).ThenInclude(f => f.Features)
                                                            .Include(mr => mr.MenuToRestaurants).ThenInclude(m => m.Menu)
                                                            .ToListAsync();

            string oldData = Request.Cookies["cart"];

            List<string> cartList = null;

            if (!string.IsNullOrEmpty(oldData))
            {
                cartList  = oldData.Split("-").ToList();
            }

            List<Restaurant> restaurants1 = new List<Restaurant>();

            if (cartList!=null)
            {
                foreach (var item in cartList)
                {
                    Restaurant restaurant = _appDbContext.Restaurants.FirstOrDefault(i => i.Id.ToString() == item);

                    if (restaurant != null)
                    {
                        restaurants1.Add(restaurant);
                    }
                }
            }

            VmRestaurants vmRestaurants = new VmRestaurants()
            {
                Restaurants = restaurants,
                Socials = socials,
                Setting = setting,
                Banner= banner
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
            VmRestBook vmRestBook = new VmRestBook()
            {
                Socials = socials,
                Setting = setting,
                Restaurant = restaurant
            };

            return View(vmRestBook);
        }
        public IActionResult Reserve()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Reserve(VmRestBook vmRestBook)
        {
            Setting setting = _appDbContext.Settings.FirstOrDefault();
            List<Social> socials = _appDbContext.Socials.ToList();

            VmRestBook vmRestBook1 = new VmRestBook()
            {
                Socials = socials,
                Setting = setting,

            };

            if (ModelState.IsValid)
            {
                if (vmRestBook.RestBook.Reserve_Date > DateTime.Now)
                {
                    vmRestBook.RestBook.RestaurantId = vmRestBook.Restaurant.Id;
                    _appDbContext.RestBooks.Add(vmRestBook.RestBook);
                    _appDbContext.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {

                }
            }
            return View("Index", vmRestBook);
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

    }
}
