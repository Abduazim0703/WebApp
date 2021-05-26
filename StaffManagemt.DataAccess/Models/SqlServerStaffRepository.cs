using StaffManagment.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StaffManagemt.DataAccess.Models
{
    public class SqlServerStaffRepository : IStaffRepository
    {
        private readonly AppDbContext dbContext;

        public SqlServerStaffRepository(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public Staff Create(Staff staff)
        {
            dbContext.Staffs.Add(staff);
            dbContext.SaveChanges();
            return staff;
        }

        public Staff Delete(int id)
        {
            var staff = dbContext.Staffs.Find(id);
            if(staff != null)
            {
                dbContext.Remove(staff);
                dbContext.SaveChanges();
            }
            return staff;
        }

        public IEnumerable<Staff> GetAll()
        {
            return dbContext.Staffs;
        }

        public Staff GetStaff(int id)
        {
            return dbContext.Staffs.Find(id);
        }

        public Staff Update(Staff updatStaff)
        {
            var staff = dbContext.Staffs.Attach(updatStaff);
            staff.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            dbContext.SaveChanges();
            return updatStaff;
        }
    }
}
