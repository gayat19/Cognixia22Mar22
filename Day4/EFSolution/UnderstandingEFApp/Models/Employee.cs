using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingEFApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public float Salary { get; set; }
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }
        public override string ToString()
        {
            return Id + " " + Name + " " + Age + " " + Phone + " " + Salary + DepartmentId;
        }
        public void GetEmployeeDataFromUser()
        {
            Console.WriteLine("Please enter the employee name");
            Name =Console.ReadLine();
            Console.WriteLine("Please enter the employee age ");
            Age =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the employee salary ");
            Salary = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the employee Phone");
            Phone = Console.ReadLine();
        }
    }
}
