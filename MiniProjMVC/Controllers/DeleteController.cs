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
    public class DeleteController : Controller
    {
        EMPBL Objbl;

        public DeleteController()
        {
            Objbl = new EMPBL();
        }
        // GET: Insert
        public ActionResult DeleteDept()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DeleteDept(DeleteModel newobj)
        {
            try
            {
                Delete_DTO newDeptDTOObj = new Delete_DTO()
                {
                    EmployeeID = newobj.EmployeeID,
                    
                    
                };
                int result = Objbl.Delete(newDeptDTOObj);
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