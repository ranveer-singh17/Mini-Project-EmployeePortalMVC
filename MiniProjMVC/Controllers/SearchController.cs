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
    public class SearchController : Controller
    {
         EMPBL Objbl;

            public SearchController()
            {
                Objbl = new EMPBL();
            }
            // GET: Insert
            public ActionResult Search()
            {
                return View();
            }

            [HttpPost]
            public ActionResult Search(SearchModel newobj)
            {
                try
                {
                    Search_DTO newDeptDTOObj = new Search_DTO()
                    {
                        EmployeeId = newobj.EmployeeId,


                    };
                    int result = Objbl.SearchEmployee(newDeptDTOObj);
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