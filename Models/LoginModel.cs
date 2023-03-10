using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace School.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Ayyo")]
        public string Username { set; get; }
        [Required(ErrorMessage = "...")]
        public string Password { set; get; }

        public bool RememberMe { set; get; }    
    }
}