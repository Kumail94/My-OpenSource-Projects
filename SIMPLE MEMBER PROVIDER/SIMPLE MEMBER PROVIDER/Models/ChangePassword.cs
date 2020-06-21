using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SIMPLE_MEMBER_PROVIDER.Models
{
    public class ChangePassword
    {
        [Display(Name = "Old Password")]
        [Required(ErrorMessage = "Old Password is required")]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }

        [Display(Name = "New Password")]
        [Required(ErrorMessage = "New Password is required")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Display(Name = "Confirm NewPassword")]
        [Required(ErrorMessage = "Confirm New Password is required")]
        [DataType(DataType.Password)]
        [Compare(otherProperty: "NewPassword", ErrorMessage = "Confirm Password does not match")]
        public string ConfirmPassword { get; set; }

    }
}