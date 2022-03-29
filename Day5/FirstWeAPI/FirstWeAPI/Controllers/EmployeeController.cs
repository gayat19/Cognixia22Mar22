using FirstWeAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FirstWeAPI.Controllers
{
    //API controller empty
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        static List<Employee> employees = new List<Employee>()
        {
            new Employee(){Id = 101, Name ="Tim"},
            new Employee(){Id = 102, Name ="Jim"}
        };
        [HttpGet]
        public List<Employee> GetEmployees()
        {
            return employees;
        }
        [HttpPost]
        public void CreateEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        [Route("GetEmployeeById/{id}")]//Attribute based routing
        [HttpGet]
        public Employee GetEmployees(int id)
        {
            var employee = employees.FirstOrDefault(emp => emp.Id == id);
            return employee;
        }
        [HttpPut]
        public Employee UpdateEmployee(int id,Employee employee)
        {
            var emp = employees.FirstOrDefault(emp => emp.Id == id);
            if (emp == null)
                return null;
            emp.Name = employee.Name;
            emp.Age = employee.Age;
            return employee;
        }
        [HttpDelete]
        public Employee DeleteEmployee(int id)
        {
            var emp = employees.FirstOrDefault(emp => emp.Id == id);
            if (emp == null)
                return null;
            int idx = employees.IndexOf(emp);
            employees.RemoveAt(idx);
            return emp;
        }
    }
}
