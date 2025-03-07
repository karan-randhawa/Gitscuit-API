using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gitscuit_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppController : ControllerBase
    {
        public IActionResult Get()
        {
            return Ok("Gitscuit API is running.");
        }
    }
}
