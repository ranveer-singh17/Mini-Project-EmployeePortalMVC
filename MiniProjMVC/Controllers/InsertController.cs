using Employee_Portal_BL;
using EmployeePortal_DTO;
using MiniProjMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniProjMVC.Controllers
{
    public class InsertController : Controller
    {

        EMPBL Objbl;

        public InsertController()
        {
               Objbl = new EMPBL();    
        }
        // GET: Insert
        public ActionResult Insertdept()
        {
            return View();
        }

        [HttpPost]
        public ActionResult InsertDept(InsertModel newDept)
        {
            try
            {
                Insert_DTO newDeptDTOObj = new Insert_DTO()
                {
                    EmployeeId = newDept.EmployeeId, 
                    FirstName = newDept.FirstName,
                    LastName = newDept.LastName,
                    salary = newDept.salary,
                    DepartmentID = newDept.DepartmentID,    
                };
                int result = Objbl.AddEmployee(newDeptDTOObj);
                if (result == 0)
                {
                    return View("Success");
                }
                else
                {
                    return View("Error");
                }
            }
            catch (Exception ex)
            {

                return View("Error");
            }
        }
    }
}
