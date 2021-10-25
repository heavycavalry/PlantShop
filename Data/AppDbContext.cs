﻿using Microsoft.EntityFrameworkCore;
using PlantShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlantShop.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Plant_Category>().HasKey(pc => new
            {
                pc.PlantId,
                pc.CategoryId
            });


            modelBuilder.Entity<Plant_Category>().HasOne(p => p.Plant).WithMany(pc => pc.Plants_Categories).HasForeignKey(p => p.PlantId);
            modelBuilder.Entity<Plant_Category>().HasOne(c => c.Category).WithMany(pc => pc.Plants_Categories).HasForeignKey(p => p.CategoryId);


            base.OnModelCreating(modelBuilder);

        }

        public DbSet<Plant> Plants { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Plant_Category> Plants_Categories { get; set; }
    }
}