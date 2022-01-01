using DirectList__Backend_Project_.Data;
using DirectList__Backend_Project_.Models;
using DirectList__Backend_Project_.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList__Backend_Project_.Areas.admin.Controllers
{
    [Area("admin")]
    public class MenuController : Controller
    {
        private readonly AppDbContext _appDbContext;
        public MenuController(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            List<MenuToRestaurant> menuToRestaurant= _appDbContext.MenuToRestaurants.Include(mt=>mt.Menu).ToList();
            List<Restaurant> restaurants = _appDbContext.Restaurants.ToList();

            VmMenu vmMenu = new VmMenu()
            {
                Restaurants = restaurants,
                MenuToRestaurants = menuToRestaurant
            };
            return View(vmMenu);
        }
        public IActionResult Create()
        {
            ViewBag.Menu = _appDbContext.Menus.ToList();
            ViewBag.Restaurants = _appDbContext.Restaurants.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Create(MenuToRestaurant menuToRestaurant)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.MenuToRestaurants.Add(menuToRestaurant);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(menuToRestaurant);
        }
        public IActionResult Update(int? id)
        {
            MenuToRestaurant menuToRestaurant = _appDbContext.MenuToRestaurants.FirstOrDefault(i=>i.Id==id);

            ViewBag.Menu = _appDbContext.Menus.ToList();
            ViewBag.Restaurants = _appDbContext.Restaurants.ToList();

            return View(menuToRestaurant);
        }
        [HttpPost]
        public IActionResult Update(MenuToRestaurant menuToRestaurant)
        {
            if (ModelState.IsValid)
            {
                _appDbContext.MenuToRestaurants.Update(menuToRestaurant);
                _appDbContext.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Menu = _appDbContext.Menus.ToList();
            ViewBag.Restaurants = _appDbContext.Restaurants.ToList();

            return View(menuToRestaurant);
        }
        public IActionResult Delete(int? id)
        {
            MenuToRestaurant menuToRestaurant = null;

            if (id != null)
            {
                menuToRestaurant = _appDbContext.MenuToRestaurants.Find(id);
            }

            if (menuToRestaurant!=null)
            {
                _appDbContext.MenuToRestaurants.Remove(menuToRestaurant);
                _appDbContext.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
