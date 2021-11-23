using Employee_Portal_BL;
using EmployeePortal_BL;
using EmployeePortal_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EmpPortalAPI.Controllers
{
    public class MainController : ApiController
    {
        private readonly IEMPBL Blobj;

        

        //Mocking of your BL : Testing of Controller
        public MainController(IEMPBL iObj)
        {
            Blobj = iObj;
        }


        public MainController() : this(new EMPBL())
        {

        }
        [HttpPost]
        public HttpResponseMessage AddEmployee(Departments_DTO newObj)
        {
            try
            {
                if (newObj != null)
                {

                    EMPBL Blobj = new EMPBL();
                    var result = Blobj.AddEmployee(newObj);
                    if (result == 0)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, "Employee Details added successfully");
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.InternalServerError, "Department not added");

                    }
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Check all input values for department");
                }

            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);

            }
        }


        [HttpPost]
        public HttpResponseMessage UpdateEmployee(Update_DTO newObj1)
        {
            try
            {
                if (newObj1 != null)
                {

                    EMPBL Blobj = new EMPBL();
                    var result = Blobj.UpdateEmployee(newObj1);
                    if (result == 0)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, "Employee Details updated successfully");
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.InternalServerError, "Employee Details not added");

                    }
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Check all input values for department");
                }

            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);

            }
        }


    


    [HttpPost]
        public HttpResponseMessage Delete(Delete_DTO newObj2)
        {
            try
            {
                if (newObj2 != null)
                {

                    EMPBL Blobj = new EMPBL();
                    var result = Blobj.Delete(newObj2);
                    if (result == 0)
                    {
                        return Request.CreateResponse(HttpStatusCode.OK, "Employee Details deleted successfully");
                    }
                    else
                    {
                        return Request.CreateResponse(HttpStatusCode.InternalServerError, "Employee Details not deleted");

                    }
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Check all input values for department");
                }

            }
            catch (Exception ex)
            {

                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);

            }
        }
    }
}
