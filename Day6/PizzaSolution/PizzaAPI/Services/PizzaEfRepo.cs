using Microsoft.Extensions.Logging;
using PizzaAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaAPI.Services
{
    public class PizzaEfRepo : IRepo<int, Pizza>
    {
        private readonly PizzaContext _context;
        private readonly ILogger<PizzaEfRepo> _logger;

        public PizzaEfRepo(PizzaContext context,ILogger<PizzaEfRepo> logger)
        {
            _context = context;
            _logger = logger;
        }
        public Pizza Add(Pizza item)
        {
            try
            {
                _context.Pizzas.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception exception)
            {
                _logger.LogError(exception.Message);
                _logger.LogError("----" + DateTime.Now.ToString());
            }
            return null;
        }

        public Pizza Delete(int key)
        {
            var item = Get(key);
            if(item == null)
                return null;
            try
            {
                _context.Pizzas.Remove(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception exception)
            {
                _logger.LogError(exception.Message);
                _logger.LogError("----" + DateTime.Now.ToString());
            }
            return null;
           
        }

        public Pizza Get(int key)
        {
            var item = _context.Pizzas.FirstOrDefault(p => p.Id == key);
            return item;
        }

        public ICollection<Pizza> GetAll()
        {
            return _context.Pizzas.ToList();
        }

        public Pizza Update(Pizza item)
        {
            var pizza = Get(item.Id);
            if (pizza == null)
                return null;
            pizza.Name = item.Name;
            pizza.Price = item.Price;
            pizza.Description = item.Description;
            try
            {
                _context.SaveChanges();
                return pizza;
            }
            catch (Exception exception)
            {
                _logger.LogError(exception.Message);
                _logger.LogError("----" + DateTime.Now.ToString());
            }
            return null;
           
           
        }
    }
}
