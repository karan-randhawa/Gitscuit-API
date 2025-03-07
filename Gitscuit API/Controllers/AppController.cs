using GitscuitAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GitscuitAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppController : ControllerBase
    {
        private AppService appService { get; set; }

        public AppController(AppService appService)
        {
            this.appService = appService;
        }

        public IActionResult Get()
        {
            return Ok(appService.Connect());
        }
    }
}
