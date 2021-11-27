using EmployeePortal_DTO;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EmployeePortal_DAL
{
    public class EMPDAL
    {
        SqlConnection sqlConObj;
        SqlCommand sqlCmdObj;
        Employee_PortalEntities CntxtObj;
        //SqlDataReader sqlDataReaderObj;
        public EMPDAL()
        {
            sqlConObj = new SqlConnection();
            sqlCmdObj = new SqlCommand();
            CntxtObj = new Employee_PortalEntities();

        }
        public int InsertNewDataIntoEmployee(Insert_DTO newObj)
        {
            try
            {
                //SQL COnnection
                sqlConObj.ConnectionString = ConfigurationManager.ConnectionStrings["EmpPortal"].ConnectionString;
                //SQL Command
                sqlCmdObj.CommandText = @"usp_insertdetail";
                sqlCmdObj.CommandType = CommandType.StoredProcedure;
                sqlCmdObj.Connection = sqlConObj;
                //Input Parameter defintion
                sqlCmdObj.Parameters.AddWithValue("@IP1", newObj.EmployeeId);
                sqlCmdObj.Parameters.AddWithValue("@IP2", newObj.FirstName);
                sqlCmdObj.Parameters.AddWithValue("@IP3", newObj.LastName);
                sqlCmdObj.Parameters.AddWithValue("@IP4", newObj.salary);
                sqlCmdObj.Parameters.AddWithValue("@IP5", newObj.DepartmentID);


                //Return Value
                SqlParameter prmReturn = new SqlParameter();
                prmReturn.Direction = ParameterDirection.ReturnValue;
                prmReturn.SqlDbType = SqlDbType.Int;
                sqlCmdObj.Parameters.Add(prmReturn);

                //OPen COnnection
                sqlConObj.Open();
                //Anything other than SELECT/INSERT/UPDATE/DELETE we use Execute Non Query
                sqlCmdObj.ExecuteNonQuery();
                return Convert.ToInt32(prmReturn.Value);
                //return "12.15";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int UpdatingTableEmployee(Update_DTO newObj1)
        {
            try
            {
                //SQL COnnection
                sqlConObj.ConnectionString = ConfigurationManager.ConnectionStrings["EmpPortal"].ConnectionString;
                //SQL Command
                sqlCmdObj.CommandText = @"usp_UpdateEmployeeDetails";
                sqlCmdObj.CommandType = CommandType.StoredProcedure;
                sqlCmdObj.Connection = sqlConObj;
                //Input Parameter defintion
                sqlCmdObj.Parameters.AddWithValue("@IP1", newObj1.EmployeeId);
                sqlCmdObj.Parameters.AddWithValue("@IP2", newObj1.FirstName);
                sqlCmdObj.Parameters.AddWithValue("@IP3", newObj1.LastName);
                sqlCmdObj.Parameters.AddWithValue("@IP4", newObj1.salary);
                sqlCmdObj.Parameters.AddWithValue("@IP5", newObj1.DepartmentID);


                //Return Value
                SqlParameter prmReturn = new SqlParameter();
                prmReturn.Direction = ParameterDirection.ReturnValue;
                prmReturn.SqlDbType = SqlDbType.Int;
                sqlCmdObj.Parameters.Add(prmReturn);

                //OPen COnnection
                sqlConObj.Open();
                //Anything other than SELECT/INSERT/UPDATE/DELETE we use Execute Non Query
                sqlCmdObj.ExecuteNonQuery();
                return Convert.ToInt32(prmReturn.Value);
                //return "12.15";
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int DeletingFromTableEmployee(Delete_DTO newObj2)
        {
            try
            {
                //SQL COnnection
                sqlConObj.ConnectionString = ConfigurationManager.ConnectionStrings["EmpPortal"].ConnectionString;
                //SQL Command
                sqlCmdObj.CommandText = @"usp_DeleteEmployee";
                sqlCmdObj.CommandType = CommandType.StoredProcedure;
                sqlCmdObj.Connection = sqlConObj;
                //Input Parameter defintion
                sqlCmdObj.Parameters.AddWithValue("@IP1", newObj2.EmployeeID);
                

                //Return Value
                SqlParameter prmReturn = new SqlParameter();
                prmReturn.Direction = ParameterDirection.ReturnValue;
                prmReturn.SqlDbType = SqlDbType.Int;
                sqlCmdObj.Parameters.Add(prmReturn);

                //OPen COnnection
                sqlConObj.Open();
                //Anything other than SELECT/INSERT/UPDATE/DELETE we use Execute Non Query
                sqlCmdObj.ExecuteNonQuery();
                return Convert.ToInt32(prmReturn.Value);
                //return "12.15";
            }
            catch (Exception ex)
            {

                throw ex;
            }

            





        }

        public void SearchingFromEmployee(Search_DTO newObj3)
        {

        }
         



    }

       
    }
