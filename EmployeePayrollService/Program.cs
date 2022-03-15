using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePayrollService
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            {
                Console.WriteLine("Welcome to Payroll Services using ADO!");
                //Create oobject for Employee Repository
                EmployeeOperations employeeRepository = new EmployeeOperations();
                ERRepository eRRepository = new ERRepository();
                Console.WriteLine("Enter 1-To Read all Data from Sql server\nEnter 2-To Update Salary to 3000000\nEnter 3-To RetrieveQuery by name\nEnter 4-To DataBasedONRange\nEnter 5-To Retrieve All Query\nEnter 6-To UpdateSalaryQuery\n Enter 7-TO insert using Transaction\n Enter 8-To Delete Using Transaction");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        employeeRepository.GetAllEmployees();
                        break;
                    case 2:
                        employeeRepository.UpdateSalaryQuery();
                        break;
                    case 3:
                        EmployeeDataManager employeeDataManager = new EmployeeDataManager();
                        employeeDataManager.EmployeeName = "Rujula";
                        employeeRepository.RetrieveQuery(employeeDataManager);
                        break;
                    case 4:
                        employeeRepository.DataBasedOnDateRange();
                        break;
                    case 5:
                        eRRepository.RetrieveAllData();
                        break;
                    case 6:
                        eRRepository.UpdateSalaryQuery();
                        break;
                    case 7:
                    //TransactionClass transactionClass = new TransactionClass();
                    //transactionClass.InsertIntoTables();
                    //break;
                    case 8:
                        TransactionClass transactionClass = new TransactionClass();
                        int actual = transactionClass.DeleteUsingTransaction();
                        break;
                }

            }
        }
    }
}

