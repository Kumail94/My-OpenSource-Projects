using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SIMPLE_MEMBER_PROVIDER.Models
{
    public class User
    {
        [Display(Name = "User Name")]
        [Required(ErrorMessage ="User name is required")]
        public string Username { get; set; }

        [Display(Name = "Password")]
        [Required(ErrorMessage ="Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name ="Remeber Me")]
        public bool RememberMe { get; set; }
    }
}