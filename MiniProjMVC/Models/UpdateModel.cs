using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiniProjMVC.Models
{
    public class UpdateModel
    {
        [Required(ErrorMessage = "You cannot leave FirstName empty")]
        [Display(Name ="Enter the ID where data has to be updated")]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "You cannot leave FirstName empty")]

        public string FirstName { get; set; }
        [Required(ErrorMessage = "You cannot leave LastName empty") ]

        public string LastName { get; set; }
        [Required(ErrorMessage = "You cannot leave salary empty")]


        public int salary { get; set; }
        [Required(ErrorMessage = "You cannot leave DepartmentID empty")]
        public int DepartmentID { get; set; }
    }
}