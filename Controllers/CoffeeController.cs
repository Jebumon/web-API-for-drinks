using Microsoft.AspNetCore.Mvc;
using API_Interactive_Lab_1.Models;

namespace API_Interactive_Lab_1.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CoffeeController : Controller
    {
        [HttpGet("{name}")]
        public Coffee Get(string? name)
        {
            return new Coffee {Id = (name != null ? 7 : -1), Name = name ?? "latte"};
        }


        [HttpGet("Coffee lover")]
        public string GetLoveCoffee()
        {
            return "I like coffee!";
        }
    }
}
