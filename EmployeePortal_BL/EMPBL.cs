using EmployeePortal_BL;
using EmployeePortal_DAL;
using EmployeePortal_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Portal_BL
{
    public class EMPBL 
    {
        EMPDAL objdal;

        public EMPBL()
        {
             objdal = new EMPDAL();
        }
        public int AddEmployee(Insert_DTO newObj)
        {
            try
            {
                
                int result = objdal.InsertNewDataIntoEmployee(newObj);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int Delete(Delete_DTO newObj2)
        {
            try
            {
                
                int result = objdal.DeletingFromTableEmployee(newObj2);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public int UpdateEmployee(Update_DTO newObj1)
        {
            try
            {
                
                int result = objdal.UpdatingTableEmployee(newObj1);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


        public List<Search_DTO> SearchEmployee()
        {
            try
            {

               List<Search_DTO> result = objdal.SearchingFromTableEmployee();
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        


        public int Login(Login_DTO newObj4)
        {
            try
            {

                int result = objdal.Login(newObj4);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }


    }
}
