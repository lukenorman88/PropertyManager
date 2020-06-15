using Microsoft.AspNetCore.Mvc;

namespace PropertyManager.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Ok("Property manager api home.");
        }
    }
}
