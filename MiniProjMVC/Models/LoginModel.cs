using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiniProjMVC.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "You cannot leave Username empty")]
        
        public string Username { get; set; }

        [Required(ErrorMessage = "You cannot leave PassWord empty")]
        
        public string Password { get; set; }
    }
}             