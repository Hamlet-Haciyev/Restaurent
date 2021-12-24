using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList__Backend_Project_.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(150)]
        public string Name { get; set; }
        [MaxLength(2000)]
        public string About { get; set; }
        [MaxLength(250)]
        public string Address { get; set; }
        [MaxLength(30)]
        public string Phone_1 { get; set; }
        [MaxLength(30)]
        public string Phone_2 { get; set; }
        [MaxLength(30)]
        public string Phone_3 { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        [MaxLength(250)]
        public string Location { get; set; }
        [MaxLength(1000)]
        public string Location_Note { get; set; }
        public DateTime CreatedDate { get; set; }

        public List<MenuToRestaurant> MenuToRestaurants { get; set; }
        public List<TagToRestaurant> TagToRestaurants { get; set; }
        public List<FeaturesToRestaurant> FeaturesToRestaurants { get; set; }
        public List<RestaurantImages> RestaurantImages { get; set; }
        public List<RestBook> RestBooks { get; set; }
        public List<RestaurantComment> RestaurantComments { get; set; }
    }
}
