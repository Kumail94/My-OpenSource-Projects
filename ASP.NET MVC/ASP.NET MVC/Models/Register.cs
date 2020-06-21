using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.NET_MVC.Models
{
    public class Register
    {
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is required")]
        public string FullName { get; set; }

        [Display(Name = "User name")]
        [Required(ErrorMessage = "User Name is required")]
        public string UserName { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Re-Password")]
        [Required(ErrorMessage = "Re-Password is required")]
        [DataType(DataType.Password)]
        [Compare(otherProperty:"Password")]
        public string RePassword { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }

        [Display(Name = "Re Email")]
        [Required(ErrorMessage = "Re Email is required")]
        [Compare(otherProperty: "Email")]
        public string ReEmail { get; set; }

        [Required(ErrorMessage ="Please select a Role Name")]
        public string Roles { get; set; }
    }
}