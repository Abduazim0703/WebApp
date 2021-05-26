using Microsoft.EntityFrameworkCore;
using StaffManagment.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StaffManagemt.DataAccess.Models
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Staff>().HasData(
                new Staff
                {
                    Id = 1,
                    FirstName = "Samsung",
                    LastName = "230",
                    Email = "Afroleo@gmail.com",
                    Department = Departments.Admin
                },
                new Staff
                {
                    Id = 2,
                    FirstName = "Xiaomi",
                    LastName = "330",
                    Email = "Shahzod@gmail.com",
                    Department = Departments.Marketing
                }
                );
        }
    }
}
