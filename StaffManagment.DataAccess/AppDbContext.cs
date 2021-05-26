using Microsoft.EntityFrameworkCore;
using StaffManagemt.DataAccess.Models;
using StaffManagment.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StaffManagemt.DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :
            base(options)
        {

        }

        public DbSet<Staff> Staffs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
