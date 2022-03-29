using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnderstandingEFApp.Models;

namespace UnderstandingEFApp.Services
{
    public  class ManageEmployees
    {
        readonly CompanyContext _context;
        public ManageEmployees()
        {
            _context = new CompanyContext();
        }
        public void PrintAllEmployees()
        {
            //select query
            List<Employee> employees = _context.Employees.ToList();
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
        }
        public void AddEmployee()
        {
            Employee employee = new Employee();
            employee.GetEmployeeDataFromUser();
            Console.WriteLine("Select the department");
            foreach (var item in _context.Departments)
            {
                Console.WriteLine(item.DepartmentCode+" "+item.DepartmentName);
            }
            employee.DepartmentId = Convert.ToInt32(Console.ReadLine());
            _context.Employees.Add(employee);
            //executes the insert query
            _context.SaveChanges();//pushes the change to database
        }
        public void EditEmployee(Employee employee)
        {
            //select * from employees where id = 101
            List<Employee> employees = _context.Employees.ToList();
            Employee myEmployee = employees.SingleOrDefault(emp=>emp.Id==employee.Id);
            myEmployee.Name = employee.Name;
            myEmployee.Age = employee.Age;
            myEmployee.Phone = employee.Phone;
            myEmployee.DepartmentId = employee.DepartmentId;
            _context.SaveChanges();//excuet the update query
        }
        public void DeleteEmployee(int id)
        {
            List<Employee> employees = _context.Employees.ToList();
            Employee myEmployee = employees.SingleOrDefault(emp => emp.Id == id);
            _context.Employees.Remove(myEmployee);
            _context.SaveChanges();//execute teh delete query
        }
    }
}
