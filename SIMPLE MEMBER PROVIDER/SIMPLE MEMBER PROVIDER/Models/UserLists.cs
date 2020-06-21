using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SIMPLE_MEMBER_PROVIDER.Models
{
    public class UserLists
    {
        [Display(Name = "User Id")]
        public int UserId { get; set; }

        [Display(Name = "User Name")]
        [Required(ErrorMessage = "User Name is Required")]
        public string UserName { get; set; }

        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Full Name is Required")]
        public string FullName { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Address is Required")]
        public string Address { get; set; }


    }
}