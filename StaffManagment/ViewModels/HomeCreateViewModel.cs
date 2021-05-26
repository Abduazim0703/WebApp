using Microsoft.AspNetCore.Http;
using StaffManagement.Attributes;
using StaffManagment.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StaffManagment.ViewModels
{
    public class HomeCreateViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "First Name")]
        [MaxLength(20)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        [MaxLength(20)]
        public string LastName { get; set; }

        [Required]
        [Display(Name = "Email")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email is not valid")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Department")]
        public Departments? Deparment { get; set; }


        [MaxFileSizeAttribute(150)]
        [AllowedExtensionAttribute(new string[] { ".jpg", ".png" })]
        public IFormFile Photo { get; set; }
    }
}
