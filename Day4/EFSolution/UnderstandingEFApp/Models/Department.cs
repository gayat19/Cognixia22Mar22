using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingEFApp.Models
{
    public  class Department
    {
        [Key]
        public int DepartmentCode { get; set; }
        public string DepartmentName { get; set; }
        public ICollection<Employee> Employees { get; set; }

    }
}
