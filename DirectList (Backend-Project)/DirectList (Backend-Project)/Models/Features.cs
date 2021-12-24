using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList__Backend_Project_.Models
{
    public class Features
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(80)]
        public string Name { get; set; }
        public List<FeaturesToRestaurant> FeaturesToRestaurants { get; set; }
    }
}
