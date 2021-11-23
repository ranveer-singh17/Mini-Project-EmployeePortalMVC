using Employee_Portal_BL;
using EmployeePortal_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Portal_App
{
    class Program
    {
        static void Main(string[] args)


        {
            var username = "adonet";
            var password = 7;

            Console.WriteLine("enter username\n");
            var user = Console.ReadLine();
            Console.WriteLine("enter password\n");
            var pass = Convert.ToInt32(Console.ReadLine());
            if(user == username && pass == password)
            {
                choices();
            }
            else
            {
                Console.WriteLine("wrong Credentials\n");
                
            }

            void choices()
            {

                Console.WriteLine("enter 1 for inserting employee details\n");
                Console.WriteLine("enter 2 for updating employee details\n");
                Console.WriteLine("enter 3 for deleting employee details\n");
                Console.WriteLine("enter your choice");
                var choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                   
                    case 1:
                        main_method();
                        break;
                    case 2:
                        main_method1();
                        break;
                    case 3:
                        main_method2();
                        break;
                    default:
                        break;
                        





                }
            }





            void main_method1()
            {
                try
                {
                    EMPBL Objbl = new EMPBL();

                    Console.WriteLine("Enter the value for EmployeeId:");
                    int userInputOne = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the FirstName:");
                    string userInputTwo = Console.ReadLine();
                    Console.WriteLine("Enter the LastName:");
                    string userInputThree = Console.ReadLine();
                    Console.WriteLine("Enter the value for salary:");
                    int userInputFour = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the DepartmentID:");
                    int userInputFive = Convert.ToInt32(Console.ReadLine());



                    Update_DTO UpEmployeeObj = new Update_DTO();
                    UpEmployeeObj.EmployeeId = userInputOne;
                    UpEmployeeObj.FirstName = userInputTwo;
                    UpEmployeeObj.LastName = userInputThree;
                    UpEmployeeObj.salary = userInputFour;
                    UpEmployeeObj.DepartmentID = userInputFive;



                    int result = Objbl.UpdateDataIntoEmployee(UpEmployeeObj);
                    if (result == 1)
                    {
                        Console.WriteLine("Data Saved Successfully");
                    }
                    else if (result == -1 || result == -2 || result == -3 || result == -4 || result == -5 || result == -6 || result == -7)
                    {
                        Console.WriteLine("Check the input values for null/empty data");
                    }
                    else
                    {
                        Console.WriteLine("Data did not save");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("something wrong");
                    Console.WriteLine(ex.Message);
                }
            }



            void main_method()
            {
                try
                {
                    EMPBL Objbl = new EMPBL();

                    Console.WriteLine("Enter the value for EmployeeId:");
                    int userInputOne = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the FirstName:");
                    string userInputTwo = Console.ReadLine();
                    Console.WriteLine("Enter the LastName:");
                    string userInputThree = Console.ReadLine();
                    Console.WriteLine("Enter the value for salary:");
                    int userInputFour = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the DepartmentID:");
                    int userInputFive = Convert.ToInt32(Console.ReadLine());



                    Departments_DTO newEmployeeObj = new Departments_DTO();
                    newEmployeeObj.EmployeeId = userInputOne;
                    newEmployeeObj.FirstName = userInputTwo;
                    newEmployeeObj.LastName = userInputThree;
                    newEmployeeObj.salary = userInputFour;
                    newEmployeeObj.DepartmentID = userInputFive;



                    int result = Objbl.SaveDataIntoEmployeeTable(newEmployeeObj);
                    if (result == 1)
                    {
                        Console.WriteLine("Data Saved Successfully");
                    }
                    else if (result == -1 || result == -2 || result == -3 || result == -4 || result == -5 || result == -6 || result == -7)
                    {
                        Console.WriteLine("Check the input values for null/empty data");
                    }
                    else
                    {
                        Console.WriteLine("Data did not save");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("something wrong");
                    Console.WriteLine(ex.Message);
                }
            }

            void main_method2()
            {
                try
                {
                    EMPBL Objbl = new EMPBL();

                    Console.WriteLine("Enter the value for EmployeeId:");
                    int userInputOne = Convert.ToInt32(Console.ReadLine());
                    



                    Delete_DTO DLEmployeeObj = new Delete_DTO();
                    DLEmployeeObj.EmployeeId = userInputOne;
                    ;



                    int result = Objbl.Delete(DLEmployeeObj);
                    if (result == 1)
                    {
                        Console.WriteLine("Data Saved Successfully");
                    }
                    else if (result == -1 || result == -2 )
                    {
                        Console.WriteLine("Check the input values for null/empty data");
                    }
                    else
                    {
                        Console.WriteLine("Data did not save");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("something wrong");
                    Console.WriteLine(ex.Message);
                }
            }


        }
    }
}

