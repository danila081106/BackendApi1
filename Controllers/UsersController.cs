using BackendApi1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class UsersController : ControllerBase
    {
        public Платформа_для_заказа_и_доставки_свежих_фруктов_и_овощей_с_ферм1Context Context { get; set; }
        public UsersController(Платформа_для_заказа_и_доставки_свежих_фруктов_и_овощей_с_ферм1Context context)
        {
            Context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<User> users = Context.Users.ToList();  
            return Ok(users);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            User? user = Context.Users.Where(x => x.Id == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Not found");
            }
            return Ok(user);
        }
        [HttpPost]
        public IActionResult Add(User user, int id)
        {
            if (id < 0)
            {
                return BadRequest("Такой id не существует!!!!!!");
            }
            Context.Users.Add(user);
            Context.SaveChanges();
            return Ok(user);
        }
        [HttpPut]
        public IActionResult Update(User user, int id)
        {
            if (id < 0)
            {
                return BadRequest("Такой id не существует!!!!!!");
            }
            Context.Users.Update(user);
            Context.SaveChanges();
            return Ok(user);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (id < 0)
            {
                return BadRequest("Такой id не существует!!!!!!");
            }
            User? user = Context.Users.Where(x => x.Id == id).FirstOrDefault();
            if (user == null)
            {
                return BadRequest("Not found");
            }
            Context.Users.Remove(user);
            Context.SaveChanges();
            return Ok();
        }
    }
}
