using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingEFApp.Models
{
    public class CompanyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-86CRKFR\SQLEXPRESS;user id=sa;password=P@ssw0rd;Initial Catalog=dbPizzaStore25Mar2022;");
        }
        //Employees is the table name
        //Columns are the properties in the employee class
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>().HasData(
                new Department()
                { 
                    DepartmentCode = 1, 
                    DepartmentName = "Ops" 
                },
                new Department()
                {
                    DepartmentCode = 2,
                    DepartmentName = "Admin"
                }); ;
            modelBuilder.Entity<Employee>().HasData(new Employee()
            {
                Id = 101,
                Name = "Tim",
                Age = 26,
                Salary = 12334.5f,
                Phone = "9876543210",
                DepartmentId=1
            });
        }
    }
}
