﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpinionAte.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options){}
        public DbSet<Restaurant> Restaurants { get; set; }

        public DbSet<Dish> Dishes { get; set; }
    }
}
