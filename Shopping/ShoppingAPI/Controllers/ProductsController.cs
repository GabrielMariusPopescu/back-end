using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ShoppingAPI.Models;

namespace ShoppingAPI.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return products;
        }

        [HttpGet("{id}", Name = "GetProduct")]
        public IActionResult Get(int id)
        {
            var product = products.FirstOrDefault(it => it.Id == id);
            return product != null ? Ok(product) : (IActionResult) NotFound();
        }

        //

        private readonly Product[] products = 
        {
            new Product {Id = 1, Name = "Mechanical Keyboard", Category = "Electronics", Price = 60},
            new Product {Id = 2, Name = "Aesop's Fables", Category = "Books", Price = 29.99M},
            new Product {Id = 3, Name = "Stand Mixer", Category = "Electronics", Price = 49.99M}
        };
    }
}
