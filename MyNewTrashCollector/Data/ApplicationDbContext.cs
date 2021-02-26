﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using MyNewTrashCollector.Models;
using Microsoft.AspNetCore.Identity;

namespace MyNewTrashCollector.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<IdentityRole>()
                .HasData(
                   // new IdentityRole
                   //{
                    //    Name = "Admin",
                    //    NormalizedName = "ADMIN"
                    // },

                     new IdentityRole
                     {
                         Name = "Customer",
                         NormalizedName = "CUSTOMER"
                     },

                    new IdentityRole
                    {
                    Name = "Employee",
                    NormalizedName = "EMPLOYEE"


                    }
                );
        
    }
    

        public DbSet<MyNewTrashCollector.Models.Customer> Customer { get; set; }
    

        public DbSet<MyNewTrashCollector.Models.Employee> Employee { get; set; }
    }
}
