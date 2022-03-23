using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOOPSApplication
{
    internal class Employee
    {
        string[] skills = new string[3];
        public int Id { get; set; }
        public string Name { get; set; }
        public string this[int index]
        {
            get {
                return skills[index]; 
            }
            set { 
                skills[index] = value; 
            }
        }
        public int this[string name]
        {
            get
            {
                int idx = -1;
                for (int i = 0; i < skills.Length; i++)
                {
                    if (skills[i] == name)
                    {
                        idx = i;
                        break;
                    }
                }
                return idx;
            }
        }
        public static Employee operator+(Employee e1,Employee e2)
        {
            Employee e = new Employee();
            e.Id = e1.Id + e2.Id;
            e.Name = e1.Name +" "+ e2.Name;
            e[0] = e1[0] + " " + e2[0];
            e[1] = e1[1] + " " + e2[1];
            e[2] = e1[2] + " " + e2[2];
            return e;
        }
        public override string ToString()
        {
            string result = "Employee ID : " + Id + "\nEmployee Name : " + Name+"\nEmployee Skills";
            for (int i = 0; i < skills.Length; i++)
            {
                result += "\n\t" + skills[i];
            }
                    
            return result;
        }
    }
}
