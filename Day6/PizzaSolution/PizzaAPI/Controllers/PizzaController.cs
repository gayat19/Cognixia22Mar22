using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaAPI.Models;
using PizzaAPI.Services;
using System.Collections.Generic;

namespace PizzaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly IRepo<int, Pizza> _repo;

        public PizzaController(IRepo<int,Pizza> repo)
        {
            _repo = repo;
        }
        [HttpPost]
        public ActionResult<Pizza> Create(Pizza pizza)
        {
            var myPizza = _repo.Add(pizza);
            if (myPizza == null)
                return BadRequest("Could not add pizza");
            return Created("Pizza added",myPizza);
        }
        [HttpGet]
        public ActionResult<ICollection<Pizza>> GetAll()
        {
            var pizzas = _repo.GetAll();
            if(pizzas == null)
                return NotFound("No pizzas available at this moment");
            return Ok(pizzas);
        }
        [HttpGet]
        [Route("GetPizzaById/{id}")]
        public ActionResult<Pizza> Get(int id)
        {
            var pizza = _repo.Get(id);
            if (pizza == null)
                return NotFound("No pizza with id "+id);
            return Ok(pizza);
        }
        [HttpPut]
        public ActionResult<Pizza> Update(int id,Pizza pizza)
        {
            var myPizza = _repo.Get(id);
            if (myPizza == null)
                return NotFound("No pizza with id " + id);
            return Ok(_repo.Update(pizza));
            
        }
        [HttpDelete]
        public ActionResult<Pizza> Delete(int id)
        {
            var myPizza = _repo.Get(id);
            if (myPizza == null)
                return NotFound("No pizza with id " + id);
            return Ok(_repo.Delete(id));
        }
    }
}
