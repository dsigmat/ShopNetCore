﻿using Microsoft.EntityFrameworkCore;
using ShopNetCore.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopNetCore.Data
{
    public class AppDBContent : DbContext
    {
        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {
        }

        public DbSet<Car> Car { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}