using CRUDApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDApplication.Services
{
    public  class ManageCart
    {
        Dictionary<int, CartPizza> cart = new Dictionary<int, CartPizza>();
        ManagePizzas managePizzas;
        public ManageCart(ManagePizzas manage)
        {
            managePizzas = manage;
        }
        public bool AddToCart(int id)
        {
            if(cart.ContainsKey(id))
            {
                Console.WriteLine("Item already present. Incrementing quantity.");
                cart[id].Quantity = cart[id].Quantity + 1;
                return true;
            }
            CartPizza cartPizza = new CartPizza();
            cartPizza.Id = id;
            //Pizza pizza = null ;
           
            List<Pizza> pizzas = managePizzas.GetAllPizzas();
            //for (int i = 0; i <pizzas.Count ; i++)
            //{
            //    if(pizzas[i].Id == id)
            //    {
            //        pizza = pizzas[i];
            //        break;
            //    }
            //}
            //LINQ
            Pizza pizza = (from p in pizzas where p.Id == id select p).First();
            cartPizza = new CartPizza();
            cartPizza.Id = pizza.Id;
            cartPizza.Name  = pizza.Name; ;
            cartPizza.Description = pizza.Description;
            cartPizza.Price = pizza.Price;
            cartPizza.Quantity = 1;
            cart.Add(id, cartPizza);
            return true;
        }
        public void PrintCart()
        {
            float total = 0;
            foreach (var item in cart.Keys)
            {
                Console.WriteLine(cart[item]);
                float amount = cart[item].Price * cart[item].Quantity;
                total += amount;
                Console.WriteLine("\tAmount - "+amount);
                Console.WriteLine("****************************");
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("Net amount "+total);
        }
        public void ClearCart()
        {
            cart.Clear();
        }
    }
}
