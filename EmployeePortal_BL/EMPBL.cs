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
        public int AddEmployee(Insert_DTO newObj)
        {
            try
            {
                EMPDAL objdal = new EMPDAL();
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
                EMPDAL objdal = new EMPDAL();
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
                EMPDAL objdal = new EMPDAL();
                int result = objdal.UpdatingTableEmployee(newObj1);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public int SearchEmployee(Search_DTO newObj3)
        {
            try
            {
                EMPDAL objdal = new EMPDAL();
                result = objdal.SearchingFromTableEmployee(newObj3);
                return result;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
