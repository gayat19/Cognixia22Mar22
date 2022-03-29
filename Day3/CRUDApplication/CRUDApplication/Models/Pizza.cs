using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDApplication.Models
{
    public class Pizza
    {
        public int Id { get; set; }
        public string Name{ get; set; }
        public float Price { get; set; }
        public string Description { get; set; }

        public override bool Equals(object obj)
        {
            Pizza p1 = this;//p1 will reff to the Current object
            //Pizza p2 =  (Pizza)obj;//Conventional casting
            Pizza p2 = obj as Pizza;//p2 will ref to the parameter-converted to pizza
            return p1.Id == p2.Id;
        }
        public override string ToString()
        {
            return "Pizza ID : " + Id
                + "\nPizza Name : " + Name
                + "\nPizza Price : " + Price
                + "\nPizza Description : " + Description;
        }
        public void GetPizzaDetailsFromUser()
        {
            Console.WriteLine("Please enter the Pizza ID");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter teh pizza name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the pizza price");
            Price = float.Parse(Console.ReadLine());
            Console.WriteLine("Please enter the pizza description");
            Description = Console.ReadLine();
        }
    }
}
