using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiniProjMVC.Models
{
    public class InsertModel
    {
        [Required(ErrorMessage = "You cannot leave EmployeeId  empty")]
        public int EmployeeId { get; set; }
        [Required(ErrorMessage = "You cannot leave irstName empty")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "You cannot leave LastName empty")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "You cannot leave salary  empty")]
        public int salary { get; set; }

        [Required(ErrorMessage = "You cannot leave DepartmentID  empty")]

        public int DepartmentID { get; set; }
    }
}