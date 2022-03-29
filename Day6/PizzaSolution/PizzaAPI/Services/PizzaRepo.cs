using PizzaAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace PizzaAPI.Services
{
    public class PizzaRepo : IRepo<int, Pizza>
    {
        static List<Pizza> pizzas = new List<Pizza>();
        public Pizza Add(Pizza item)
        {
            pizzas.Add(item);
            return item;
        }

        public Pizza Delete(int key)
        {
            var pizza = Get(key);
            pizzas.Remove(pizza);
            return pizza;
        }

        public Pizza Get(int key)
        {
            Pizza pizza = pizzas.FirstOrDefault(p=>p.Id == key);
            return pizza;
        }

        public ICollection<Pizza> GetAll()
        {
            return pizzas;
        }

        public Pizza Update(Pizza item)
        {
            var pizza = Get(item.Id);
            if (pizza == null)
                return null;
            pizza.Name = item.Name;
            pizza.Description = item.Description;
            pizza.Price = item.Price;
            return pizza;
        }
    }
}
