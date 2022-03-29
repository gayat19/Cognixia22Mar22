using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRUDApplication.Models;

namespace CRUDApplication.Services
{
    public class ManagePizzas
    {
        List<Pizza> pizzas = new List<Pizza>();
        public bool AddPizza()
        {
            Pizza pizza = new Pizza();
            pizza.GetPizzaDetailsFromUser();
            pizzas.Add(pizza);
            return true;
        }
        public void AddPizzas()
        {
            int choice = 0;
            do
            {   AddPizza();
                Console.WriteLine("Do you want to add more? if not enter 0");
                choice = Convert.ToInt32(Console.ReadLine());
            } while (choice !=0);
        }
        public List<Pizza> GetAllPizzas()
        {
            return pizzas;
        }
        public void PrintAllPizzas()
        {
            foreach (var pizza in pizzas)
                Console.WriteLine(pizza);
        }
    }
}
