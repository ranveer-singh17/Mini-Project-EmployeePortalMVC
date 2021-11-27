using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiniProjMVC.Models
{
    public class DeleteModel
    {
        [Required(ErrorMessage = "You cannot leave Department Name empty")]
        [Display(Name = "Enter the ID for which data has to be deleted")]
        public int EmployeeID { get; set; }
    }
}