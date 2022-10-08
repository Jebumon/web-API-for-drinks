using Microsoft.AspNetCore.Mvc;
namespace API_Interactive_Lab_1.Controllers
{
    [ApiController]
    [Route("Controller")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Welcome to the Drinks API!";
        }

    }

    [Route("Noodles")]
    public class NoodlesController : ControllerBase
    {
        [Route("Magie Noodles")]
        [HttpGet]
        public string MagieGet()
        {
            return "Welcome to the Magie Noodles !";
        }

        [Route("Pepi Noodles")]
        [HttpGet]
        public string PepiGet()
        {
            return "Welcome to the Pepi Noodles !";
        }
    }
}

