using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffManagment.Models
{
    public interface IStaffRepository
    {
        Staff GetStaff(int id);

        IEnumerable<Staff> GetAll();

        Staff Create(Staff staff);

        Staff Update(Staff staff);

        Staff Delete(int id);
    }

    
}
