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
    public class UpdateController : Controller
    {
        EMPBL Objbl;

        public UpdateController()
        {
            Objbl = new EMPBL();
        }
        // GET: Insert
        public ActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Update(UpdateModel newDept)
        {
            try
            {
                Update_DTO newDeptDTOObj = new Update_DTO()
                {
                    EmployeeId = newDept.EmployeeId,
                    FirstName = newDept.FirstName,
                    LastName = newDept.LastName,
                    salary = newDept.salary,
                    DepartmentID = newDept.DepartmentID,
                };
                int result = Objbl.UpdateEmployee(newDeptDTOObj);
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