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
    public class LoginController : Controller
    {
        // GET: Login
        EMPBL Objbl;

        public LoginController()
        {
            Objbl = new EMPBL();
        }
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginModel newobj)
        {
            try
            {
                Login_DTO newDeptDTOObj = new Login_DTO()
                {
                   Username = newobj.Username,
                   Password = newobj.Password


                };
                int result = Objbl.Login(newDeptDTOObj);
                 if (result == 1)
                {
                    return RedirectToAction("Index", "Home");
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