using StaffManagement.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffManagment.ViewModels
{
    public class HomeEditViewModel : HomeCreateViewModel
    {

        public string ExistingPhotoFilePath { get; set; }
    }
}
