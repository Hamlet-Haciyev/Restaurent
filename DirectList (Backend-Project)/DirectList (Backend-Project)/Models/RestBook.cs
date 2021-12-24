using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList__Backend_Project_.Models
{
    public class RestBook
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(80)]
        public string FullName { get; set; }

        public DateTime Reserve_Date { get; set; }
        public byte Person_Count { get; set; }
        [MaxLength(30)]
        public string Series_Number { get; set; }

        [ForeignKey("Restaurant")]
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }

    }
}
