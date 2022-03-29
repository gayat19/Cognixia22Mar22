using System;
using UnderstandingEFApp.Models;
using UnderstandingEFApp.Services;

namespace UnderstandingEFApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            ManageEmployees manageEmployees = new ManageEmployees();
            //Employee employee = new Employee();
            // employee.Id = 101;
            // employee.Name = "Sim";
            // employee.Age = 40;
            // employee.DepartmentId = 1;
            // employee.Phone = "1233481282123";
            // employee.Salary = 12334.5f;
            // manageEmployees.EditEmployee(employee);
            //manageEmployees.DeleteEmployee(101);
            manageEmployees.AddEmployee();
            manageEmployees.PrintAllEmployees();
        }
    }
}
