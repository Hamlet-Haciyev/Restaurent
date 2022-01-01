using DirectList__Backend_Project_.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList__Backend_Project_.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions option) :base(option)
        {

        }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Banner> Banners { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogComment> BlogComments { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<CustomUser> CustomUsers { get; set; }
        public DbSet<Features> Features { get; set; }
        public DbSet<FeaturesToRestaurant> FeaturesToRestaurants { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<MenuToRestaurant> MenuToRestaurants { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<RestaurantComment> RestaurantComments { get; set; }
        public DbSet<RestaurantImages> RestaurantImages { get; set; }
        public DbSet<RestBook> RestBooks { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Social> Socials { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<TagToRestaurant> TagToRestaurants { get; set; }
        public DbSet<WorkingProcess> WorkingProcesses { get; set; }
        public DbSet<YourDream> YourDreams { get; set; }
        public DbSet<Administrator> Administrators { get; set; }
    }
}
