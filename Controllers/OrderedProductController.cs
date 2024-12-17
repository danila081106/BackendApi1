using BackendApi1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendApi1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderedProductController : ControllerBase
    {
        public Платформа_для_заказа_и_доставки_свежих_фруктов_и_овощей_с_ферм1Context Context { get; set; }
        public OrderedProductController(Платформа_для_заказа_и_доставки_свежих_фруктов_и_овощей_с_ферм1Context context)
        {
            Context = context;
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Product> products = Context.Products.ToList();
            return Ok(products);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            Product? product = Context.Products.Where(x => x.Id == id).FirstOrDefault();
            if (product == null)
            {
                return BadRequest("Not found");
            }
            return Ok(product);
        }
        [HttpPost]
        public IActionResult Add(Product product, int id)
        {
            if (id < 0)
            {
                return BadRequest("Такой id не существует!!!!!!");
            }
            Context.Products.Add(product);
            Context.SaveChanges();
            return Ok(product);
        }
        [HttpPut]
        public IActionResult Update(Product product, int id)
        {
            if (id < 0)
            {
                return BadRequest("Такой id не существует!!!!!!");
            }
            Context.Products.Update(product);
            Context.SaveChanges();
            return Ok(product);
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            if (id < 0)
            {
                return BadRequest("Такой id не существует!!!!!!");
            }
            Product? product = Context.Products.Where(x => x.Id == id).FirstOrDefault();
            if (product == null)
            {
                return BadRequest("Not found");
            }
            Context.Products.Remove(product);
            Context.SaveChanges();
            return Ok();
        }
    }
}
