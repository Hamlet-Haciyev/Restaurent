﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
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
    }
}
