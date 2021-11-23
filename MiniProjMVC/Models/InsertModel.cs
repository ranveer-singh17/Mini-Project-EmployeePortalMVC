using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiniProjMVC.Models
{
    public class InsertModel
    {
        public int EmployeeId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int salary { get; set; }
        public int DepartmentID { get; set; }
    }
}