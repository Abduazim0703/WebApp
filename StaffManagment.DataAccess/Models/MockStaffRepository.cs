using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffManagment.Models
{
    public class MockStaffRepository : IStaffRepository
    {
        private List<Staff> _staffs = null;

        public MockStaffRepository()
        {
            _staffs = new List<Staff>()
            {
                new Staff(){Id=1, FirstName="Afrosiyob", LastName="Abduganiyev", Email="Afrosiyob@gmail.com",Department=Departments.Admin},
                new Staff(){Id=2, FirstName="Shahzod", LastName="Abdullayev", Email="Shahzod@gmail.com",Department=Departments.HR},
                new Staff(){Id=3, FirstName="Dilshod", LastName="Hakimov", Email="Hakimov@gmail.com",Department=Departments.Sales}

        };
        }

        public Staff Create(Staff staff)
        {
            staff.Id = _staffs.Max(s => s.Id) + 1;
            _staffs.Add(staff);
            return staff;
        }

        public Staff Delete(int id)
        {
            var staff = _staffs.FirstOrDefault(s => s.Id.Equals(id));
            if(staff != null)
            {
                _staffs.Remove(staff);
            }
            return staff;
        }

        public IEnumerable<Staff> GetAll()
        {
            return _staffs;
        }

        public Staff GetStaff(int id)
        {
           return _staffs.FirstOrDefault(staff => staff.Id.Equals(id));
        }

        public Staff Update(Staff updateStaff)
        {
            var staff = _staffs.FirstOrDefault(s => s.Id.Equals(updateStaff.Id));
            if (staff != null)
            {
                staff.FirstName = updateStaff.FirstName;
                staff.LastName = updateStaff.LastName;
                staff.Email = updateStaff.Email;
                staff.Department = updateStaff.Department;
            }

            return staff;
        }
    }
}
