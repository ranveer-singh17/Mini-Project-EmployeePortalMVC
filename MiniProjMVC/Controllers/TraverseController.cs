using MiniProjMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiniProjMVC.Controllers
{
    public class TraverseController : Controller
    {
        EmployeePortalEntities Db = new EmployeePortalEntities();
        // GET: Search
        public ActionResult Search(String SearchElement)
        {
            return View(Db.employees.Where(x=>x.FirstName.StartsWith(SearchElement)).ToList());
        }


    }
} 