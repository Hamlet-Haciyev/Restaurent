﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DirectList__Backend_Project_.Models
{
    public class Setting
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(250)]
        public string Logo { get; set; }
        [NotMapped]
        public IFormFile LogoFile { get; set; }
        [MaxLength(500)]
        public string Addresss { get; set; }
        [MaxLength(30)]
        public string Phone { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(500)]
        public string About { get; set; }
        [MaxLength(500)]
        public string Addresss_2 { get; set; }
        [MaxLength(30)]
        public string Phone_2 { get; set; }
        [MaxLength(50)]
        public string Email_2 { get; set; }


    }
}
